using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect1.Models
{
    public class Appointment
    {
        public Appointment()
        {
            ClientName = string.Empty;
           
        }

       
        public int ID { get; set; }

        [Required]
        [Display(Name = "Client Name")]
        public string? ClientName { get; set; }
        public int ServiceID { get; set; }  // Cheie străină pentru Service

        // Proprietate de navigare opțională
        public Service? Service { get; set; }
      
        [Required]
        

        [DataType(DataType.Date)]
        [Display(Name = "Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        // Foreign key for Stylist
        public int StylistID { get; set; }

        // Navigation property
        public Stylist? Stylist { get; set; }
        

    }
}

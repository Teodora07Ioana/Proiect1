using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect1.Models
{
    public class Client
    {
        public Client()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Appointments = new List<Appointment>();
        }
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

    
        public string Email { get; set; }
        public string? Phone { get; set; }

        // Navigation property for related Appointments
        public ICollection<Appointment> Appointments { get; set; }
    }
}

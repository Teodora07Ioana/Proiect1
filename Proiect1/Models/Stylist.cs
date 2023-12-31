using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect1.Models
{
    public class Stylist
    {
        public Stylist()
        {
            Name = string.Empty;
            Specialization = string.Empty;
            Appointments = new List<Appointment>();
        }
        public int ID { get; set; }

        [Required]
        [Display(Name = "Stylist Name")]
        public string? Name { get; set; }

        [Display(Name = "Specialization")]
        public string? Specialization { get; set; }

        // Navigation property for related Appointments
        public ICollection<Appointment> Appointments { get; set; }
    }
}

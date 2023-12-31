using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect1.Models;

namespace Proiect1.Data
{
    public class Proiect1Context : DbContext
    {
        public Proiect1Context (DbContextOptions<Proiect1Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect1.Models.Appointment> Appointment { get; set; } = default!;
        public DbSet<Proiect1.Models.Client> Client { get; set; } = default!;
        public DbSet<Proiect1.Models.Stylist> Stylist { get; set; } = default!;
        public DbSet<Proiect1.Models.Service> Service { get; set; } = default!;
        public DbSet<Proiect1.Models.Product> Product { get; set; } = default!;
    }
}

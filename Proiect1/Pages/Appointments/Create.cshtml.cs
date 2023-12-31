using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect1.Data;
using Proiect1.Models;

namespace Proiect1.Pages.Appointments
{
    public class CreateModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public CreateModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["StylistID"] = new SelectList(_context.Set<Stylist>(), "ID", "Name");

            Services = await _context.Service
                .Select(s => new SelectListItem
                {
                    Value = s.ServiceID.ToString(),
                    Text = s.Name
                }).ToListAsync();

            return Page();
        }

        [BindProperty]
        public Appointment? Appointment { get; set; }

        // Lista pentru dropdown
        public List<SelectListItem> Services { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Appointment.Add(Appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect1.Data;
using Proiect1.Models;

namespace Proiect1.Pages.Stylists
{
    public class CreateModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public CreateModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();

        }

        [BindProperty]
        public Stylist? Stylist { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Stylist==null || Stylist==null)
            {
                return Page();
            }

            _context.Stylist.Add(Stylist);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

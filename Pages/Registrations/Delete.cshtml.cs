using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineTestBooking_EF.Data;
using OnlineTestBooking_EF.Models;

namespace OnlineTestBooking_EF.Pages.Registrations
{
    public class DeleteModel : PageModel
    {
        private readonly OnlineTestBooking_EF.Data.OnlineTestBooking_EFContext _context;

        public DeleteModel(OnlineTestBooking_EF.Data.OnlineTestBooking_EFContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Registration Registration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Registration = await _context.Registration.FirstOrDefaultAsync(m => m.ID == id);

            if (Registration == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Registration = await _context.Registration.FindAsync(id);

            if (Registration != null)
            {
                _context.Registration.Remove(Registration);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineTestBooking_EF.Data;
using OnlineTestBooking_EF.Models;

namespace OnlineTestBooking_EF.Pages.Registrations
{
    public class CreateModel : PageModel
    {
        private readonly OnlineTestBooking_EF.Data.OnlineTestBooking_EFContext _context;

        public CreateModel(OnlineTestBooking_EF.Data.OnlineTestBooking_EFContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Registration Registration { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Registration.Add(Registration);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

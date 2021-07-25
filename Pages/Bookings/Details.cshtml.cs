using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineTestBooking_EF.Data;
using OnlineTestBooking_EF.Models;

namespace OnlineTestBooking_EF.Pages.Bookings
{
    public class DetailsModel : PageModel
    {
        private readonly OnlineTestBooking_EF.Data.OnlineTestBooking_EFContext _context;

        public DetailsModel(OnlineTestBooking_EF.Data.OnlineTestBooking_EFContext context)
        {
            _context = context;
        }

        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Booking
                .Include(b => b.Registration).FirstOrDefaultAsync(m => m.ID == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

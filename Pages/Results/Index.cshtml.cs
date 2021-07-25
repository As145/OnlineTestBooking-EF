﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineTestBooking_EF.Data;
using OnlineTestBooking_EF.Models;

namespace OnlineTestBooking_EF.Pages.Results
{
    public class IndexModel : PageModel
    {
        private readonly OnlineTestBooking_EF.Data.OnlineTestBooking_EFContext _context;

        public IndexModel(OnlineTestBooking_EF.Data.OnlineTestBooking_EFContext context)
        {
            _context = context;
        }

        public IList<Result> Result { get;set; }

        public async Task OnGetAsync()
        {
            Result = await _context.Result
                .Include(r => r.Registration).ToListAsync();
        }
    }
}

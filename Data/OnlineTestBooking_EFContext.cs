using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineTestBooking_EF.Models;

namespace OnlineTestBooking_EF.Data
{
    public class OnlineTestBooking_EFContext : DbContext
    {
        public OnlineTestBooking_EFContext (DbContextOptions<OnlineTestBooking_EFContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineTestBooking_EF.Models.Booking> Booking { get; set; }

        public DbSet<OnlineTestBooking_EF.Models.Registration> Registration { get; set; }

        public DbSet<OnlineTestBooking_EF.Models.Result> Result { get; set; }
    }
}

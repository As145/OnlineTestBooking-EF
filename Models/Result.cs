using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestBooking_EF.Models
{
    public class Result
    {
        [Key]//Add primary key
        public int ID { get; set; }// ID is primary key 
        public int RegistrationID { get; set; } // Registration ID coming from class registration
        public int BookingID { get; set; }// Add Booking ID

        public int Score { get; set; }//Add Score

        public Registration Registration { get; set; } //Linking to registration class
    }
}

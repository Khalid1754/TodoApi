using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingApp.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public Show Show { get; set; }
        public int ShowId { get; set; }
        public string BookingNr { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public bool IsComplete { get; set; }

    }
}

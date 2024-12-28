using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingApp.Models
{
    public class Show
    {
        [Key]
        public int Id { get; set; }
        public int? ConcertId { get; set; }
        public Concert? Concert { get; set; }
        public string? Location { get; set; }
        public DateTime DateTime { get; set; }
    }
}

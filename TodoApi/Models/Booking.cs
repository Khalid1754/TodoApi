using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
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
    }
}

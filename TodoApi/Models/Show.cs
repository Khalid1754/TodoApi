using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Show
    {
        [Key]
        public int Id { get; set; }
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
        public string Location { get; set; }
        public DateTime DateTime { get; set; }
    }
}

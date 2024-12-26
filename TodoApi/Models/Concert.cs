using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public string? Genre { get; set; }
    }
}

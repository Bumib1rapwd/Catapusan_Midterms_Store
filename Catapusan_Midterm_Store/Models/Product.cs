using System.ComponentModel.DataAnnotations;

namespace Catapusan_Midterm_Store.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; } = "";
    }
}
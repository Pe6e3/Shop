using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Brands
    {
        [Key]
        public int Brand_id { get; set; }
        public string? Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Categories
    {
        [Key]
        public int Category_id { get; set; }
        public string? Name { get; set; }

    }
}

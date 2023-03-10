namespace Shop.Models
{
    public class Product
    {
        public int Product_id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Info { get; set; }

        public int Category_id { get; set; }
        public Category Category { get; set; }
        public int Brand_id { get; set; }
        public Brand Brand { get; set; }
    }
}

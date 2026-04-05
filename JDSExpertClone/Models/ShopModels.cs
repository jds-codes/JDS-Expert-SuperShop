using System.ComponentModel.DataAnnotations;

namespace JDSExpertClone.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }

    // কার্ট আইটেম (অর্ডার করার জন্য)
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
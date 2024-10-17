

namespace ServerABBKCOSY.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Связь "один ко многим" с категорией
        public Category Category { get; set; }

        // Связи "один ко многим"
        public ICollection<ProductImage> ProductImages { get; set; }
        // Связь "один ко многим" с отзывами
        public ICollection<Review> Reviews { get; set; }
        // Связь "один ко многим" с заказами
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

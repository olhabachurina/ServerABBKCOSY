using ServerABBKCOSY.Models;

namespace ServerABBKCOSY
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }  // внешний ключ на Order
        public int ProductId { get; set; }  // внешний ключ на Product
        public int Quantity { get; set; }
        public decimal PricePerItem { get; set; }

        // Связь "один ко многим" с заказом
        public Order Order { get; set; }

        // Связь "один ко многим" с продуктом
        public Product Product { get; set; }
    }
}

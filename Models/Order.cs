using ServerABBKCOSY.Models;

namespace ServerABBKCOSY
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }  // внешний ключ на User
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime PlacedAt { get; set; }
        public int ShippingMethodId { get; set; }  
        public int PaymentMethodId { get; set; }   
        public bool IsPrepaid { get; set; }
        // Связь "один ко многим" с пользователем
        public User User { get; set; }
        // Внешний ключ на Currency
        public int CurrencyId { get; set; }  // Внешний ключ на Currency
        public Currency Currency { get; set; }  // Связь с сущностью Currency
        // Связи "один ко многим" с товарами в заказе
        public ICollection<OrderItem> OrderItems { get; set; }

        // Связь "один к одному" с доставкой и оплатой
        public OrderShipping OrderShipping { get; set; }
        public OrderPayment OrderPayment { get; set; }

        // Связь "один к одному" с купоном
        public OrderCoupon OrderCoupon { get; set; }
    }
}

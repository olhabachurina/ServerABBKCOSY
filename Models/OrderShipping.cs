namespace ServerABBKCOSY
{
    public class OrderShipping
    {
        public int OrderShippingId { get; set; }
        public int OrderId { get; set; }  // внешний ключ на Order
        public int ShippingMethodId { get; set; }  // внешний ключ на ShippingMethod
        public decimal ShippingCost { get; set; }
        public DateTime? ShippedAt { get; set; }

        // Связь "один к одному" с заказом
        public Order Order { get; set; }

        // Связь "один ко многим" с методами доставки
        public ShippingMethod ShippingMethod { get; set; }
    }
}

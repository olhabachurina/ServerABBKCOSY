namespace ServerABBKCOSY
{
    public class ShippingMethod
    {
        public int ShippingMethodId { get; set; }
        public string MethodName { get; set; }
        public decimal Cost { get; set; }

        // Связь "один ко многим" с OrderShipping
        public ICollection<OrderShipping> OrderShippings { get; set; }
    }
}

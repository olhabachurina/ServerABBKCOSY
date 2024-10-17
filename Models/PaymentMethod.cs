namespace ServerABBKCOSY
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public string MethodName { get; set; }  // Название метода оплаты (например, Credit Card, PayPal)

        // Связь "один ко многим" с OrderPayments
        public ICollection<OrderPayment> OrderPayments { get; set; }
    }
}

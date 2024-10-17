using ServerABBKCOSY.Models;
namespace ServerABBKCOSY
{
    public class OrderPayment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }  // внешний ключ на Order
        public int PaymentMethodId { get; set; }  // внешний ключ на PaymentMethod
        public decimal Amount { get; set; }
        public DateTime PaidAt { get; set; }

        // Связь "один к одному" с заказом
        public Order Order { get; set; }

        // Связь "один ко многим" с методами оплаты
        public PaymentMethod PaymentMethod { get; set; }
    }
}

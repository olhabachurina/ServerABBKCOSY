namespace ServerABBKCOSY.Models
{
    public class OrderCoupon
    {
        public int OrderCouponId { get; set; }
        public int OrderId { get; set; }  // внешний ключ на Order
        public int CouponId { get; set; }  // внешний ключ на Coupon
        public decimal AppliedDiscount { get; set; }// Применённая скидка в деньгах (рассчитана на основе DiscountPercent)
        // Связи с заказом и купоном
        // Связь "один к одному" с заказом
        public Order Order { get; set; }

        // Связь "один ко многим" с купонами
        public Coupon Coupon { get; set; }
    }
}

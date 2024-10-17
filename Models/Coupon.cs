using ServerABBKCOSY.Models;
namespace ServerABBKCOSY
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public string Code { get; set; }
        public decimal DiscountPercent { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public bool IsActive { get; set; }
        // Связь "один ко многим" с OrderCoupons
        public ICollection<OrderCoupon> OrderCoupons { get; set; }  // Связь с заказами через OrderCoupons
    }
}

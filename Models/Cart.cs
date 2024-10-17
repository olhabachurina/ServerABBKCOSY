

using System.ComponentModel.DataAnnotations;

namespace ServerABBKCOSY.Models
{
    public class Cart
    {
        public int CartId { get; set; }//уникальный идентификатор корзины.
        public int UserId { get; set; }  // идентификатор пользователя (если корзина принадлежит зарегистрированному пользователю).
        public DateTime CreatedAt { get; set; }//дата и время создания корзины
        [Timestamp]  // Используется для параллельного контроля изменений (concurrency)
        public byte[] RowVersion { get; set; }  // Поле для отслеживания изменений
        // Связь "один к одному" с пользователем
        public User User { get; set; }

        // Связь "один ко многим" с товарами в корзине
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        // Выбор способа доставки: true - доставка, false - самовывоз
        public bool IsDelivery { get; set; }

        // Адрес доставки (актуально только для доставки)
        public string City { get; set; }         // Город для доставки
        public string PostOfficeNumber { get; set; }  // Номер отделения почты

        // Способ оплаты: true - предоплата, false - оплата при получении
        public bool IsPrepaid { get; set; }
        // Скидка, применённая ко всей корзине
        public decimal Discount { get; set; }
        // Купон
        public int? CouponId { get; set; }  // ID применённого купона (если есть)
        public Coupon Coupon { get; set; }  // Связь с моделью Coupon
        // Сумма налога (ПДВ)
        public decimal TaxAmount { get; set; }
        // Итоговая сумма
        public decimal TotalPrice { get; set; }
        // Метод для пересчета итоговой суммы корзины (с учетом товаров, налога и скидки)
        public void RecalculateTotalPrice()
        {
            TotalPrice = CartItems.Sum(item => item.Quantity * item.Product.Price) + TaxAmount - Discount;
        }
    }
}

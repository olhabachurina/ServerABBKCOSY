namespace ServerABBKCOSY.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; } // Связь с пользователем
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        // Тип адреса (доставка, оплата, домашний и т.д.)
        public string AddressType { get; set; } // Например, "Shipping", "Billing"
        // Навигационное свойство
        public User User { get; set; }
    }
}

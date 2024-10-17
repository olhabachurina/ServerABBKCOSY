namespace ServerABBKCOSY
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime UpdatedAt { get; set; }
        // Связь "один ко многим" с заказами
        public ICollection<Order> Orders { get; set; }  // Это свойство отвечает за связь с заказами
    }
}

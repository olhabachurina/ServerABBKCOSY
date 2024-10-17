using ServerABBKCOSY.Models;

namespace ServerABBKCOSY
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }  // Внешний ключ на продукт
        public int UserId { get; set; }     // Внешний ключ на пользователя
        public int Rating { get; set; }     // Оценка (от 1 до 5)
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        // Связь с продуктом
        public Product Product { get; set; }

        // Связь с пользователем
        public User User { get; set; }
    }
}

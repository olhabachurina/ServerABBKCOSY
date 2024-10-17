using ServerABBKCOSY.Models;

namespace ServerABBKCOSY
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }   // Внешний ключ на продукт
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }     // Является ли главным изображением

        // Связь с продуктом
        public Product Product { get; set; }
    }
}

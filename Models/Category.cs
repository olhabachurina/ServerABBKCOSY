using ServerABBKCOSY.Models;

namespace ServerABBKCOSY
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; }  // внешний ключ на родительскую категорию

        // Связь "один ко многим" с продуктами
        public ICollection<Product> Products { get; set; }

        // Самоссылающаяся связь для подкатегорий
        public Category ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; }
    }
}

namespace ServerABBKCOSY.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }//уникальный идентификатор позиции в корзине
        public int CartId { get; set; }  // внешний ключ на Cart
        public int ProductId { get; set; }  // внешний ключ на Product
        public int Quantity { get; set; }//количество данного товара
        public bool IsDeleted { get; set; }  // Мягкое удаление
        public DateTime AddedAt { get; set; }//дата добавления товара в корзину

        // Связь "один ко многим" с корзиной
        public Cart Cart { get; set; }

        // Связь "один ко многим" с продуктом
        public Product Product { get; set; }
    }
}

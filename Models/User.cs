

using ServerABBKCOSY.Models;

namespace  ServerABBKCOSY
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }

        // Связь "один ко многим" с заказами
        public ICollection<Order> Orders { get; set; }

        // Связь "один к одному" с корзиной
        public Cart Cart { get; set; }
        // Связь с адресами (например, если пользователь может иметь несколько адресов)
        public ICollection<Address> Addresses { get; set; }
    }
}

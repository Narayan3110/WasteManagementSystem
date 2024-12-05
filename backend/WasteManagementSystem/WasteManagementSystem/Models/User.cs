using System.ComponentModel.DataAnnotations;

namespace WasteManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
    }
}



namespace LibraryManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public int NIC { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}


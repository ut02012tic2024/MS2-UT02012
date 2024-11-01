namespace LibraryManagementSystem.DTOs
{
    public class RegisterRequest
    {
        public int NIC { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

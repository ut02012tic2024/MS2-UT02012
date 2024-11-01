using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User Authenticate(int nic, string password)
        {
            return _userRepository.GetAll().SingleOrDefault(u => u.NIC == nic && u.Password == password);
        }

        public void Register(RegisterRequest request)
        {
            var user = new User { NIC = request.NIC, Name = request.Name, Password = request.Password, Role = request.Role };
            _userRepository.Add(user);
        }
    }
}

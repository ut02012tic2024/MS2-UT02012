using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface IUserService
    {
        User Authenticate(int nic, string password);
        void Register(RegisterRequest request);
    }
}

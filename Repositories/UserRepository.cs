using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly List<User> _users = new();

        public IEnumerable<User> GetAll() => _users;

        public User GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public void Add(User user)
        {
            user.Id = _users.Count > 0 ? _users.Max(u => u.Id) + 1 : 1;
            _users.Add(user);
        }

        public void Delete(int id) => _users.RemoveAll(u => u.Id == id);
    }
}

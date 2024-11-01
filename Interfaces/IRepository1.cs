using System.Collections.Generic;

namespace LibraryManagementSystem.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(int id);
    }
}

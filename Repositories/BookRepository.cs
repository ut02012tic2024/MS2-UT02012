using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private readonly List<Book> _books = new();

        public IEnumerable<Book> GetAll() => _books;

        public Book GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public void Add(Book book)
        {
            book.Id = _books.Count > 0 ? _books.Max(b => b.Id) + 1 : 1;
            _books.Add(book);
        }

        public void Delete(int id) => _books.RemoveAll(b => b.Id == id);
    }
}

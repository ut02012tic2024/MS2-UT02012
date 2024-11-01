using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Repositories
{
    public class BorrowedBookRepository : IRepository<BorrowedBook>
    {
        private readonly List<BorrowedBook> _borrowedBooks = new();

        public IEnumerable<BorrowedBook> GetAll() => _borrowedBooks;

        public BorrowedBook GetById(int id) => _borrowedBooks.FirstOrDefault(b => b.Id == id);

        public void Add(BorrowedBook borrowedBook)
        {
            borrowedBook.Id = _borrowedBooks.Count > 0 ? _borrowedBooks.Max(b => b.Id) + 1 : 1;
            _borrowedBooks.Add(borrowedBook);
        }

        public void Delete(int id) => _borrowedBooks.RemoveAll(b => b.Id == id);
    }
}

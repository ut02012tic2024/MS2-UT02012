using LibraryManagementSystem.DTOs;
using System.Collections.Generic;

namespace LibraryManagementSystem.Interfaces
{
    public interface IBookService
    {
        IEnumerable<BookDTO> GetAllBooks();
        BookDTO GetBook(int id);
        void AddBook(BookDTO book);
        void DeleteBook(int id);
    }
}

using LibraryManagementSystem.DTOs;
using System.Collections.Generic;

namespace LibraryManagementSystem.Interfaces
{
    public interface IBorrowedService
    {
        IEnumerable<BorrowedBookDTO> GetAllBorrowedBooks();
        void BorrowBook(BorrowedBookDTO borrowedBook);
        void ReturnBook(int id);
    }
}

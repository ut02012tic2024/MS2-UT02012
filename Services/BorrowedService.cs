using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class BorrowedService : IBorrowedService
    {
        private readonly IRepository<BorrowedBook> _borrowedBookRepository;

        public BorrowedService(IRepository<BorrowedBook> borrowedBookRepository)
        {
            _borrowedBookRepository = borrowedBookRepository;
        }

        public IEnumerable<BorrowedBookDTO> GetAllBorrowedBooks()
        {
            return _borrowedBookRepository.GetAll().Select(b => new BorrowedBookDTO
            {
                Id = b.Id,
                BookId = b.BookId,
                BorrowDate = b.BorrowDate
            });
        }

        public void BorrowBook(BorrowedBookDTO borrowedBookDTO)
        {
            var borrowedBook = new BorrowedBook { BookId = borrowedBookDTO.BookId, BorrowDate = borrowedBookDTO.BorrowDate };
            _borrowedBookRepository.Add(borrowedBook);
        }

        public void ReturnBook(int id) => _borrowedBookRepository.Delete(id);
    }
}

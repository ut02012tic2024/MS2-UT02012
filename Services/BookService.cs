using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<BookDTO> GetAllBooks()
        {
            return _bookRepository.GetAll().Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                Category = b.Category,
                Count = b.Count,
                Url = b.Url
            });
        }

        public BookDTO GetBook(int id)
        {
            var book = _bookRepository.GetById(id);
            return book != null ? new BookDTO { Id = book.Id, Title = book.Title, Category = book.Category, Count = book.Count, Url = book.Url } : null;
        }

        public void AddBook(BookDTO bookDTO)
        {
            var book = new Book { Title = bookDTO.Title, Category = bookDTO.Category, Count = bookDTO.Count, Url = bookDTO.Url };
            _bookRepository.Add(book);
        }

        public void DeleteBook(int id) => _bookRepository.Delete(id);
    }
}

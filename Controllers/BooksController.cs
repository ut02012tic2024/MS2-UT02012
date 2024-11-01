using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookService.GetAllBooks());
        }

        [HttpPost]
        public IActionResult AddBook(BookDTO bookDTO)
        {
            _bookService.AddBook(bookDTO);
            return Ok("Book added successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return Ok("Book deleted successfully");
        }
    }
}

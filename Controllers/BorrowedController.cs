using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowedController : ControllerBase
    {
        private readonly IBorrowedService _borrowedService;

        public BorrowedController(IBorrowedService borrowedService)
        {
            _borrowedService = borrowedService;
        }

        [HttpGet]
        public IActionResult GetAllBorrowedBooks()
        {
            return Ok(_borrowedService.GetAllBorrowedBooks());
        }

        [HttpPost]
        public IActionResult BorrowBook(BorrowedBookDTO borrowedBookDTO)
        {
            _borrowedService.BorrowBook(borrowedBookDTO);
            return Ok("Book borrowed successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult ReturnBook(int id)
        {
            _borrowedService.ReturnBook(id);
            return Ok("Book returned successfully");
        }
    }
}

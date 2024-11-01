
namespace LibraryManagementSystem.Models
{
    public class BorrowedBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
    }
}

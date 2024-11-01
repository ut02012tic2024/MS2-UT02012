namespace LibraryManagementSystem.DTOs
{
    public class BorrowedBookDTO
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
    }
}

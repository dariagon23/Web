namespace Bookshelf.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookAuthor { get; set; }
        public string? BookDescription{ get; set; }
        public int PagesNum { get; set; }
    }
}

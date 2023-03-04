using Microsoft.EntityFrameworkCore;
namespace Bookshelf.Models
{
    public class BookContext:DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // create database first time request
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace day_08.Models
{
    public class BookDbcontext : DbContext
    {
        public BookDbcontext(DbContextOptions<BookDbcontext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<OrderBook> OrderBooks { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}

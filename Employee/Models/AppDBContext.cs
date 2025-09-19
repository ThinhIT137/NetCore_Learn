using Microsoft.EntityFrameworkCore;

namespace Employee.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Employees> Employees { get; set; }
    }
}

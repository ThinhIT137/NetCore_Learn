using Microsoft.EntityFrameworkCore;

namespace TDT_Day09_CodeFirst.Models
{
    public class tdtDay09AppContext : DbContext
    {
        public tdtDay09AppContext(DbContextOptions<tdtDay09AppContext> options) : base(options) { }

        public DbSet<tdtLoai_San_Pham> tdtLoai_San_Pham { get; set; }
        public DbSet<tdtSan_Pham> tdtSan_Pham { get; set; }
    }
}

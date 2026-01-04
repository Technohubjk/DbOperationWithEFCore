using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCoreApp.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<test> tests { get; set; }
    }
}

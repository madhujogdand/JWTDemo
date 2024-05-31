using JWTDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }

    }

    
}

using Microsoft.EntityFrameworkCore;
using VueApp1.Server.Classes;

namespace VueApp1.Server
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

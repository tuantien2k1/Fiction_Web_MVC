using FictionWebRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace FictionWebRazor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Name = "Susan01", DisplayOrder = 1 },
                new Category { ID = 2, Name = "Susan017", DisplayOrder = 2 },
                new Category { ID = 3, Name = "Susan0175", DisplayOrder = 3 }
                );
        }
    }
}

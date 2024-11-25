using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Data
{
    public class ApplicationDBContext : DbContext
    {
        // Constructor to pass DbContextOptions to the base class
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        // DbSets representing the tables in the database
        public DbSet<Stock> Stocks { get; set; }  // Plural name by convention
        public DbSet<Comment> Comments { get; set; }  // Plural name by convention

        // Override OnModelCreating for additional configuration (e.g., primary keys, relationships)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define primary key for Comment entity if not already defined in the model
            modelBuilder.Entity<Comment>().HasKey(c => c.StockId);  // Ensure primary key is defined

            // Optional: Configure relationships if needed (e.g., one-to-many between Stock and Comment)
            modelBuilder.Entity<Stock>()
                .HasMany(s => s.Comments)
                .WithOne(c => c.Stock)
                .HasForeignKey(c => c.StockId);
        }
    }
}

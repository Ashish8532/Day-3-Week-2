using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }


        // One to Many mapping 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 3, Name = "Electronics", Description = "Electronic categories." },
                    new Category { Id = 4, Name = "Clothing", Description = "Clothing categories." },
                    new Category { Id = 5, Name = "Fruits", Description = "Fruits categories." },
                    new Category { Id = 6, Name = "Vegitables", Description = "Vegitables categories." }
                );

            modelBuilder.Entity<Product>().HasData(
                     new Product { Id = 1, Name = "Smartphone", Price = 499.99M, Description = "Electric equipment", CategoryId = 3 },
                     new Product { Id = 2, Name = "Laptop", Price = 899.99M, Description = "Electric equipment", CategoryId = 3 },
                     new Product { Id = 3, Name = "T-Shirt", Price = 19.99M, Description = "Clothing Products", CategoryId = 4 },
                     new Product { Id = 4, Name = "Jeans", Price = 39.99M, Description = "Clothing Products", CategoryId = 4 }
                 );
        }
    }
}

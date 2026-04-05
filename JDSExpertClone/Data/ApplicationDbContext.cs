using Microsoft.EntityFrameworkCore;
using JDSExpertClone.Models;

namespace JDSExpertClone.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "JDS Coffee" },
                new Category { Id = 2, Name = "Fresh Juice" },
                new Category { Id = 3, Name = "Cookies" }
            );

            
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "JDS Espresso", Price = 180, CategoryId = 1, ImageUrl = "https://images.unsplash.com/photo-1510591509098-f4fdc6d0ff04?w=400", Description = "Strong and Bold Coffee" },
                new Product { Id = 2, Name = "Caramel Latte", Price = 250, CategoryId = 1, ImageUrl = "https://images.unsplash.com/photo-1485808191679-5f86510681a2?w=400", Description = "Sweet Caramel Bliss" },
                new Product { Id = 3, Name = "Iced Americano", Price = 200, CategoryId = 1, ImageUrl = "https://images.unsplash.com/photo-1517701604599-bb29b565090c?w=400", Description = "Freshly Brewed Ice Coffee" },
                new Product { Id = 4, Name = "Mango Blast", Price = 120, CategoryId = 2, ImageUrl = "https://images.unsplash.com/photo-1546173159-315724a31696?w=400", Description = "Organic Fresh Mango" },
                new Product { Id = 5, Name = "Watermelon Cooler", Price = 100, CategoryId = 2, ImageUrl = "https://images.unsplash.com/photo-1543158181-e6f9f697ce4b?w=400", Description = "Natural Watermelon Squeeze" },
                new Product { Id = 6, Name = "Orange Squeeze", Price = 150, CategoryId = 2, ImageUrl = "https://images.unsplash.com/photo-1624517452488-04869289c4ca?w=400", Description = "High Vitamin C Orange" },
                new Product { Id = 7, Name = "Choco Chip Cookie", Price = 60, CategoryId = 3, ImageUrl = "https://images.unsplash.com/photo-1499636136210-6f4ee915583e?w=400", Description = "Extra Chocolate Chips" },
                new Product { Id = 8, Name = "Almond Crunch", Price = 80, CategoryId = 3, ImageUrl = "https://images.unsplash.com/photo-1558961363-fa8fdf82db35?w=400", Description = "Crunchy Almonds Butter" },
                new Product { Id = 9, Name = "Oatmeal Raisin", Price = 55, CategoryId = 3, ImageUrl = "https://images.unsplash.com/photo-1590080875515-8a03b1447d1a?w=400", Description = "Healthy Soft Oats" }
            );
        }
    }
}
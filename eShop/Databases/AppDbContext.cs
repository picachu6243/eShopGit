using eShop.Databases.Configs;
using eShop.Databases.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.Databases
{
    public class AppDbContext:DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}

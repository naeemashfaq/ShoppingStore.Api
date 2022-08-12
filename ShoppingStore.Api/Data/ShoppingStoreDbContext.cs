using Microsoft.EntityFrameworkCore;
using ShoppingStore.Api.Entities;

namespace ShoppingStore.Api.Data
{
    public class ShoppingStoreDbContext:DbContext
    {
        public ShoppingStoreDbContext(DbContextOptions<ShoppingStoreDbContext> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
       
    }
}

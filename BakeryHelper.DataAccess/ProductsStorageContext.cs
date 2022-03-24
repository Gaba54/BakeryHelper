using BakeryHelper.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakeryHelper.DataAccess
{
    public class ProductsStorageContext : DbContext
    {
        public ProductsStorageContext(DbContextOptions<ProductsStorageContext> opt) : base(opt) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
using BakeryHelper.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakeryHelper.DataAccess
{
    public class ProductsStorageContext :DbContext
    {
        public ProductsStorageContext(DbContextOptions<ProductsStorageContext> opt) : base(opt) { }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
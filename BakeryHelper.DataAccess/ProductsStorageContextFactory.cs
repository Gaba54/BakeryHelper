using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace BakeryHelper.DataAccess
{
    public class ProductsStorageContextFactory : IDesignTimeDbContextFactory<ProductsStorageContext>
    {
        public ProductsStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductsStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=Localhost\\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True");
            return new ProductsStorageContext(optionsBuilder.Options);
        }
    }
}

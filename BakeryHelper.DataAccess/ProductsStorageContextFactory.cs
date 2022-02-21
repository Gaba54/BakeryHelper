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
            var currentDirectory = Directory.GetCurrentDirectory();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(currentDirectory)
                .AddJsonFile($"{currentDirectory}/../BakeryHelper/appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<ProductsStorageContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ProductsConnectionString"));
            return new ProductsStorageContext(optionsBuilder.Options);
        }
    }
}

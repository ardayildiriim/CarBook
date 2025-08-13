using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence
{
    public class CarBookContextFactory : IDesignTimeDbContextFactory<CarBookContext>
    {
        public CarBookContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CarBookContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlite(connectionString);

            return new CarBookContext(optionsBuilder.Options);
        }
    }
}

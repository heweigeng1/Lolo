using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Lolo.EntityFrameworkCore
{
    public class LoloHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<LoloHttpApiHostMigrationsDbContext>
    {
        public LoloHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LoloHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Lolo"));

            return new LoloHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DataAccess
{
    /// <summary>
    /// Database factory for BuJoContext
    /// </summary>
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BuJoContext>
    {
        /// <summary>
        /// Creates the database context based on the given argument(s).
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public BuJoContext CreateDbContext(string[] args)
        {
            string pathToAppSettings = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\CaYoMi-BuJo"));

            IConfigurationRoot configuration = new ConfigurationBuilder()
                                                    .SetBasePath(pathToAppSettings)
                                                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                                    .Build();

            DbContextOptionsBuilder<BuJoContext> builder = new DbContextOptionsBuilder<BuJoContext>();

            string connectionString = configuration.GetConnectionString("CaYoMiBuJoDatabase");

            builder.UseSqlite(connectionString);

            return new BuJoContext(builder.Options);
        }
    }
}

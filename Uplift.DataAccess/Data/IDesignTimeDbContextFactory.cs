using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;
using Microsoft.Extensions.Configuration;

using Uplift.DataAccess.Data;

public class MyDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {      

        ApplicationDbContext IDesignTimeDbContextFactory<ApplicationDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var ConnectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(ConnectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }
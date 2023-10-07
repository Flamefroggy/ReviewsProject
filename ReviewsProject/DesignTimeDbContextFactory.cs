using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewsData;

namespace ReviewsProject
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ReviewsDbContext>
    {
        public ReviewsDbContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = configurationBuilder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<ReviewsDbContext>();
            optionsBuilder.UseNpgsql(configuration["ConnectionStrings:Npgsql"]);

            return new ReviewsDbContext(optionsBuilder.Options);
        }
    }
}

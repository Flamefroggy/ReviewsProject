using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReviewsData;
using ReviewsData.Service.Games;

namespace ReviewsProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConfigureServices();
            Application.Run(new MainForm());
        }
        public static IServiceProvider ServiceProvider { get; private set; }

        static void ConfigureServices()
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = configurationBuilder.Build();

            var services = new ServiceCollection();

            services.AddSingleton(configuration);
            services.AddScoped<IGamesManager, GamesManager>();

            var optionsBuilder = new DbContextOptionsBuilder<ReviewsDbContext>();
            optionsBuilder.UseNpgsql(configuration["ConnectionStrings:Npgsql"]);
            optionsBuilder.EnableSensitiveDataLogging();

            services.AddDbContextFactory<ReviewsDbContext>(options =>
                options
                    .UseNpgsql(configuration["ConnectionStrings:Npgsql"])
                    .EnableSensitiveDataLogging()
                );
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
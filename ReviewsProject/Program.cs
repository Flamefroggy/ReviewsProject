using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReviewsData;
using ReviewsData.Service.Games;

namespace ReviewsProject;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        ConfigureServices();
        Application.Run(ServiceProvider.GetService<MainForm>());
    }
    public static IServiceProvider ServiceProvider { get; private set; }

    static void ConfigureServices()
    {
        var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        IConfiguration configuration = configurationBuilder.Build();

        var services = new ServiceCollection();

        services.AddSingleton(configuration);
        services.AddSingleton<MainForm>();
        services.AddSingleton<IGamesManager, GamesManager>();

        var optionsBuilder = new DbContextOptionsBuilder<ReviewsDbContext>();
        optionsBuilder.UseNpgsql(configuration["ConnectionStrings:PostgreSQL"]);
        optionsBuilder.EnableSensitiveDataLogging();

        services.AddDbContextFactory<ReviewsDbContext>(options =>
            options
                .UseNpgsql(configuration["ConnectionStrings:PostgreSQL"])
                .EnableSensitiveDataLogging()
            );
        ServiceProvider = services.BuildServiceProvider();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        Console.WriteLine("Doing Entity Framework migrations stuff, not starting full application");
        return Host.CreateDefaultBuilder();
    }
}
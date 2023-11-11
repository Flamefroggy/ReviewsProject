using Microsoft.EntityFrameworkCore;
using ReviewsData.Model;

namespace ReviewsData
{
    public class ReviewsDbContext : DbContext
    {
        public ReviewsDbContext(DbContextOptions<ReviewsDbContext> options) : base(options)
        {
            try
            {
                //Database.OpenConnection();
                //Database.CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось подключиться к базе данных.", ex.InnerException);
            }
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Game>()
                .HasKey(g => g.Id);
            builder.Entity<Game>()
                .HasData(new Game[]
            {
                new Game { Id = 1, Name = "Дота 2", Description = "Клац клац", Rating = 8 },
                new Game { Id = 2, Name = "Танки", Description = "Есть пробитие", Rating = 5 },
                new Game { Id = 3, Name = "КС", Description = "AWP", Rating = 6 }
            });

            base.OnModelCreating(builder);
        }
    }
}

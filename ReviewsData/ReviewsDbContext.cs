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
                Database.CanConnect();
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось подключиться к базе данных.", ex.InnerException);
            }
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>()
                .HasKey(b => b.Id);
            builder.Entity<Book>()
                .HasData(new Book[]
            {
                new Book { Id = 1, Title = "Мойдодыр", Description = "хохол", NPages = 40 },
                new Book { Id = 2, Title = "Азбука", Description = "АБВГД", NPages = 35 },
                new Book { Id = 3, Title = "Дихотомия добра и зла", Description = "rip", NPages = 565 }
            });

            builder.Entity<Game>()
                .HasKey(g => g.Id);
            builder.Entity<Game>()
                .HasData(new Game[]
            {
                new Game { Id = 1, Title = "Дота 2", Description = "Клац клац" },
                new Game { Id = 2, Title = "Танки", Description = "Есть пробитие" },
                new Game { Id = 3, Title = "КС", Description = "AWP" }
            });

            builder.Entity<Film>()
                .HasKey(f => f.Id);
            builder.Entity<Film>()
                .HasData(new Film[]
                {
                    new Film { Id = 1, Title = "Побег из Шоушенка", Description = "Dufresne" },
                    new Film { Id = 2, Title = "Untouchebles", Description = "1+1"},
                    new Film { Id = 3, Title = "Форрест Гамп", Description = "ты задержан или просто глупый?"}
                });

            base.OnModelCreating(builder);
        }
    }
}

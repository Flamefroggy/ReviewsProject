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
                if (Database.GetPendingMigrations().Any())
                {
                    Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось подключиться к базе данных.", ex.InnerException);
            }
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    builder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=12345678;Database=ReviewsProject;Include Error Detail=true");
        //}

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
                new Book { Id = 1, Title = "Мойдодыр", Description = "хохол", NPages = 40, Rating = 7 },
                new Book { Id = 2, Title = "Азбука", Description = "АБВГД", NPages = 35, Rating = 5 },
                new Book { Id = 3, Title = "Дихотомия добра и зла", Description = "Аннотация – краткое описание книги, которое дает читателю представление о произведении, рассказывает завязку сюжета или обозначает общую тему книги. Обычно аннотация публикуется на обороте книги.", NPages = 565, Rating = 2 }
            });

            builder.Entity<Game>()
                .HasKey(g => g.Id);
            builder.Entity<Game>()
                .HasData(new Game[]
            {
                new Game { Id = 1, Title = "Дота 2", Description = "Клац клац", Rating = 8 },
                new Game { Id = 2, Title = "Танки", Description = "Есть пробитие", Rating = 5 },
                new Game { Id = 3, Title = "КС", Description = "AWP", Rating = 6 }
            });

            builder.Entity<Film>()
                .HasKey(f => f.Id);
            builder.Entity<Film>()
                .HasData(new Film[]
                {
                    new Film { Id = 1, Title = "Побег из Шоушенка", Description = "Dufresne", Rating = 9.5 },
                    new Film { Id = 2, Title = "Untouchebles", Description = "1+1", Rating = 9.1},
                    new Film { Id = 3, Title = "Форрест Гамп", Description = "ты задержан или просто глупый?", Rating = 9.4}
                });

            base.OnModelCreating(builder);
        }
    }
}

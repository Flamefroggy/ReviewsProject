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
            builder.Entity<Book>().HasKey(b => b.Id);
            builder.Entity<Book>().HasData(new Book[]
            {
                new Book { Id = 1, Title = "Мойдодыр", Description = "хохол" },
                new Book { Id = 2, Title = "Азбука", Description = "АБВГД" },
                new Book { Id = 3, Title = "Дихотомия добра и зла", Description = "rip" }
            });

            builder.Entity<Film>()
                .HasKey(f => f.Id);
            builder.Entity<Game>()
                .HasKey(g => g.Id);
            builder.Entity<Game>().HasData(new Game[]
            {
                new Game { Id = 1, Title = "Мойдодыр", Description = "хохол" },
                new Game { Id = 2, Title = "Азбука", Description = "АБВГД" },
                new Game { Id = 3, Title = "Дихотомия добра и зла", Description = "rip" }
            });

            base.OnModelCreating(builder);
        }
    }
}

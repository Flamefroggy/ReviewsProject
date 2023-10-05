using ReviewsData.Model;
using ReviewsProject.View;

namespace ReviewsProject
{
    public partial class MainForm : Form
    {
        List<Game> Games = new List<Game>();
        List<Book> Books = new List<Book>();
        List<Film> Films = new List<Film>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var game1 = new Game
            {
                Id = 1,
                Title = "Танки онлайн",
                Description = "3123"
            };
            var game2 = new Game
            {
                Id = 2,
                Title = "Дота 2",
                Description = "22"
            };
            var game3 = new Game
            {
                Id = 3,
                Title = "КС",
                Description = "11"
            };
            Games.Add(game1);
            Games.Add(game2);
            Games.Add(game3);

            var book1 = new Book
            {
                Id = 1,
                Title = "Мойдодыр",
                Description = "хохол"
            };
            var book2 = new Book
            {
                Id = 2,
                Title = "Азбука",
                Description = "АБВГД"
            };
            var book3 = new Book
            {
                Id = 3,
                Title = "Дихотомия добра и зла",
                Description = "rip"
            };

            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);

            var film1 = new Film
            {
                Id = 1,
                Title = "Форрест Гамп",
                Description = "плак"
            };
            var film2 = new Film
            {
                Id = 2,
                Title = "Терминатор",
                Description = "Та-Дан Тан Та-Дан"
            };
            var film3 = new Film
            {
                Id = 3,
                Title = "Snatch",
                Description = "спиздили"
            };

            Films.Add(film1);
            Films.Add(film2);
            Films.Add(film3);

            BooksBS.DataSource = Books;
            GamesBS.DataSource = Games;
            FilmsBS.DataSource = Films;

            comboBoxTableType.SelectedIndex = 0;
        }

        private void menuItemCreateGame_Click(object sender, EventArgs e)
        {
            var createForm = new CreateGame();
            createForm.GameCreated += addGame;
            createForm.ShowDialog();
        }
        private void menuItemCreateBook_Click(object sender, EventArgs e)
        {
            var createForm = new CreateBook();
            createForm.BookCreated += addBook;
            createForm.ShowDialog();
        }

        private void menuItemCreateFilm_Click(object sender, EventArgs e)
        {
            var createForm = new CreateFilm();
            createForm.FilmCreated += addFilm;
            createForm.ShowDialog();
        }

        private void addGame(Game game)
        {
            Games.Add(game);
            GamesBS.ResetBindings(false);
        }

        private void addBook(Book book)
        {
            Books.Add(book);
            BooksBS.ResetBindings(false);
        }
        private void addFilm(Film film)
        {
            Films.Add(film);
            FilmsBS.ResetBindings(false);
        }

        private void comboBoxTableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTableType.SelectedIndex)
            {
                case 0:
                    dgvMain.DataSource = GamesBS;
                    break;
                case 1:
                    dgvMain.DataSource = BooksBS;
                    break;
                case 2:
                    dgvMain.DataSource = FilmsBS;
                    break;
            }
        }

    }

}
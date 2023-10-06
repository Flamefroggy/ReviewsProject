using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReviewsData;
using ReviewsData.Model;
using ReviewsData.Service.Games;
using ReviewsProject.View;

namespace ReviewsProject
{
    public partial class MainForm : Form
    {
        private IGamesManager _gamesManager;
        private IBooksManager _booksManager;
        private IFilmsManager _filmsManager;
        List<Game> Games = new List<Game>();
        List<Book> Books = new List<Book>();
        List<Film> Films = new List<Film>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                _gamesManager = Program.ServiceProvider.GetService<IGamesManager>();
                _booksManager = Program.ServiceProvider.GetService<IBooksManager>();
                _filmsManager = Program.ServiceProvider.GetService<IFilmsManager>();
            }

            Games = _gamesManager.Get();
            Books = _booksManager.Get();
            Films = _filmsManager.Get();

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
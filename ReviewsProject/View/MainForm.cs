using ReviewsData.Model;
using ReviewsProject.View;

namespace ReviewsProject
{
    public partial class MainForm : Form
    {
        List<Game> Games = new List<Game>();
        List<Book> Books = new List<Book>();

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

            BooksBS.DataSource = Books;
            GamesBS.DataSource = Games;
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
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
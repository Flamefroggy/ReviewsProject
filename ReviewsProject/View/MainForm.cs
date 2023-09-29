using ReviewsData.Model;
using ReviewsProject.View;

namespace ReviewsProject
{
    public partial class MainForm : Form
    {
        List<Game> Games = new List<Game>();

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
            GamesBS.DataSource = Games;
            comboBoxTableType.SelectedIndex = 0;
        }

        private void menuItemCreateGame_Click(object sender, EventArgs e)
        {
            var createForm = new CreateGame();
            createForm.GameCreated += addGame;
            createForm.ShowDialog();
        }

        private void addGame(Game game)
        {
            Games.Add(game);
            GamesBS.ResetBindings(false);
        }

        private void comboBoxTableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTableType.SelectedIndex)
            {
                case 0:
                    dgvMain.DataSource = GamesBS; 
                    break;
            }
        }
    }
}
using ReviewsData.Model;

namespace ReviewsProject.View
{
    public partial class CreateGame : Form
    {
        public Game Game { get; set; } = new Game();
        public delegate void CreateGameEventHandler(Game game);
        public event CreateGameEventHandler GameCreated;
        public CreateGame()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Game.Title = tbTitle.Text;
            Game.Description = tbDescription.Text;
            GameCreated?.Invoke(Game);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

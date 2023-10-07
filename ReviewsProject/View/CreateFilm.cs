using ReviewsData.Model;

namespace ReviewsProject.View
{
    public partial class CreateFilm : Form
    {
        public Film Film { get; set; } = new Film();
        public delegate void CreateFilmEventHandler(Film film);
        public event CreateFilmEventHandler FilmCreated;
        public CreateFilm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateFilm_Click(object sender, EventArgs e)
        {
            Film.Title = tbTitle.Text;
            Film.Description = tbDescription.Text;
            Film.Rating = 0;
            FilmCreated?.Invoke(Film);
            this.Close();
        }
    }
}

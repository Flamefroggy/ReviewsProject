using ReviewsData.Model;

namespace ReviewsProject.View
{
    public partial class CreateBook : Form
    {
        public Book Book { get; set; } = new Book();
        public delegate void CreateBookEventHandler(Book book);
        public event CreateBookEventHandler BookCreated;
        public CreateBook()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Book.Title = tbTitle.Text;
            Book.Description = tbDescription.Text;
            BookCreated?.Invoke(Book);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

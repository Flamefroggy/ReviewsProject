using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReviewsData;
using ReviewsData.Model;
using ReviewsData.Service.Games;
using ReviewsProject.Utils;
using ReviewsProject.View;
using ReviewsProject.View.ButtonControls;
using System.ComponentModel;

namespace ReviewsProject
{
    public partial class MainForm : Form
    {
        private IGamesManager _gamesManager;
        private IBooksManager _booksManager;
        private IFilmsManager _filmsManager;

        private MainButtons mainButtons = new MainButtons();
        private DataInteractionButtons dataInteractionButtons = new DataInteractionButtons();
        private InfoView infoView = new InfoView();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                _gamesManager = Program.ServiceProvider.GetService<IGamesManager>();
                _booksManager = Program.ServiceProvider.GetService<IBooksManager>();
                _filmsManager = Program.ServiceProvider.GetService<IFilmsManager>();
            }

            comboBoxTableType.SelectedIndex = 0;
            dgvMain.ClearSelection();
            layoutMain.Controls.Add(mainButtons, 1, 0);
            mainButtons.Dock = dataInteractionButtons.Dock = DockStyle.Fill;
            mainButtons.OnSwitch += SwitchButtons;
            dataInteractionButtons.OnSwitch += SwitchButtons;

        }

        private EntityMode m_EntityMode;
        public EntityMode Mode
        {
            get
            {
                return m_EntityMode;
            }
            set
            {
                m_EntityMode = value;
                refreshTable(value);
            }
        }

        public BindingList<BaseEntity> Entities
        {
            get
            {
                if (null != EntitiesBS.DataSource)
                {
                    return EntitiesBS.DataSource as BindingList<BaseEntity>;
                }
                return null;
            }
            set
            {
                EntitiesBS.DataSource = value;
            }
        }

        private void refreshTable(EntityMode mode)
        {
            switch (mode)
            {
                case EntityMode.Games:
                    Entities = new BindingList<BaseEntity>(_gamesManager.Get().Cast<BaseEntity>().ToList());
                    break;
                case EntityMode.Books:
                    Entities = new BindingList<BaseEntity>(_booksManager.Get().Cast<BaseEntity>().ToList());
                    break;
                case EntityMode.Films:
                    Entities = new BindingList<BaseEntity>(_filmsManager.Get().Cast<BaseEntity>().ToList());
                    break;
            }
        }

        public void SwitchButtons()
        {
            if (layoutMain.Controls.Contains(mainButtons))
            {
                layoutMain.Controls.Remove(mainButtons);
                layoutMain.Controls.Add(dataInteractionButtons);
            }
            else
            {
                layoutMain.Controls.Remove(dataInteractionButtons);
                layoutMain.Controls.Add(mainButtons);
            }
        }

        private void comboBoxTableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityMode mode;
            switch (comboBoxTableType.SelectedIndex)
            {
                case 0:
                    Mode = EntityMode.Games;
                    break;
                case 1:
                    Mode = EntityMode.Books;
                    break;
                case 2:
                    Mode = EntityMode.Films;
                    break;
            }
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            layoutMain.Controls.Add(infoView, 1, 1);
            mainButtons.SetEnabledButtons(true);
        }
    }

}
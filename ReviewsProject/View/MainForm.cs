using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReviewsData;
using ReviewsData.Model;
using ReviewsData.Service;
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
        private IEntityManager m_Manager;

        private MainButtonsPanel m_MainButtonsPanel = new();
        private EditButtonsPanel m_EditButtonsPanel = new();
        private EntityView m_EntityView = new();

        public MainForm(IGamesManager gamesManager, IBooksManager booksManager, IFilmsManager filmsManager)
        {
            InitializeComponent();
            _gamesManager = gamesManager;
            _booksManager = booksManager;
            _filmsManager = filmsManager;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxTableType.SelectedIndex = 0;
            dgvMain.ClearSelection();
            layoutMain.Controls.Add(m_MainButtonsPanel, 1, 0);
            m_MainButtonsPanel.Dock = m_EditButtonsPanel.Dock = DockStyle.Fill;
            m_MainButtonsPanel.OnCreate += switchButtons;
            m_EditButtonsPanel.OnSwitch += switchButtons;

            Mode = EntityMode.Games;
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
                m_Manager = value switch
                {
                    EntityMode.Games => _gamesManager,
                    EntityMode.Books => _booksManager,
                    EntityMode.Films => _filmsManager,
                    _ => throw new NotImplementedException()
                };
                refreshTable();
            }
        }

        private BindingList<BaseEntity> m_Entities
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

        private void refreshTable()
        {
            m_Entities = new BindingList<BaseEntity>(m_Manager.Get());
        }

        private void switchButtons()
        {
            if (layoutMain.Controls.Contains(m_MainButtonsPanel))
            {
                layoutMain.Controls.Remove(m_MainButtonsPanel);
                layoutMain.Controls.Add(m_EditButtonsPanel);
            }
            else
            {
                layoutMain.Controls.Remove(m_EditButtonsPanel);
                layoutMain.Controls.Add(m_MainButtonsPanel);
            }
        }

        private void comboBoxTableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = comboBoxTableType.SelectedIndex switch
            {
                0 => EntityMode.Games,
                1 => EntityMode.Books,
                2 => EntityMode.Films,
                _ => throw new NotImplementedException(),
            };
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            layoutMain.Controls.Add(m_EntityView, 1, 1);
            m_MainButtonsPanel.SetEnabledButtons(true);
        }

        #region MainButtons handlers

        private void onCreateClick()
        {

        }

        private void onEditClick()
        {

        }

        private void onDeleteClick()
        {

        }

        #endregion

        #region EditButtons handlers

        private void onSaveClick()
        {

        }

        private void onResetClick()
        {

        }

        private void onCancelClick()
        {

        }

        #endregion
    }

}
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
        private readonly IGamesManager _gamesManager;
        private readonly IBooksManager _booksManager;
        private readonly IFilmsManager _filmsManager;
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
            dgvEntities.ClearSelection();
            layoutMain.Controls.Add(m_MainButtonsPanel, 1, 0);
            m_EntityView.Dock =  m_MainButtonsPanel.Dock = m_EditButtonsPanel.Dock = DockStyle.Fill;
            #region event binding

            m_MainButtonsPanel.OnCreate += onCreateClick;
            m_MainButtonsPanel.OnEdit += onEditClick;
            m_MainButtonsPanel.OnDelete += onDeleteClick;
            m_EditButtonsPanel.OnSave += onSaveClick;
            m_EditButtonsPanel.OnCancel += onCancelClick;
            m_EditButtonsPanel.OnReset += onResetClick;

            #endregion

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

        private BindingList<BaseEntity>? m_Entities
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

        private BaseEntity? m_SelectedEntity
        {
            get
            {
                if (dgvEntities.SelectedRows.Count == 0) return null;
                if (dgvEntities.SelectedRows[0] != null)//есть выбранная строка?
                {
                    if (dgvEntities.SelectedRows[0].DataBoundItem != null)
                    {
                        return (BaseEntity)dgvEntities.SelectedRows[0].DataBoundItem;
                    }
                    else return null;
                }
                else return null;
            }
            set
            {
                if (null == value) return;
                foreach (DataGridViewRow row in dgvEntities.Rows)
                {
                    if (row.Cells[0].Value.Equals(value.Id))
                    {
                        dgvEntities.ClearSelection();
                        dgvEntities.Rows[row.Index].Selected = true;
                        break;
                    }
                }
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
            m_EntityView.Entity = m_SelectedEntity;
        }

        #region MainButtons handlers

        private void onCreateClick()
        {
            switchButtons();
            //enter creation mode
        }

        private void onEditClick()
        {
            switchButtons();
            //enter edit mode
        }

        private void onDeleteClick()
        {
            try
            {
                m_Manager.Delete(m_EntityView.Entity);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При удалении записи произошла ошибка!{Environment.NewLine}{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region EditButtons handlers

        private void onSaveClick()
        {
            //save data + switch to view
            switchButtons();
        }

        private void onResetClick()
        {
            //reset data
        }

        private void onCancelClick()
        {
            //reset data + switch to view
            switchButtons();
        }

        #endregion
    }

}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

        private MainButtonsPanel m_MainButtonsPanel = new();
        private EditButtonsPanel m_EditButtonsPanel = new();
        private GameView m_GameView = new();

        public MainForm(IGamesManager gamesManager)
        {
            InitializeComponent();
            _gamesManager = gamesManager;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvEntities.ClearSelection();
            layoutMain.Controls.Add(m_MainButtonsPanel, 1, 0);
            m_GameView.Dock = m_MainButtonsPanel.Dock = m_EditButtonsPanel.Dock = DockStyle.Fill;
            #region event binding

            m_MainButtonsPanel.OnCreate += onCreateClick;
            m_MainButtonsPanel.OnEdit += onEditClick;
            m_MainButtonsPanel.OnDelete += onDeleteClick;
            m_EditButtonsPanel.OnSave += onSaveClick;
            m_EditButtonsPanel.OnReset += onResetClick;
            m_EditButtonsPanel.OnCancel += onCancelClick;

            #endregion

            refreshTable();
        }

        private BindingList<Game>? m_Games
        {
            get
            {
                if (null != GamesBS.DataSource)
                {
                    return GamesBS.DataSource as BindingList<Game>;
                }
                return null;
            }
            set
            {
                GamesBS.DataSource = value;
            }
        }

        private Game? m_SelectedGame
        {
            get
            {
                if (dgvEntities.SelectedRows.Count == 0) return null;
                if (dgvEntities.SelectedRows[0] != null)//есть выбранная строка?
                {
                    if (dgvEntities.SelectedRows[0].DataBoundItem != null)
                    {
                        return (Game)dgvEntities.SelectedRows[0].DataBoundItem;
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
            m_Games = new BindingList<Game>(_gamesManager.Get());
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

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            layoutMain.Controls.Add(m_GameView, 1, 1);
            m_MainButtonsPanel.SetEnabledButtons(true);
            m_GameView.Game = m_SelectedGame;
        }

        #region MainButtons handlers

        private void onCreateClick()
        {
            switchButtons();
            m_GameView.Mode = GameViewMode.Create;
            m_GameView.Game = new Game();
        }

        private void onEditClick()
        {
            switchButtons();
            m_GameView.Mode = GameViewMode.Edit;
            m_GameView.Game = _gamesManager.GetById(m_SelectedGame.Id);
        }

        private void onDeleteClick()
        {
            handleAction(() => _gamesManager.Delete(m_GameView.Game));
            refreshTable();
        }

        #endregion

        #region EditButtons handlers

        private async void onSaveClick()
        {
            var isSuccessful = false;
            //save data + switch to view
            switch (m_GameView.Mode)
            {
                case GameViewMode.Create:
                    isSuccessful = handleAction(() => _gamesManager.Create(m_GameView.Game));
                    break;
                case GameViewMode.Edit:
                    isSuccessful = handleAction(() => _gamesManager.Update(m_GameView.Game));
                    break;
            }
            if (isSuccessful)
            {
                m_GameView.Mode = GameViewMode.View;
                refreshTable();
                switchButtons();
            }
        }

        private void onResetClick()
        {
            //reset data
            switch (m_GameView.Mode)
            {
                case GameViewMode.Create:
                    m_GameView.Game = new Game();
                    break;
                case GameViewMode.Edit:
                    var game = _gamesManager.GetById(m_GameView.Game.Id);
                    if (game == null)
                    {
                        MessageBox.Show("Записи больше не существует!");
                        m_GameView.Mode = GameViewMode.View;
                    }
                    m_GameView.Game = game;
                    break;
            }
        }

        private void onCancelClick()
        {
            //reset data + switch to view
            m_GameView.Mode = GameViewMode.View;
            switchButtons();
        }

        #endregion

        /// <summary>
        /// Выполнение метода в обработчике ошибок.
        /// </summary>
        /// <param name="action">Выполняемый метод</param>
        /// <returns>true - исполнение без ошибок<br/> false - произошла ошибка</returns>
        private bool handleAction(Action action)
        {
            try
            {
                action.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
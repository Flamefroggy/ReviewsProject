using ReviewsData.Model;
using ReviewsProject.Utils;

namespace ReviewsProject.View;

public partial class GameView : UserControl
{
    public GameView()
    {
        InitializeComponent();
    }

    private void GameView_Load(object sender, EventArgs e)
    {
        Mode = GameViewMode.View;
    }

    public Game Game
    {
        get { return GameBS.DataSource as Game; }
        set { if (null != value) GameBS.DataSource = value; }
    }

    private GameViewMode m_Mode;
    public GameViewMode Mode
    {
        get { return m_Mode; }
        set
        {
            m_Mode = value;
            switch (value)
            {
                case GameViewMode.View:
                    ReadOnly = true;
                    break;
                case GameViewMode.Create:
                case GameViewMode.Edit:
                    ReadOnly = false;
                    break;

            }
        }
    }

    public bool ReadOnly
    {
        set
        {
            tbName.ReadOnly = value;
            tbDescription.ReadOnly = value;
        }
    }
}

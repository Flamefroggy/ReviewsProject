using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewsProject.View.ButtonControls
{
    public partial class MainButtonsPanel : UserControl
    {
        public delegate void MainButtonsEventHandler();
        public event MainButtonsEventHandler OnCreate;
        public event MainButtonsEventHandler OnEdit;
        public event MainButtonsEventHandler OnDelete;
    
        public MainButtonsPanel()
        {

            InitializeComponent();
        }


        public void SetEnabledButtons(bool value)
        {
            changeButton.Enabled = value;
            deleteButton.Enabled = value;
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            OnCreate?.Invoke();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            OnEdit?.Invoke();
        }

        private void deleteButtons_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke();
        }
    }
}

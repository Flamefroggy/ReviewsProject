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
    public partial class MainButtons : UserControl
    {
        public delegate void SwitchButtonHandler();
        public event SwitchButtonHandler OnSwitch;
    
        public MainButtons()
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
            OnSwitch?.Invoke();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            OnSwitch?.Invoke();
        }

        private void deleteButtons_Click(object sender, EventArgs e)
        {

        }
    }
}

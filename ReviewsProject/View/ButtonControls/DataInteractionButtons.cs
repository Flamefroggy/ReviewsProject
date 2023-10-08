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
    public partial class DataInteractionButtons : UserControl
    {
        public delegate void SwitchButtonHandler();
        public event SwitchButtonHandler OnSwitch;
        public DataInteractionButtons()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            OnSwitch?.Invoke();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            OnSwitch?.Invoke();
        }
    }
}

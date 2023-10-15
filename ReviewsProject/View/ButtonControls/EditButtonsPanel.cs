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
    public partial class EditButtonsPanel : UserControl
    {
        public delegate void SwitchButtonHandler();
        public event SwitchButtonHandler OnSave;
        public event SwitchButtonHandler OnReset;
        public event SwitchButtonHandler OnCancel;

        public EditButtonsPanel()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            OnSave?.Invoke();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            OnSave?.Invoke();
        }
    }
}

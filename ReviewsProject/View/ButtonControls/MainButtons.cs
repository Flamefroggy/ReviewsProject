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
        public MainButtons()
        {

            InitializeComponent();
        }

        private void activate_Button()
        {
            changeButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void deactivate_Button()
        {   
            changeButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButtons_Click(object sender, EventArgs e)
        {

        }
    }
}

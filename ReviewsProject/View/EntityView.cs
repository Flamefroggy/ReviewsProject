using ReviewsData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewsProject.View
{
    public partial class EntityView : UserControl
    {
        public EntityView()
        {
            InitializeComponent();
        }

        public BaseEntity Entity
        {
            get { return EntityBS.DataSource as BaseEntity; }
            set { if (null != value) EntityBS.DataSource = value; }
        }
    }
}

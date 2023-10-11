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

        private BaseEntity m_Entity
        {
            get { return (BaseEntity)EntityBS.DataSource; }
            set { if (null != value) EntityBS.DataSource = value; }
        }
    }
}

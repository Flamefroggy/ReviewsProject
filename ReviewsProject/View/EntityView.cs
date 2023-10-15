using ReviewsData.Model;
using ReviewsProject.Utils;
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

        private void EntityView_Load(object sender, EventArgs e)
        {
            Mode = EntityViewMode.View;
        }

        public BaseEntity Entity
        {
            get { return EntityBS.DataSource as BaseEntity; }
            set { if (null != value) EntityBS.DataSource = value; }
        }

        private EntityViewMode m_Mode;
        public EntityViewMode Mode
        {
            get { return m_Mode; }
            set
            {
                m_Mode = value;
                switch (value)
                {
                    case EntityViewMode.View:
                        ReadOnly = true;
                        break;
                    case EntityViewMode.Create:
                    case EntityViewMode.Edit:
                        ReadOnly = false;
                        break;

                }
            }
        }

        public bool ReadOnly
        {
            set
            {
                tbTitle.ReadOnly = value;
                tbDescription.ReadOnly = value;
            }
        }
    }
}

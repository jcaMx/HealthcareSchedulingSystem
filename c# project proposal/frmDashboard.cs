using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__project_proposal
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void buttonCreateSched_Click(object sender, EventArgs e)
        {
            frmCreateSched show = new frmCreateSched();
            show.Show();
        }
    }
}

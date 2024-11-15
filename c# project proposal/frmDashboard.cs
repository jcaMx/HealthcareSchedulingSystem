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
        private string name;
        private string contactNumber;
        private string schedDate;
        private string schedTime;
        private string appointmentType;
        public frmDashboard(string name, string contactNumber, string schedDate, string schedTime, string appointmentType)
        {
            InitializeComponent();
            this.name = name;
            this.contactNumber = contactNumber;
            this.schedDate = schedDate;
            this.schedTime = schedTime;
            this.appointmentType = appointmentType;
        }

        private void buttonCreateSched_Click(object sender, EventArgs e)
        {
            frmCreateSched show = new frmCreateSched();
            show.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            labelSched1.Text = $"Name: {name}\n" +
                           $"Contact Number: {contactNumber}\n" +
                           $"Appointment Type: {appointmentType}\n" +
                           $"Date: {schedDate}\n" +
                           $"Time: {schedTime}";
        }
    }
    }
}
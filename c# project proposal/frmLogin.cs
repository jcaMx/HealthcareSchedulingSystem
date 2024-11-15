﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace c__project_proposal
{
    public partial class frmLogin : Form
    {
        

        private UserAccount account = new AdminAccount("admin", "admin");
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtuserName.Text;
            string inputPassword = txtPassword.Text;

            if (account.ValidateCredentials(inputUsername, inputPassword))
            {
                MessageBox.Show($"Welcome User");
                this.Hide();

                frmDashboard show = new frmDashboard();
                show.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or password. Please try again.");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

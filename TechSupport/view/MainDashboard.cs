using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.view
{
    public partial class MainDashboard : Form
    {
        public LoginForm activeLoginForm;
        public MainDashboard(String username)
        {
            InitializeComponent();
            usernameLabel.Text = username;

        }

        private void ApplicationClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadIncidents(object sender, EventArgs e)
        {
            this.allIncidentsUserControl1.RefreshSelection(); 
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            activeLoginForm.Show();
        }
    }
}


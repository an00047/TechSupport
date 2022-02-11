using System;
using System.Windows.Forms;

namespace TechSupport.view
{
    /// <summary>
    /// 
    /// Builds the dashboard that holds the tab pages
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashboard : Form
    {
        public LoginForm activeLoginForm;

        /// <summary>
        /// Assigns the username instance variable to the current instance of username that 
        /// is passed in
        /// </summary>
        /// <param name="username">The username.</param>
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

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            activeLoginForm.Show();
        }
    }
}


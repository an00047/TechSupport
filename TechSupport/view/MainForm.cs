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
    /// <summary>
    /// Performs all of the operations for the MainForm form utilized in the 
    /// TechSupport app
    /// </summary>
    public partial class MainForm : Form
    {
        public LoginForm activeLoginForm;
        public MainForm(String username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
        }


        /// <summary>
        /// Handles the log out feature. Hides the Main Form and opens a new loginForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            activeLoginForm.Show();
        }

        /// <summary>
        /// Handles the closing of the form closing. Closes the application when the
        /// form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

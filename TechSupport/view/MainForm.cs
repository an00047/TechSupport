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
    // The MainForm form utilized by the TechSupport application
    public partial class MainForm : Form
    {
        //Constructs the MainForm
        public MainForm(String username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
        }

        //Handles the log out feature. Hides the Main Form and opens a new loginForm
        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm newLoginForm = new LoginForm();
            newLoginForm.Show();
        }

        //Handles the closing of the form closing. Closes the application when the
        //form is closed
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

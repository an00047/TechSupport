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
    /// Performs all of the operations for the LoginForm form utilized in the 
    /// TechSupport app
    /// </summary>
    public partial class LoginForm : Form
    {
        String errorMessage;
        public String username;
        public MainForm activeMainForm;


        public LoginForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Updates the error message displayed to the user
        /// </summary>
        public void UpdateErrorMessage()
        {
            errorLabel.Text = errorMessage;
            errorLabel.ForeColor = Color.Red;
        }


        /// <summary>
        /// Action handler for log in button click.
        /// Opens new MainForm if login information is correct. Hides login screen
        /// Displayes error message if login information is incorrect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("Jane")
                && passwordTextBox.Text.Equals("test1234"))
            {
                username = usernameTextBox.Text.ToString();
                this.Hide();

                if (activeMainForm == null)
                {
                    activeMainForm = new MainForm(username);
                    activeMainForm.activeLoginForm = this;
                    
                }

                activeMainForm.Show();
            }

            else
            {
                errorMessage = "Incorrect username/password";
                UpdateErrorMessage();
            }
        }

        /// <summary>
        ///Handles the text change action event. Resets the error message when
        /// Login information is changed
        /// </summary>
        private void LoginTextChanged(object sender, EventArgs e)
        {
            errorMessage = "";
            UpdateErrorMessage();
        }

        /// <summary>
        /// Handles the closing of the form window. 
        /// Closes the application on closure of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

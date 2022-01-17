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
    //The LoginForm form utilized by the TechSupport application.
    public partial class LoginForm : Form
    {
        String errorMessage;
        public String username;

        //Constructs the LoginForm form
        public LoginForm()
        {
            InitializeComponent();
        }

        //Updates the error message displayed to the user 
        public void updateErrorMessage()
        {
            errorLabel.Text = errorMessage;
            errorLabel.ForeColor = Color.Red;
        }

        // Action handler for log in button click.
        // Opens new MainForm if login information is correct. Hides login screen
        // Displayes error message if login information is incorrect
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("Jane")
                && passwordTextBox.Text.Equals("test1234"))
            {
                username = usernameTextBox.Text.ToString();
                this.Hide();
                MainForm newMainForm = new MainForm(usernameTextBox.Text.ToString());
                newMainForm.Show();
            }

            else
            {
                errorMessage = "Incorrect username/password";
                updateErrorMessage();
            }
        }

        //Handles the text change action event. Resets the error message when
        // Login information is changed
        private void loginTextChanged(object sender, EventArgs e)
        {
            errorMessage = "";
            updateErrorMessage();
        }

        //Handles the closing of the form window. 
        //Closes the application on closure of the form
        private void applicationClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

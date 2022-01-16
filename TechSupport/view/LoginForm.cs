using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport
{
    public partial class loginForm : Form
    {
        String errorMessage;

        public loginForm()
        {
            InitializeComponent();
        }

        //Updates the error message displayed to the user 
        public void updateErrorMessage()
        {
            errorTextBox.Text = errorMessage;
            errorTextBox.ForeColor = Color.Red;
        }

        // Action handler for log in button click
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("Jane") 
                && passwordTextBox.Text.Equals("test1234"))
            {
                Console.WriteLine("username");
            }
            else
            {
                errorMessage = "Incorrect username/password";
                updateErrorMessage();
            }
        }

        private void loginTextChanged(object sender, EventArgs e)
        {
            errorMessage = "";
            updateErrorMessage();
        }
    }
}

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
        }

        private void ApplicationClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

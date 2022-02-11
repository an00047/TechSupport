using System;
using System.Windows.Forms;
using TechSupport.controller;
using TechSupport.model;

namespace TechSupport.view
{
    /// <summary>
    /// Performs all of the operations for the MainForm form utilized in the 
    /// TechSupport app
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IncidentController incidentController;
        public LoginForm activeLoginForm;

        /// <summary>
        /// Initializes the username as the username in the parameter
        /// Initializes a new instance of IncidentController
        /// </summary>
        /// <param name="username"></param>
        public MainForm(String username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
            this.incidentController = new IncidentController();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            activeLoginForm.Show();
        }

        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidents();
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            Form addIncidentDialog = new AddIncidentDialog();
            DialogResult result = addIncidentDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.RefreshDataGrid();
            };
        }

        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            Form searchIncidentDialog = new SearchIncidentDialog();

            DialogResult result = searchIncidentDialog.ShowDialog();

        }
    }
}

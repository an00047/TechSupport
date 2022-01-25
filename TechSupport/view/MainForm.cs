﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public MainForm(String username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
            this.incidentController = new IncidentController();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidents();
        }

        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            Form addIncidentDialog = new AddIncidentDialog();
            DialogResult result = addIncidentDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.RefreshDataGrid();
            };
        }
    }
}

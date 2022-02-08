﻿using System;
using System.Windows.Forms;
using TechSupport.controller;
using TechSupport.model;

namespace TechSupport.UserControls
{
    public partial class AddIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new IncidentController instance
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var title = this.incidentTitleTextBox.Text;
                var description = this.incidentDescriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);
                this.SuccessLabel.Text = "Incident was added!";
                this.incidentController.Add(new Incident(title, description, customerID));
            }
            catch (Exception ex)
            {
                MessageBox.Show("All three items must be entered. Customer ID should be a number \n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.incidentTitleTextBox.Text = "";
            this.incidentDescriptionTextBox.Text = "";
            this.customerIDTextBox.Text = "";
            this.SuccessLabel.Text = "";
            
        }

    }
}

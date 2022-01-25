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

namespace TechSupport.model
{
    public partial class AddIncidentDialog : Form
    {
        private readonly IncidentController incidentController;

        public AddIncidentDialog()
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

                this.incidentController.Add(new Incident(title, description, customerID));
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input \n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

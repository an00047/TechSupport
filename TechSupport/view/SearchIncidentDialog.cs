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

namespace TechSupport.view
{
    /// <summary>
    /// The form that handles the searching feature
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of IncidentController 
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = int.Parse(this.SearchIncidentTextbox.Text);
                this.incidentController.GetIncidentsByCustomerID(customerID);
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not a valid customerID \n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGrid()
        {
            this.SearchIncidentDataGridView.DataSource = null;
            this.SearchIncidentDataGridView.DataSource 
                = this.incidentController.GetIncidentsByCustomerID(int.Parse(this.SearchIncidentTextbox.Text));
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.controller;
using TechSupport.model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIncidentUserControl"/> class.
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// Handles the Click event of the GetIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentException">There is no incident with that number</exception>
        private void GetIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {                
                int result = 0;
                bool isValidID = int.TryParse(this.incidentIDTextbox.Text, out result);
                if (isValidID)
                {
                    int incidentID = int.Parse(this.incidentIDTextbox.Text);
                    DBIncident currentIncident = this.incidentController.GetIncidentByID(incidentID);
                    if (currentIncident == null || String.IsNullOrEmpty(currentIncident.Customer))
                    {
                        throw new ArgumentException("There is no incident with that number");
                    }
                    if (currentIncident.DateClosed == null)
                    {

                        this.updateButton.Enabled = true;
                        this.closeButton.Enabled = true;
                        this.textToAddTextbox.Enabled = true;
                    }
                    if (currentIncident.Description != null && currentIncident.Description.Length >= 200)
                    {
                        textToAddTextbox.Enabled = false;
                    }
                    this.customerTextBox.Text = currentIncident.Customer;
                    this.productTextBox.Text = currentIncident.ProductCode;
                    this.dateOpenedTextBox.Text = currentIncident.DateOpened;
                    this.titleTextBox.Text = currentIncident.Title;
                    this.descriptionTextBox.Text = currentIncident.Description;
                    if (this.technicianComboBox.Items.Count <= 0)
                    {
                        List<DBTechnician> dataList = this.incidentController.GetTechnicians();
                        dataList.Insert(0, new DBTechnician { TechID = 0, Name = "-Unassigned-" });
                        this.technicianComboBox.DataSource = dataList;
                        this.technicianComboBox.DisplayMember = "Name";
                        this.technicianComboBox.ValueMember = "TechID";
                    }
                    if (currentIncident.TechID == null)
                    {
                        this.technicianComboBox.SelectedIndex = 0;
                    }
                    this.technicianComboBox.SelectedValue = currentIncident.TechID == null ? 0 : currentIncident.TechID;
                }
                else
                {
                    throw new ArgumentException("Incident ID should be a valid integer");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Load event of the UpdateIncidentUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UpdateIncidentUserControl_Load(object sender, EventArgs e)
        {
            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
            this.textToAddTextbox.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearText();

            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
            this.textToAddTextbox.Enabled = false;
            
        }

        /// <summary>
        /// Handles the Click event of the UpdateButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int incidentID = int.Parse(this.incidentIDTextbox.Text);
                DBIncident currentIncident = this.incidentController.GetIncidentByID(incidentID);
                int? techID = (int)this.technicianComboBox.SelectedValue == 0 ? null : (int?)this.technicianComboBox.SelectedValue;

                if ((currentIncident.TechID == techID) 
                    && currentIncident.Description == this.descriptionTextBox.Text 
                    && string.IsNullOrEmpty(this.textToAddTextbox.Text))
                {
                    throw new ArgumentException("There have been no changes to the form");
                }
                this.updateDatabaseHelper(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clears the text.
        /// </summary>
        private void ClearText()
        {
            this.technicianComboBox.DataSource = null;
            this.incidentIDTextbox.Text = "";
            this.customerTextBox.Text = "";
            this.productTextBox.Text = "";
            this.dateOpenedTextBox.Text = "";
            this.titleTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
            this.textToAddTextbox.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the CloseButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                int incidentID = int.Parse(this.incidentIDTextbox.Text);
                DBIncident currentIncident = this.incidentController.GetIncidentByID(incidentID);
                int? techID = (int)this.technicianComboBox.SelectedValue == 0 ? null : (int?)this.technicianComboBox.SelectedValue;

                if (techID == null) {
                    throw new ArgumentException("A technician must be assigned to close the incident");
                }
                
                DateTime currentDateTime = System.DateTime.Now;
                DialogResult lengthWarning;
                
                    lengthWarning = MessageBox.Show("This incident cannot be edited once it has been closed.\nContinue?",
                   "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (lengthWarning == DialogResult.OK)
                    {
                    this.updateDatabaseHelper(currentDateTime);
                        this.updateButton.Enabled = false;
                        this.closeButton.Enabled = false;
                        MessageBox.Show("Incident Successfully Closed. ",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to close incident. " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateDatabaseHelper(DateTime? currentCloseDate)
        {
            try
            {
                int incidentID = int.Parse(this.incidentIDTextbox.Text);
                DBIncident currentIncident = this.incidentController.GetIncidentByID(incidentID);
                int? techID = (int)this.technicianComboBox.SelectedValue == 0 ? null : (int?)this.technicianComboBox.SelectedValue;
                string description = this.descriptionTextBox.Text;
                string textToAdd = this.textToAddTextbox.Text;
                string dateUpdated = System.DateTime.Now.ToShortDateString();
                string updatedDescription = description + "\r\n" + dateUpdated + " " + textToAdd;
                DateTime? closeDate = currentCloseDate;
                DialogResult lengthWarning;
                if (textToAdd == "")
                {
                    updatedDescription = description;
                }

                

                if (updatedDescription.Length >= 200)
                {
                    lengthWarning = MessageBox.Show("Description length is too long. Any characters over 200 will be truncated. \n Continue? ",
                   "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (lengthWarning==DialogResult.OK)
                    {
                        this.incidentController.UpdateIncident(incidentID, currentIncident.DateClosed, currentIncident.Description, currentIncident.TechID, closeDate, updatedDescription.Substring(0, 200), techID);
                        this.textToAddTextbox.Enabled = false;
                    } else
                    {
                        this.descriptionTextBox.Text = currentIncident.Description;
                        this.textToAddTextbox.Text = textToAdd;
                        this.technicianComboBox.SelectedValue = techID;

                    }

                    
                } else
                {
                    this.incidentController.UpdateIncident(incidentID, currentIncident.DateClosed, currentIncident.Description, currentIncident.TechID, closeDate, updatedDescription, techID);
                }
                currentIncident = this.incidentController.GetIncidentByID(incidentID);
                this.descriptionTextBox.Text = currentIncident.Description;
                this.textToAddTextbox.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

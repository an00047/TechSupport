using System;
using System.Windows.Forms;
using TechSupport.controller;
using TechSupport.model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void GetIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                int incidentID = int.Parse(this.incidentIDTextbox.Text);
                DBIncident currentIncident = this.incidentController.GetIncidentByID(incidentID);
                this.customerTextBox.Text = currentIncident.Customer;
                this.productTextBox.Text = currentIncident.ProductCode;
                this.dateOpenedTextBox.Text = currentIncident.DateOpened;
                this.titleTextBox.Text = currentIncident.Title;
                this.descriptionTextBox.Text = currentIncident.Description;
                //this.technicianComboBox.Items.Add("-Unassigned-");
                this.technicianComboBox.DataSource = this.incidentController.GetTechnicians();
                this.technicianComboBox.DisplayMember = "Name";
                this.technicianComboBox.ValueMember = "TechID";
                this.updateButton.Enabled = true;
                this.closeButton.Enabled = true;
                this.textToAddTextbox.Enabled = true;

                //if (currentIncident.Technician == null || currentIncident.Technician == "")
                //{
                //    this.technicianComboBox.Items.Add("-Unassigned-");
                //    this.technicianComboBox.DataSource = this.incidentController.GetTechnicians();
                //    this.technicianComboBox.SelectedIndex = 0;
                //} 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incident ID should be a valid integer. " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateIncidentUserControl_Load(object sender, EventArgs e)
        {
            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
            this.textToAddTextbox.Enabled = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearText();

            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
            this.textToAddTextbox.Enabled = false;
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        { 
            try
            {
                int incidentID = int.Parse(this.incidentIDTextbox.Text);
                int techID = (int)this.technicianComboBox.SelectedValue;
                string description = this.descriptionTextBox.Text;
                string textToAdd = this.textToAddTextbox.Text;
                string dateUpdated = System.DateTime.Now.ToShortDateString();
                string updatedDescription = description + "\r\n" + dateUpdated + " " + textToAdd;
                DialogResult lengthWarning;
                if (description.Length >= 200)
                {
                    lengthWarning = MessageBox.Show("Description length is too long. Additional text will not be added. \n Continue?",
                   "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if(lengthWarning==DialogResult.OK)
                    {
                        this.incidentController.UpdateIncident(incidentID, "" , techID);
                    }
                }
                if (updatedDescription.Length >= 200)
                {
                    lengthWarning = MessageBox.Show("Description length is too long. Any characters over 200 will be truncated. \n Continue? ",
                   "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (lengthWarning==DialogResult.OK)
                    {

                        this.incidentController.UpdateIncident(incidentID, updatedDescription.Substring(0, 200), techID);
                        
                    }
                    
                } else
                {
                    this.incidentController.UpdateIncident(incidentID, updatedDescription, techID);
                    this.descriptionTextBox.Text = updatedDescription;
                    this.textToAddTextbox.Text = "";
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data! Check incident ID, technician, text to add. " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
//this.customerComboBox.DataSource = this.incidentController.GetCustomers();
//this.customerComboBox.DisplayMember = "Name";
//this.customerComboBox.ValueMember = "CustomerID";

//this.productComboBox.DataSource = this.incidentController.GetProducts();
//this.productComboBox.DisplayMember = "Name";
//this.productComboBox.ValueMember = "ProductCode";



//try
//{
//    var description = this.descriptionTextBox.Text;
//    var customerID = this.customerComboBox.SelectedValue;
//    var title = this.titleTextBox.Text;
//    var productCode = this.productComboBox.SelectedValue;

//    var incident = new DBIncident
//    {
//        Description = description,
//        CustomerID = (int)customerID,
//        Title = title,
//        ProductCode = (string)productCode
//    };

//    if (incidentController.IsRegistered((int)customerID, (string)productCode))
//    {
//        this.incidentController.AddIncident(incident);
//        this.SuccessLabel.Text = "Incident was added!";
//    }
//    else
//    {
//        MessageBox.Show("This customer does not have a registration for this item",
//        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }


//}
//catch (Exception ex)
//{
//    MessageBox.Show("Title and description cannot be empty. \n" + ex.Message,
//        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}
//        }
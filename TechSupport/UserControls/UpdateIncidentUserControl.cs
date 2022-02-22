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
                this.technicianComboBox.DataSource = this.incidentController.GetTechnicians();
                this.technicianComboBox.DisplayMember = "Name";
                this.technicianComboBox.ValueMember = "TechID";
                //if (currentIncident.Technician == null || currentIncident.Technician == "")
                //{
                //    this.technicianComboBox.Items.Add("-Unassigned-");
                //    this.technicianComboBox.DataSource = this.incidentController.GetTechnicians();
                //    this.technicianComboBox.SelectedIndex = 0;
                //} 
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
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
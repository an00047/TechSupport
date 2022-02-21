using System;
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
                var description = this.descriptionTextBox.Text;
                var customerID = this.customerComboBox.SelectedValue;
                var title = this.titleTextBox.Text;
                var productCode = this.productComboBox.SelectedValue;

                var incident = new DBIncident
                {
                    Description = description,
                    CustomerID = (int)customerID,
                    Title = title,
                    ProductCode = (string)productCode
                };

                if (incidentController.IsRegistered((int)customerID, (string)productCode))
                {
                    this.incidentController.AddIncident(incident);
                    this.SuccessLabel.Text = "Incident was added!";
                } 
                else
                {
                    MessageBox.Show("This customer does not have a registration for this item",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Title and description cannot be empty. \n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.descriptionTextBox.Text = "";
            this.titleTextBox.Text = "";
            this.SuccessLabel.Text = "";
            this.customerComboBox.SelectedIndex = 0;
            this.productComboBox.SelectedIndex = 0;
            
        }

        private void AddIncidentUserControl_Load(object sender, EventArgs e)
        {
            this.customerComboBox.DataSource = this.incidentController.GetCustomers();
            this.customerComboBox.DisplayMember = "Name";
            this.customerComboBox.ValueMember = "CustomerID";

            this.productComboBox.DataSource = this.incidentController.GetProducts();
            this.productComboBox.DisplayMember = "Name";
            this.productComboBox.ValueMember = "ProductCode";
        }

    }
}

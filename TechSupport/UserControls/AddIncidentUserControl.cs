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
                var customerID = int.Parse(this.customerComboBox.Text);
                var title = this.titleTextBox.Text;
                var productCode = this.productComboBox.Text;

                var incident = new DBIncident
                {
                    Description = description,
                    CustomerID = customerID,
                    Title = title,
                    ProductCode = productCode
                };

                this.incidentController.AddIncident(incident);
                this.SuccessLabel.Text = "Incident was added!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("All three items must be entered. Customer ID should be a number \n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.descriptionTextBox.Text = "";
            this.titleTextBox.Text = "";
            this.SuccessLabel.Text = "";
            
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

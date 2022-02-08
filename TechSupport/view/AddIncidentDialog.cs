using System;
using System.Windows.Forms;
using TechSupport.controller;

namespace TechSupport.model
{
    /// <summary>
    /// Form that handles the process for adding an incident to the instance
    /// </summary>
    public partial class AddIncidentDialog : Form
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new IncidentController instance
        /// </summary>
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

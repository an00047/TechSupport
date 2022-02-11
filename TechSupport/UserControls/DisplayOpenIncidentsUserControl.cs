using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.controller;
using TechSupport.model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Sets up the user control for the display of incidents from the database
    /// </summary>
    public partial class DisplayOpenIncidentsUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes the incident controller
        /// </summary>
        public DisplayOpenIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        /// <summary>
        /// Adds the incidents to the listview 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayOpenIncidentsUserControl_Load(object sender, EventArgs e)
        {
            List<DBIncident> openIncidentsList;
            try
            {
                openIncidentsList = this.incidentController.GetOpenIncidents();
                if (openIncidentsList.Count > 0)
                {
                    DBIncident incident;
                    for (int i = 0; i < openIncidentsList.Count; i++)
                    {
                        incident = openIncidentsList[i];
                        openIncidentsListView.Items.Add(incident.ProductCode);
                        openIncidentsListView.Items[i].SubItems.Add(incident.DateOpened);
                        openIncidentsListView.Items[i].SubItems.Add(incident.Customer);
                        openIncidentsListView.Items[i].SubItems.Add(incident.Technician);
                        openIncidentsListView.Items[i].SubItems.Add(incident.Title);
                    }
                }
                else
                {
                    MessageBox.Show("There are no open incidents at this time",
                    "No Opem Incidents", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured" + ex.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

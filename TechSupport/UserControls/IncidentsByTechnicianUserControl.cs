using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.controller;
using TechSupport.model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Controls the functions that allow you to see open incidents by each technician
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class IncidentsByTechnicianUserControl : UserControl
    {
        private IncidentController incidentController;
        private List<DBTechnician> technicianList;
        private List<DBIncident> incidentList;
        private DBTechnician technician;
        public IncidentsByTechnicianUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        private void IncidentsByTechnicianUserControl_Load(object sender, EventArgs e)
        {
            technicianList = incidentController.GetAllTechniciansWithIncidents();
            this.nameComboBox.DataSource = technicianList;

            technician = technicianList[nameComboBox.SelectedIndex];
            incidentList = incidentController.GetOpenIncidentsByTechnician(technician.TechID);
            this.technicianProductDataGridView.DataSource = incidentList;
            
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex >= 0)
            {
                technician = technicianList[nameComboBox.SelectedIndex];
                dBTechnicianBindingSource.Clear();
                dBTechnicianBindingSource.Add(technician);

                incidentList = incidentController.GetOpenIncidentsByTechnician(technician.TechID);
                this.technicianProductDataGridView.DataSource = incidentList;


            }
        }
    }
}

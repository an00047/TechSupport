using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.controller;
using TechSupport.model;

namespace TechSupport.UserControls
{
    public partial class IncidentsByTechnicianUserControl : UserControl
    {
        private IncidentController incidentController;
        private List<DBTechnician> technicianList;
        public IncidentsByTechnicianUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        private void IncidentsByTechnicianUserControl_Load(object sender, EventArgs e)
        {
            technicianList = incidentController.GetAllTechniciansWithIncidents();
            this.nameComboBox.DataSource = technicianList;
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex >= 0)
            {
                DBTechnician technician = technicianList[nameComboBox.SelectedIndex];
                dBTechnicianBindingSource.Clear();
                dBTechnicianBindingSource.Add(technician);
            }
        }
    }
}

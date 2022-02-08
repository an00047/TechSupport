using System;
using System.Windows.Forms;
using TechSupport.controller;

namespace TechSupport.UserControls
{
    public partial class AllIncidentsUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new incident controller
        /// </summary>
        private readonly IncidentController incidentController;
        public AllIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        public void RefreshSelection()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidents();
        }

        private void AllIncidentsUserControl_Load(object sender, EventArgs e)
        {
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidents();
            this.incidentDataGridView.Refresh();
        }
    }
}

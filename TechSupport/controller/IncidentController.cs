using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.model;

namespace TechSupport.controller
{
    /// <summary>
    /// Controls the data from the IncidentDAL that is utilized by the MainForm
    /// </summary>
    public class IncidentController
    {
        private IncidentDAL incidentSource;
        
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        public List<Incident> GetIncidents()
        {
            return this.incidentSource.GetIncidents();
        }

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Movie cannot be null");
            }
            this.incidentSource.Add(incident);
        }





    }
}

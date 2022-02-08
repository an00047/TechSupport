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

        /// <summary>
        /// Returns the incidents for the current instance
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetIncidents()
        {
            return this.incidentSource.GetIncidents();
        }

        /// <summary>
        /// Adds a new incident to the current instance
        /// </summary>
        /// <param name="incident">The incident to be added</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            this.incidentSource.Add(incident);
        }

        /// <summary>
        /// Gets all incidents by customerID for the current instance
        /// </summary>
        /// <param name="customerID">The customerID to be searched by</param>
        /// <returns>A List item of all Incidents with matching customerID</returns>
        public List<Incident> GetIncidentsByCustomerID(int customerID)
        {
            if (customerID < 0)
            {
                throw new ArgumentException("CustomerID cannot be negative");
            }

            return this.incidentSource.GetIncidentsByCustomerID(customerID);
        }

        




    }
}

using System;
using System.Collections.Generic;
using TechSupport.model;

namespace TechSupport.DAL { 
    
    /// <summary>
    /// Creates a list of Incident items 
    /// </summary>
    public class IncidentDAL
    {

        private static List<Incident> incidents = new List<Incident>
        {

        };

        /// <summary>
        /// Getter for the incidents List
        /// </summary>
        /// <returns>The instance list</returns>
        public List<Incident> GetIncidents()
        {
            return incidents;
        }

        /// <summary>
        /// Adds an Incident item to the List of incidents
        /// </summary>
        /// <param name="incident">The incident to be added to the List</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            incidents.Add(incident);
        }

        /// <summary>
        /// Creates a new list of incidents whose customerID is equal to the parameter
        /// </summary>
        /// <param name="customerID">The customerID being searched for</param>
        /// <returns>The list of incidents whose customerID matches the parameter</returns>
        public List<Incident> GetIncidentsByCustomerID(int customerID)
        {
            if (customerID < 0)
            {
                throw new ArgumentNullException("CustomerID cannot be negative");
            }
            return incidents.FindAll(e => e.CustomerID == customerID);
        }

    }
}

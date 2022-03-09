using System;
using System.Collections.Generic;
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
        private IncidentDBDAL incidentDBSource;
        private CustomerDBDAL customerDBSource;
        private ProductDBDAL productDBSource;
        private RegistrationDBDAL registrationDBSource;
        private TechnicianDBDAL technicianDBSource;
        
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
            this.incidentDBSource = new IncidentDBDAL();
            this.customerDBSource = new CustomerDBDAL();
            this.productDBSource = new ProductDBDAL();
            this.registrationDBSource = new RegistrationDBDAL();
            technicianDBSource = new TechnicianDBDAL();
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

        /// <summary>
        /// Gets all of the open incidents for the current instance from the 
        /// TechSupport MySQL database
        /// </summary>
        /// <returns>The list of all incidents that have null or empty close dates</returns>
        public List<DBIncident> GetOpenIncidents()
        {
            return this.incidentDBSource.GetOpenIncidents();
        }

        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        public void AddIncident(DBIncident incident)
        {
            if (incident != null)
            {
                this.incidentDBSource.AddIncident(incident);
            }            
        }

        /// <summary>
        /// Gets the customers.
        /// </summary>
        /// <returns>The list of customers</returns>
        public List<DBCustomer> GetCustomers()
        {
            return this.customerDBSource.GetCustomers();
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns>The list of products</returns>
        public List<DBProduct> GetProducts()
        {
            return this.productDBSource.GetProducts();
        }

        /// <summary>
        /// Determines whether the specified customer identifier is registered.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <param name="productCode">The product code.</param>
        /// <returns>
        ///   <c>true</c> if the specified customer identifier is registered; otherwise, <c>false</c>.
        /// </returns>
        public bool IsRegistered(int customerID, string productCode)
        {
            return this.registrationDBSource.IsRegistered(customerID, productCode);
        }

        /// <summary>
        /// Gets the incident by identifier.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <returns>The list of incidents </returns>
        public DBIncident GetIncidentByID(int incidentID)
        {
            if (incidentID <= 0)
            {
                throw new ArgumentException("Incident ID cannot be negative");
            }
            return this.incidentDBSource.GetIncidentByID(incidentID);
        }

        /// <summary>
        /// Gets the technicians.
        /// </summary>
        /// <returns></returns>
        public List<DBTechnician> GetTechnicians()
        {
            return this.technicianDBSource.GetTechnicians();
        }

        /// <summary>
        /// Updates the incident.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <param name="description">The description.</param>
        /// <param name="techID">The tech identifier.</param>
        public void UpdateIncident(int incidentID, string description, int? techID)
        {
            this.incidentDBSource.UpdateIncident(incidentID, description, techID);
        }

        /// <summary>
        /// Closes the incident.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <param name="currentDateTime">The current date time.</param>
        public void CloseIncident(int incidentID, DateTime currentDateTime)
        {
            this.incidentDBSource.CloseIncident(incidentID, currentDateTime);
        }
    }
}

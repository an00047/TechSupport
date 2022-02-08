using System;

namespace TechSupport.model
{
    /// <summary>
    /// Defines an Incident object to be used in the DAL
    /// </summary>
    public class Incident
    {
        public string Title { get; }

        public string Description { get; }
        public int CustomerID { get; }

        /// <summary>
        /// Creates an incident object that stores a title, description, and the customerID
        /// </summary>
        /// <param name="title">The incident title</param>
        /// <param name="description">The incident description</param>
        /// <param name="customerID">The ID of the customer</param>
        public Incident(string title, string description, int customerID)
        {
            if(string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be null or empty", "title");
            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Descrotion cannot be null or empty", "description");
            }
            if (customerID < 0)
            {
                throw new ArgumentException("customerID should not be negative", "customerID");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerID;
        }
    }
}

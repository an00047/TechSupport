using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

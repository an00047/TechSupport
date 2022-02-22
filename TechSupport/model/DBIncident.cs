using System;

namespace TechSupport.model
{
    /// <summary>
    /// The class defining the DBIncident
    /// </summary>
    public class DBIncident
    {

        public string ProductCode { get; set; }
        public string DateOpened { get; set; }
        public string Customer { get; set; }
        public string Technician { get; set; }
        public int TechID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CustomerID { get; set; }
    }
}

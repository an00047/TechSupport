using System;

namespace TechSupport.model
{
    /// <summary>
    /// The class defining the DBIncident
    /// </summary>
    public class DBIncident
    {

        public String ProductCode { get; set; }
        public String DateOpened { get; set; }
        public String Customer { get; set; }
        public String Technician { get; set; }
        public String Title { get; set; }
        public string Description { get; set; }
        public int CustomerID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.model
{
    /// <summary>
    /// The class defining the DBIncident
    /// </summary>
    public class DBIncident
    {

        public String ProductCode { get; set; }
        public DateTime DateOpened { get; set; }
        public String Customer { get; set; }
        public String Techniciam { get; set; }
        public String Title { get; set; }
    }
}

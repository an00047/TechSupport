using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.model
{
    class DBIncident
    {
        private String productCode;
        private DateTime dateOpened;
        private String customer;
        private String technician;
        private String title;

        public DBIncident()
        {

        }

        public String ProductCode { get; set; }
        public DateTime DateOpened { get; set; }
        public String Customer { get; set; }
        public String Techniciam { get; set; }
        public String Title { get; set; }
    }
}

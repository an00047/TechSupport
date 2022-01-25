﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<Incident> GetIncidents()
        {
            return incidents;
        }

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Movie cannot be null");
            }
            incidents.Add(incident);
        }

    }
}

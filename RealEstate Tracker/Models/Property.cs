using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate_Tracker.Models
{
    public class Property
    {
        public int PropertyId { get; set; }

        public string NameofOwner { get; set; }

        public string Address { get; set; }
        public int SalePrice { get; set; }
        
        public int LocationId { get; set; }

        // parent model reference

        public Location Location { get; set; }

        // child model reference

        public List<Appointment> Appointments { get; set; }

    }
}

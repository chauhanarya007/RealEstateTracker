using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate_Tracker.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string City { get; set; }
        [StringLength(6)]
        public string ZipCode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

        //child model reference
        public List<Property> Properties { get; set; }
    }
}

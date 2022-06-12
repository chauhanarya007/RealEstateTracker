using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate_Tracker.Models
{
    public class Property
    {
        public int PropertyId { get; set; }

        public string Photo { get; set; }
        public string Address { get; set; }

        public string OwnerDetails { get; set; }

        public int LocationId { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]  // MS Currency format
        public decimal SalePrice { get; set; }



        // parent model reference

        public Location Location { get; set; }

        // child model reference

        public List<Appointment> Appointments { get; set; }

    }
}

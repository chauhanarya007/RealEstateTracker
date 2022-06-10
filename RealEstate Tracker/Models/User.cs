using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate_Tracker.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        //child model reference
        public List<Appointment> Appointments { get; set; }



    }
}

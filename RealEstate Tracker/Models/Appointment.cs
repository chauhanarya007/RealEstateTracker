using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate_Tracker.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int UserId { get; set; }
        public int PropertyId { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //parent model reference

        public Property Property { get; set; }
        public User User { get; set; }


    }
}

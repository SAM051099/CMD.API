using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Model.Appointments
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string comment { get; set; }



        public List<Recommendation> Recommendations { get; set; }
    }
}


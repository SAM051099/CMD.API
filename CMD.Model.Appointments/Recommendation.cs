using CMD.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Model.Appointments
{
    public class Recommendation
    {       
        public int RecommendationId { get; set; }
        public Doctor RecommendedDoctor { get; set; }

        public int DoctorId { get; set; }

        public int AppointmentId { get; set; }
    }
}

//[Key]
//public int RecommedationId { get; set; }
//[ForeignKey("PatientDetails")]
//public int PatientDetialId { get; set; }
//public PatientDetails PatientDetails { get; set; }
//[ForeignKey("RecommendedDoctor")]
//public int RecommendedDoctorId { get; set; }
//public Doctor RecommendedDoctor { get; set; }
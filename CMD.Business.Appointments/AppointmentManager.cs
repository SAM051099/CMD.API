using CMD.Model.Appointments;
using CMD.Repository.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Business.Appointments
{
    public class AppointmentManager : IAppointmentManager
    {
        IAppointmentRepository AppointmentRepository= new AppointmentRepository();  

        public Recommendation AddRecommendtaion(Recommendation reco)
        {
            return AppointmentRepository.AddRecommendtaion(reco);

        }

        public bool RemoveRecommendation(int id)
        {
            return AppointmentRepository.RemoveRecommendation(id);
        }
    }
}

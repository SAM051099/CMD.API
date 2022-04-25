using CMD.Model.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMD.Repository.Appointments
{
    public interface IAppointmentRepository
    {
        Recommendation AddRecommendtaion(Recommendation reco);



        bool RemoveRecommendation(int id);


        //ICollection<Recommendation> GetAllRecommendation();


    }
}

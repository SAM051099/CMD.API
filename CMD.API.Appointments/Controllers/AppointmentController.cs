using CMD.Business.Appointments;
using CMD.Model.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CMD.API.Appointments.Controllers
{
    [RoutePrefix("api/appointment")]

    public class AppointmentController : ApiController
    {

       
            //private IDoctorReco doctorReco = new DoctorRecommendation();
            private IAppointmentManager AppointmentManager  = new AppointmentManager();


            [Route("Recommendation")]
            [HttpPost]

            public IHttpActionResult AddRecommendation(Recommendation recommendation)
            {
                var reco = AppointmentManager.AddRecommendtaion(recommendation);

                return Created($"api/recommendation/{reco.RecommendationId}", reco);
            }
        [Route("Recommendation/{id}")]

        [HttpDelete]

            public IHttpActionResult Remove(int id)
            {
                if (!AppointmentManager.RemoveRecommendation(id))
                    return BadRequest();
                return Ok();


            }


            
        }
    }


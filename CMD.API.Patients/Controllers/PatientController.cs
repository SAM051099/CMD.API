//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//namespace CMD.API.Patients.Controllers
//{
//    public class PatientController : ApiController
//    {
//        // GET: api/Patient
//        protected IPatientManager PatientManager;

//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET: api/Patient/5
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST: api/Patient
//        public void Post([FromBody]string value)
//        {
//            // 1. Authenticate the request, validate the call
//            // 2. Validate the authorization - Patient can't call certain method
//            // 3. Check if value is available
//            // 4. Receive the value from UI - Parse the requrest
//            // 5. Convert JSON into DTO

//            // PatientDTO patientDTO = new PatientDTO();

//            // 6. Validation rule
//            // 7. Call the Business and pass the DTO
//            // PatientManager.AddPatient(patientDTO);
//            // 14. return the data to UI, incase of exception return an error response
//        }

//        // PUT: api/Patient/5
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE: api/Patient/5
//        public void Delete(int id)
//        {
//        }
//    }
//}

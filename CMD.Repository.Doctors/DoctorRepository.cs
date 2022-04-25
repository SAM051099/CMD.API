using CMD.DbContextAll;
using CMD.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository.Doctors
{

    public class DoctorRepository : IDoctorRepository
    {
        CMDDbContext db = new CMDDbContext();
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = db.Doctors.ToList();
            return doctors;
        }
    }
}

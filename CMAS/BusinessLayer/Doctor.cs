using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Doctor
    {
        //public due to protection level, should be private
        public int DoctorId { get; set; }
        //public due to protection level, should be private
        public string DoctorName { get; set; }
        public string Department { get; set; }
        private List<Doctor> Doctors { get; set; }

        public Doctor(int doctorId, string doctorName, string department)
        {
            doctorId = DoctorId;
            doctorName = DoctorName;
            department = Department;
        }

        public void TestMobility()
        {
            //Same as Test.ExecuteTest()
        }
        public void Advice()
        {

        }
    }
}

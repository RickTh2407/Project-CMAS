using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Doctor
    {
        int DoctorId { get; set; }
        string DoctorName { get; set; }
        string Department { get; set; }
        InTreatment Intreatment { get; set; }
    }
}

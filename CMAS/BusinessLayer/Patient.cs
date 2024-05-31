using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Patient
    {
        int PatientId { get; set; }
        int PolisNumber { get; set; }
        string PatientName { get; set; }
        int RoomNumber { get; set; }
        string Department { get; set; }
    }
}

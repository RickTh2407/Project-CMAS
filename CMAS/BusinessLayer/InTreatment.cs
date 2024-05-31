using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class InTreatment
    {
        Doctor Doctor { get; set; }
        Physio Physio { get; set; }
        Patient Patient { get; set; }
        List<InTreatment> InTreatmentList { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Rapport
    {
        Patient Patient { get; set; }
        Doctor Doctor { get; set; }
        Physio Physio { get; set; }
        Data Data { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Physio
    {
        int PhysioId { get; set; }
        string PhysioName { get; set; }
        InTreatment inTreatment { get; set; }
    }
}
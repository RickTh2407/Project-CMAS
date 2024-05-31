using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Excersise
    {
        int ExcersiseId { get; set; }
        string ExcersiseName { get; set; }
        bool ExcersiseFinished { get; set; }
        List<Excersise> ExcersiseList { get; set; }
    }
}

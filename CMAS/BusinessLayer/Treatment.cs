using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Treatment
    {
        private Doctor Doctor { get; set; }
        private Physio Physio { get; set; }
        private Patient Patient { get; set; }
        private List<Treatment> TreatmentList { get; set; }

        public void AssignPatient()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Rapport
    {
        private int RapportId { get; set; }
        private Patient Patient { get; set; }
        private Doctor Doctor { get; set; }
        private Physio Physio { get; set; }
        private Data Data { get; set; }

        public void CreateRapport()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Reseacher
    {
        private int ResearcherId { get; set; }
        private string ResearcherName { get; set; }

        public void ViewDiagram()
        {
            //View diagram created in Statistic.CreateDiagram()
        }
        public void ViewStatistics()
        {
            //View general numbers of all tests.
        }
    }
}

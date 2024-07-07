using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Test
    {
        private int TestId { get; set; }
        private Patient Patient { get; set; }
        private DateTime DateOfExecution { get; set; }

        public Test(int testId,Patient patient, DateTime dateOfExecution)
        {
            testId = TestId;
            
            dateOfExecution = DateOfExecution;
        }
        public void ExecuteTest()
        {
            //insert where data is filled in and updated, through DAL, to database
        }
    }
}

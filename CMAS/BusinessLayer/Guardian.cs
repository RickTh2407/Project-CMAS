﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Guardian
    {
        private int GuardianId { get; set; }
        private int RelativePatient { get; set; }
        //For ID
        private Rapport Rapport { get; set; }

        public void VerifyResults()
        {
            //Function to change Exercise.ExerciseFinished from false to true
        }
    }
}

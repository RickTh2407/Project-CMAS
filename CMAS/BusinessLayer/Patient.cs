using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Patient
    {
        private int PatientId { get; set; }
        private int PolisNumber { get; set; }
        private string PatientName { get; set; }
        private string PatientAddress { get; set; }
        private string Advice { get; set; }
        private DateTime DateOfBirth { get; set; }
        //For ID
        private Illness Illness { get; set; }

        public Patient(int patientId, int polisNumber, string patientName, string patientAddress, string advice, DateTime dateOfBirth)
        {
            patientId = PatientId;
            polisNumber = PolisNumber;
            patientName = PatientName;
            patientAddress = PatientAddress;
            advice = Advice;
            dateOfBirth = DateOfBirth;
        }

        public void StartExercise()
        {

        }
        public void StopExercise()
        {

        }
    }
}

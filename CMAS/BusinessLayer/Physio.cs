using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Physio
    {
        private int PhysioId { get; set; }
        private string PhysioName { get; set; }

        public Physio(int physioId, string physioName)
        {
            physioId = PhysioId;
            physioName = PhysioName;
        }

        public void InputMeasurement()
        {

        }
        public void AssignExercise()
        {

        }
        public void StartExercise()
        {

        }
        public void StopExercise()
        {

        }
    }
}

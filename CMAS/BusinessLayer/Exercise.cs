using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Exercise
    {
        private int ExerciseId { get; set; }
        private string ExerciseName { get; set; }
        private string ExerciseDescription { get; set; }
        private bool ExerciseFinished { get; set; }
        private List<Exercise> Exercises { get; set; }

        public Exercise(int exerciseId, string exerciseName, string exerciseDescription, bool exerciseFinished)
        {
            exerciseId = ExerciseId;
            exerciseName = ExerciseName;
            exerciseDescription = ExerciseDescription;
            exerciseFinished = ExerciseFinished;
        }

        public void SummerizeExercise()
        {

        }

    }
}

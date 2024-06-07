using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Exercise
    {
        int ExerciseId { get; set; }
        string ExerciseName { get; set; }
        bool ExerciseFinished { get; set; }
        List<Exercise> ExerciseList { get; set; }
    }
}

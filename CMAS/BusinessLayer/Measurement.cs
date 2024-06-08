using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMAS.BusinessLayer
{
    internal class Measurement
    {
        private Patient Patient { get; set; }
        private double LeftAnkle { get; set; }
        private double RightAnkle { get; set; }
        private double LeftEar { get; set; }
        private double RightEar { get; set; }
        private double LeftElbow { get; set; }
        private double RightElbow { get; set; }
        private double LeftEye { get; set; }
        private double RightEye { get; set; }
        private double LeftHip { get; set; }
        private double RightHip { get; set; }
        private double LeftKnee { get; set; }
        private double RightKnee { get; set; }
        private double LeftShoulder { get; set; }
        private double RightShoulder { get; set; }
        private double LeftWrist { get; set; }
        private double RightWrist { get; set; }
        private double Nose { get; set; }
        private DateTime DateOfMeasurement { get; set; }
    }
}

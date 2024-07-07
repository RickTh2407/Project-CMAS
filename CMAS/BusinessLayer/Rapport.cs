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
        private string Location { get; set; }
        //START For ID and name
        private Patient Patient { get; set; }
        private Doctor Doctor { get; set; }
        private Physio Physio { get; set; }
        private Test Test { get; set; }
        //END For ID and name

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

        public Rapport(int rapportId, string location, double leftAnkle, double rightAnkle, double leftEar, double rightEar, 
            double leftElbow, double rightElbow, double leftEye, double rightEye, double leftHip, double rightHip, double leftKnee,
            double rightKnee, double leftShoulder, double rightShoulder, double leftWrist, double rightWrist, double nose)
        {
            rapportId = RapportId;
            location = Location;
            leftAnkle = LeftAnkle;
            rightAnkle = RightAnkle;
            leftEar = LeftEar;
            rightEar = RightEar;
            leftElbow = LeftElbow;
            rightElbow = RightElbow;
            leftEye = LeftEye;
            rightEye = RightEye;
            leftHip = LeftHip;
            rightHip = RightHip;
            leftKnee = LeftKnee;
            rightKnee = RightKnee;
            leftShoulder = LeftShoulder;
            rightShoulder = RightShoulder;
            leftWrist = LeftWrist;
            rightWrist = RightWrist;
            nose = Nose;
        }

        public void CreateRapport()
        {
            //Sum up all measurements with corresponding name + assign to account
        }
    }
}

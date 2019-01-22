using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anglular_Optics_DotNet
{
    class Lense
    {
        private Double focalLenth;
        
        public Lense(Double fL)
        {
            FoculLength = fL;
        }


        public Double FoculLength
        {

            get { return focalLenth; }
            set { focalLenth = value; }
        }


        public List<Double> incidentAngles = new List<Double>();
        public List<Double> refractedAngles = new List<Double>();


        public void UpdateLense(Double argNewFoculLenght)
        {
            FoculLength = argNewFoculLenght;
        }

        public void AddAngles(Double x)
        {
            incidentAngles.Add(x);
            incidentAngles.Add(x);
        }

        public Double CalculateRefractedAngle(Double objH)
        {
            Double refractedAngle;
            refractedAngle = Math.PI / 2 - Math.Atan(FoculLength / objH);
            return refractedAngle;
        }
    }
}

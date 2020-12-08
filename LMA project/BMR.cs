using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMA_project
{
    class BMR
    {
       
        private double Gewicht ;
        private double Lengte;
     private double Leeftijd ;
     private double Bmr;

        public BMR(double weight,double length, double age)
        {
            Sport get = new Sport();

            weight = Gewicht;
            length = Lengte;
            age = Leeftijd;
        }
        public double BMRMan ()
        {
            Bmr = 66 + (13.7 * Gewicht) + (5 * Lengte) - (6.8 * Leeftijd);
            return Bmr;
        }

        public double BMRvrouw()
        {
            Bmr = 655 + (9.6 * Gewicht) + (1.8 * Lengte) - (4.7 * Leeftijd);
            return Bmr;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMA_project
{
    class BMR
    {
     public readonly double  Gewicht;
     public readonly double Lengte;
     public  int Leeftijd ;

        public BMR(double weight, double length, int age)
        {
            this.Gewicht = weight;
            this.Lengte = length;
            this.Leeftijd = age;
        }
        public double BMRMan ()
        {
            double Bmr = 66 + (13.7 * Gewicht) + (5 * Lengte) - (6.8 * Leeftijd);
            return Bmr;
        }
        public double BMRvrouw()
        {
            double Bmr = 655 + (9.6 * Gewicht) + (1.8 * Lengte) - (4.7 * Leeftijd);
            return Bmr;
        }
    }
}

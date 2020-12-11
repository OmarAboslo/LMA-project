using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMA_project
{
    public partial class Sport : Form
    {
        public Sport()
        {
            InitializeComponent(); 
        }

        public double Snelheid(double uitslag)
        {
            double Gewicht = Convert.ToDouble(TextbGewicht.Text);
            double Gewenstegewicht = Convert.ToDouble(textBoxGewensteGewicht.Text);
           
            
            if (Gewicht < Gewenstegewicht)
            {
                if (RBNormaal.Checked == true)
                {

                uitslag = uitslag + 250;
                }
                else if (RBSnel.Checked == true)
                {
                 uitslag = uitslag +500;
                }
                else if (RBZosnelmogelijk.Checked == true)
                {

                uitslag = uitslag + 100;

                }
                return uitslag;
            }
            else if (Gewicht > Gewenstegewicht)
            { 
                if (RBNormaal.Checked == true)
                {
                    uitslag = uitslag - 250;
                }
                else if (RBSnel.Checked == true)
                {
           uitslag= uitslag - 500;
                }
                else if (RBZosnelmogelijk.Checked == true)
                {
           uitslag = uitslag - 1000; 
                }
                else
                {
      MessageBox.Show("Er zijn vragen die nog niet beantwoord zijn, conntroleer alle vragen en probeer opnieuw");
                }
                return uitslag;
            }
            return uitslag;
        }


        public double Actieflevel(double BMR)
        {
            double Result= 0;
            if (RBminderActief.Checked ==true)
            {
                Result = BMR * 1.2;
               
            }
            else if (RBredelijkActief.Checked == true)
            {
                Result = BMR * 1.375;
                
            }
            else if (RBheelactief.Checked == true)
            {
                Result = BMR * 1.55;
               
            }
            else if (RBextraactief.Checked== true)
            {
                Result = BMR * 1.725;
                
            }
            else if (RBergactief.Checked==true)
            {
                Result = BMR * 1.9;
            }
            return Result;

        }


      

        private void butOk_Click_1(object sender, EventArgs e)
        {
            // gegevens van de gebruiker ophalen

            double Gewicht = Convert.ToDouble(TextbGewicht.Text);
            double Lengte = Convert.ToDouble(TextbLengte.Text);
            int leeftijd = Convert.ToInt32(textbLeeftijd.Text);
            this.Hide();
            Dieet_A form = new Dieet_A();


            if (RBJa.Checked == true)
            {
                MessageBox.Show("Overleg met jouw huisarts,voordat je gaat beginnen");
            }
            //man of vrouw
            if (RBMan.Checked == true)
            {
                //class BMR aanroepen
                BMR man = new BMR(Gewicht, Lengte, leeftijd);
                // method snelheid aanroepen
                form.Result.Text = Convert.ToString(Snelheid(Actieflevel(man.BMRMan())));
                form.ShowDialog();
            }
            else if (RBVrouw.Checked == true)
            {
                //class BMR aanroepen
                BMR vrouw = new BMR(Gewicht, Lengte, leeftijd);
                //// method snelheid aanroepen
                Snelheid(Actieflevel(vrouw.BMRMan()));
                form.Result.Text = Convert.ToString(Snelheid(Actieflevel(vrouw.BMRMan())));
                form.ShowDialog();
            }

        }






















        /* double gewicht = Convert.ToDouble(TextbGewicht.Text);
         double lengte  = Convert.ToDouble(TextbLengte.Text);
         double result = gewicht / (lengte * lengte);
         int leeftijd= Convert.ToInt32(textbGeboortedatm.Text);

         if (result <= 18.5 && leeftijd >= 18 )
         {
             Te_licht Telicht = new Te_licht();
             this.Hide();
             Telicht.ShowDialog();
         }
         else if (result >= 18.5 && result <= 24.9 && leeftijd >= 18)
         {
             Normaal normaal = new Normaal();
             this.Hide();
             normaal.ShowDialog();
         }
         else if (result >= 24.9 && leeftijd >= 18)
         {
             Te_zwaar tezwaar = new Te_zwaar();
             this.Hide();
             tezwaar.ShowDialog(); 
        }*/




    }
}

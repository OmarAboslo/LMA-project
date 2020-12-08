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

        public void Snelheid(double uitslag)
        {
            double Gewicht = Convert.ToDouble(TextbGewicht.Text);
            double Gewenstegewicht = Convert.ToDouble(textBoxGewensteGewicht.Text);
            
            if (Gewicht < Gewenstegewicht)
            {
                if (RBNormaal.Checked == true)
                {
                   
                    result.Text = Convert.ToString(uitslag + 250);
                }
                else if (RBSnel.Checked == true)
                {
                   
                    result.Text = Convert.ToString(uitslag +500);

                }
                else if (RBZosnelmogelijk.Checked == true)
                {
                  
                    result.Text = Convert.ToString(uitslag + 1000);

                }
            }
            else if (Gewicht > Gewenstegewicht)
            {
                if (RBNormaal.Checked == true)
                {
                   // BMR = BMR - 250;
                    
                }
                else if (RBSnel.Checked == true)
                {
                  // BMR = BMR - 500;

                }
                else if (RBZosnelmogelijk.Checked == true)
                {
                   // BMR = BMR - 1000;

                }
                else
                {
                    MessageBox.Show("Er zijn vragen die nog niet beantwoord zijn, conntroleer alle vragen en probeer opnieuw");
                }
            }
        }


        private void butOk_Click(object sender, EventArgs e)
        {
            // gegevens van de gebruiker ophalen

            double Gewicht = Convert.ToDouble(TextbGewicht.Text);
            double Lengte = Convert.ToDouble(TextbLengte.Text);
            double leeftijd = Convert.ToDouble(textbLeeftijd.Text);
           //man of vrouw
            if (RBMan.Checked == true)
            {
                //class BMR aanroepen
               BMR man = new BMR(Gewicht,Lengte,leeftijd);
                // method snelheid aanroepen
                Snelheid(man.BMRMan());

            }
            else if (RBVrouw.Checked == true)
            {
                //class BMR aanroepen
                BMR vrouw = new BMR(Gewicht, Lengte, leeftijd);
                //// method snelheid aanroepen
                Snelheid(vrouw.BMRvrouw());
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

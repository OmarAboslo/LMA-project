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
    public partial class Gezond_lifestyle : Form
    {
        DieetSport Dieetsport = new DieetSport();
        
        public Gezond_lifestyle()
        {
            InitializeComponent(); 
        }

        public double Snelheid(double uitslag)
        {
            double Gewicht = Convert.ToDouble(TextbGewicht.Text);
            double Gewenstegewicht = Convert.ToDouble(textBoxGewensteGewicht.Text);    
            
            if (Gewicht < Gewenstegewicht)
            {
                ClassDieet.peronstate = false;
                if (RBNormaal.Checked == true)
                {

                uitslag += 250;
                }
                else if (RBSnel.Checked == true)
                {
                 uitslag += 500;
                }
                else if (RBZosnelmogelijk.Checked == true)
                {

                uitslag += 1000 ;

                }
                return uitslag;
            }
            else if (Gewicht > Gewenstegewicht)
            {
                ClassDieet.peronstate = true;
                if (RBNormaal.Checked == true)
                {
                    uitslag -= 250;
                }
                else if (RBSnel.Checked == true)
                {
                     uitslag -= 500;
                }
                else if (RBZosnelmogelijk.Checked == true)
                {
                     uitslag -= 1000; 
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

        public void aantal_Kacl()
        {
            if (ClassDieet.peronstate == true)
            {
                Dieetsport.tbResult.Text += "te verliezien: " + Convert.ToString(Convert.ToInt32(ClassDieet.GetKcal()));
            }
            else if (ClassDieet.peronstate == false)
            {
                Dieetsport.tbResult.Text += "te verkrijgen: " + Convert.ToString(Convert.ToInt32(ClassDieet.GetKcal()));
            }
        }

        private void ButOk_Click_1(object sender, EventArgs e)
        {
            
            // gegevens van de gebruiker ophalen
            double Gewicht = Convert.ToDouble(TextbGewicht.Text);
            double Lengte = Convert.ToDouble(TextbLengte.Text);
            int leeftijd = Convert.ToInt32(textbLeeftijd.Text);

            /// Controleren of de gebruiker een bepaalde ziekte heeft.
          
            if (RBziekteJa.Checked == true)
            {
                MessageBox.Show("Overleg met jouw huisarts,voordat je gaat beginnen");
            }
           
            
           


            if (RBMan.Checked == true)
            {
                BMR man = new BMR(Gewicht, Lengte, leeftijd);
                ClassDieet.kcal= (Snelheid(Actieflevel(man.BMRMan())));
                // method snelheid aanroepen
                aantal_Kacl();


                this.Hide();      
                Dieetsport.ShowDialog();
            }
            else if (RBVrouw.Checked == true)
            {
                //class BMR aanroepen
                BMR vrouw = new BMR(Gewicht, Lengte, leeftijd);
                ClassDieet.kcal= Snelheid(Actieflevel(vrouw.BMRMan()));
                //// method snelheid aanroepen
                aantal_Kacl();
                this.Hide();
                Dieetsport.ShowDialog();
            }



        }

        private void pichelp_MouseHover(object sender, EventArgs e)
        {
            lblhelp.Visible = true;
            lblhelp.Text = ("Vul alle onderstaande gegevens");
        }

        private void pichelp_MouseLeave(object sender, EventArgs e)
        {
            lblhelp.Visible = false;
        }
    }
}


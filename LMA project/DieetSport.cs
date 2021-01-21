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
    public partial class DieetSport : Form
    {
        public DieetSport()
        {
            InitializeComponent();
        }

        private void buttonDieet_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
            
        }

        private void btnHand_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dieet_H format= new Dieet_H();
            format.Show();
            
            

        }

        private void btnAut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dieet_A automatisch = new Dieet_A();
            automatisch.Show();
      

        }

        private void Helplabel_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void buttonDieet_MouseHover(object sender, EventArgs e)
        {
            Helplabel.Text = "efefed";
            Helplabel.Visible = true;
        }

        private void buttonTraining_MouseUp(object sender, MouseEventArgs e)
        {
            Helplabel.Text = "hahahahahahah";
        }

        private void buttonDieet_MouseLeave(object sender, EventArgs e)
        {
            Helplabel.Visible = false;
        }

    
    }
}

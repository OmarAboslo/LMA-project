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
            format.ShowDialog();
            
            

        }

        private void btnAut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dieet_A format = new Dieet_A();
            format.ShowDialog();

        }
    }
}

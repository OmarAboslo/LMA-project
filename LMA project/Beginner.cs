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
    public partial class Beginner : Form
    {
        public Beginner()
        {
            InitializeComponent();
        }

        private void btnPushup_Click(object sender, EventArgs e)
        {
            Pushup formPushup = new Pushup();
            formPushup.Show();
            this.Hide();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            NiveauKiezen formNiveauKiezen = new NiveauKiezen();
            formNiveauKiezen.Show();
            this.Hide();
        }

        private void btnPlank_Click(object sender, EventArgs e)
        {
            Plank formPlank = new Plank();
            formPlank.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pecdec formPecdec = new Pecdec();
            formPecdec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Curl formCurl = new Curl();
            formCurl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LegPress formLegPress = new LegPress();
            formLegPress.Show();
            this.Hide();
        }
    }
}

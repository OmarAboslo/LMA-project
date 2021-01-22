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
    public partial class Intermediate : Form
    {
        public Intermediate()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CurlIntermediate formCurlIntermediate = new CurlIntermediate();
            formCurlIntermediate.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LegPressIntermediate formLegPressIntermediate = new LegPressIntermediate();
            formLegPressIntermediate.Show();
            this.Hide();
        }

        private void btnSquats_Click(object sender, EventArgs e)
        {
            Squats formSquats = new Squats();
            formSquats.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BenchPress formBenchPress = new BenchPress();
            formBenchPress.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PosteriorFlies formPosteriorFlies = new PosteriorFlies();
            formPosteriorFlies.Show();
            this.Hide();
        }

        private void btnPushup_Click(object sender, EventArgs e)
        {
            InclinePress formInclinePress = new InclinePress();
            formInclinePress.Show();
            this.Hide();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            NiveauKiezen formNiveauKiezen = new NiveauKiezen();
            formNiveauKiezen.Show();
            this.Hide();
        }
    }
}

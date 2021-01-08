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
    public partial class NiveauKiezen : Form
    {
        public NiveauKiezen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Beginner formBeginner = new Beginner();
            formBeginner.Show();
            this.Hide();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            SchemaKiezen formSchemaKiezen = new SchemaKiezen();
            formSchemaKiezen.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            DieetSport formDieetSport = new DieetSport();
            formDieetSport.Show();
            this.Hide();
        }
    }
}

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
    public partial class SchemaKiezen : Form
    {
        public SchemaKiezen()
        {
            InitializeComponent();
        }

        private void btnVoorgesteld_Click(object sender, EventArgs e)
        {
            NiveauKiezen formNiveauKiezen = new NiveauKiezen();
            formNiveauKiezen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            DieetSport formDieetSport = new DieetSport();
            formDieetSport.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            DieetSport formDieetSport = new DieetSport();
            formDieetSport.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SchemaMaken formSchemaMaken = new SchemaMaken();
            formSchemaMaken.Show();
            this.Hide();
        }
    }
}

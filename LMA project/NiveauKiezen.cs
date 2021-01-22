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
            this.Size = new Size(600, 600);
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

      

        private void NiveauKiezen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Intermediate formIntermediate = new Intermediate();
            formIntermediate.Show();
            this.Hide();
        }
    }
}

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

        private void Sport_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butVoetballen_Click(object sender, EventArgs e)
        {
            
            Panel panel1 = new Panel();
            TextBox textBox1 = new TextBox();
            Label label1 = new Label();

            // Initialize the Panel control.
            panel1.Location = new Point();
            panel1.Size = new Size(831, 603);
            // Set the Borderstyle for the Panel to three-dimensional.
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // Initialize the Label and TextBox controls.
            label1.Location = new Point(16, 16);
            label1.Text = "hoe veel uur sport jij?";
            label1.Size = new Size(104, 16);
            textBox1.Location = new Point(16, 32);
            textBox1.Text = "";
            textBox1.Size = new Size(152, 20);

            // Add the Panel control to the form.
            this.Controls.Add(panel1);
            // Add the Label and TextBox controls to the Panel.
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
        }

        private void butVoetballen_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

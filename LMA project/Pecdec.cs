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
    public partial class Pecdec : Form
    {
        public Pecdec()
        {
            InitializeComponent();
            tbNotes.Hide();
            btnNotes2.Hide();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            tbNotes.Show();
            btnNotes2.Show();
        }

        private void btnNotes2_Click(object sender, EventArgs e)
        {
            tbNotes.Hide();
            btnNotes2.Hide();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Beginner formBeginner = new Beginner();
            formBeginner.Show();
            this.Hide();
        }
    }
}

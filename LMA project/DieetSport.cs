﻿using System;
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
            format.plmaandag.Visible = false;
            format.plDinsdag.Visible = false;
            format.plWoensdag.Visible = false;
            format.plDonderdag.Visible = false;
            format.plVrijdag.Visible = false;
            format.plZaterdag.Visible = false;
            format.plZondag.Visible = false;





        }

        private void btnAut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dieet_A automatisch = new Dieet_A();
            automatisch.Show();
            automatisch.plEerste.Visible = false;
            automatisch.plTweede.Visible = false;
            automatisch.plDerde.Visible = false;
            automatisch.plVierde.Visible = false;
            automatisch.plVijfde.Visible = false;
            automatisch.plZesde.Visible = false;
            automatisch.plZevende.Visible = false;


        }


        private void pichelp_MouseHover(object sender, EventArgs e)
        {
            lblhelp.Visible = true;
            lblhelp.Text = ("Kies een van de volgende opties");
        }

        private void pichelp_MouseLeave(object sender, EventArgs e)
        {
            lblhelp.Visible = false;
        }
    }
}

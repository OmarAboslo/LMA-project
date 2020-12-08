using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMA_project
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnAccountAanmaken_Click(object sender, EventArgs e)
        {
            FormAccountAanmaken formAccountAanmaken = new FormAccountAanmaken();
            formAccountAanmaken.Show();
            this.Hide();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "1" && tbWachtwoord.Text == "2")
            {
                Vragen vragen = new Vragen();
                vragen.Show();
                this.Hide();
            }

            else
                MessageBox.Show("De gebruikersnaam/wachtwoord is incorrect");
            }

        }
    }

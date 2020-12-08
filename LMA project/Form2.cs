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

        string[] gebruikersnamen = { "1", "2" };
        string[] wachtwoorden = { "1", "2" };
        List<string> gebruikers = new List<string>();
        List<string> wachtwoord = new List<string>();

        private void btnAccountAanmaken_Click(object sender, EventArgs e)
        {
            FormAccountAanmaken formAccountAanmaken = new FormAccountAanmaken();
            formAccountAanmaken.Show();
            this.Hide();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            if (gebruikersnamen.Contains(tbEmail.Text) && wachtwoorden.Contains(tbWachtwoord.Text) && Array.IndexOf(gebruikersnamen, tbEmail.Text)
                == Array.IndexOf(wachtwoorden, tbWachtwoord.Text))
            {
                Vragen vragen = new Vragen();
                vragen.Show();
                this.Hide();
            }

            else if (gebruikers.Contains(tbEmail.Text) && wachtwoord.Contains(tbWachtwoord.Text) && Array.IndexOf(gebruikers.ToArray(), tbEmail.Text)
                == Array.IndexOf(wachtwoord.ToArray(), tbWachtwoord.Text))
            {
                Vragen vragen = new Vragen();
                vragen.Show();
                this.Hide();
            }
            
            else
                MessageBox.Show("De gebruikersnaam/wachtwoord is incorrect");

            {

                StreamReader sr = new StreamReader("Vars.txt");
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    gebruikers.Add(components[0]);
                    wachtwoord.Add(components[0]);
                }
                sr.Close();
            }

        }
    }
}

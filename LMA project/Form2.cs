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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            DBAccess objDBAccess = new DBAccess();
            DataTable dtUsers = new DataTable();
            Gezond_lifestyle secound_form = new Gezond_lifestyle();

            //input gebruikers ophalen 
            string Gebruiksnaam = TGebruikersnaam.Text;
            string Wachtwoord = TWachtwoord.Text;

            if (Gebruiksnaam.Equals(""))
            {
                MessageBox.Show("please type jouw naam");
            }
            else if (Wachtwoord.Equals(""))
            {
                MessageBox.Show("please type jouw wachtwoord");
            }
            else
            {
                string query = "Select *  from Inloggen Where Email= '" + Gebruiksnaam + "'AND Wachtwoord= '" + Wachtwoord + "'";
                objDBAccess.readDatathroughAdapter(query, dtUsers);
                if (dtUsers.Rows.Count == 1)
                {
                    MessageBox.Show("Gelukt");
                    objDBAccess.closeConn();
                    //  this.Hide();

                    secound_form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Fout, Probeer later opnieuw");
                }

            }
        }

        private void BAccoun_maken_Click(object sender, EventArgs e)
        {
            Form1 Firstform = new Form1();
            this.Hide();
            Firstform.Show();
        }
    }
}

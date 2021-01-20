using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LMA_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            DBAccess objDBAccess = new DBAccess();
            string Email = TEmail.Text;
            string Wachtwoord = TWachtwoord.Text;
            string Wachtwoordbevestiging = TWachtwoord_bevestigen.Text;
            if (Email.Equals(""))
            {
                MessageBox.Show("please type jouw voornaam");
            }
           
            else if (Wachtwoord.Equals(""))
            {
                MessageBox.Show("please type jouw wachtwoord");
            }
            else if (Wachtwoordbevestiging.Equals(""))
            {
                MessageBox.Show("please type jouw email ");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Inloggen(Email,Wachtwoord,Wachtwoordbevestiging) values(@Email,@Wachtwoord,@Wachtwoordbevestiging)");
                insertCommand.Parameters.AddWithValue("@Email", Email);
             
                insertCommand.Parameters.AddWithValue("@Wachtwoord", Wachtwoord);
                insertCommand.Parameters.AddWithValue("@Wachtwoordbevestiging", Wachtwoordbevestiging);

                int row = objDBAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account Succesvol Aangemaakt");
                    this.Hide();
                    Form2 eerstscherm = new Form2();
                    eerstscherm.Show();


                }
                else
                {
                    MessageBox.Show("Fout, Probeer later opnieuw");
                }
            }
        }

        private void LAccount_aanmaken_Click(object sender, EventArgs e)
        {

        }
    }
}

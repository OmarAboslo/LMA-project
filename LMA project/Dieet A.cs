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
    public partial class Dieet_A : Form
    {
    
        public Dieet_A()
        {
            InitializeComponent();
        }

        public void GetItems(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection();
            cmd.Parameters.AddWithValue("@Kcal", ClassDieet.GetKcal() / 8);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr.GetString(0));
                listBox2.Items.Add(rdr.GetString(1) + "  " + rdr.GetString(2));
                listBox3.Items.Add(rdr.GetInt32(3));
                listBox4.Items.Add(rdr.GetDouble(4));
                listBox5.Items.Add(rdr.GetString(5));
                listBox6.Items.Add(rdr.GetDouble(6));
            }
            rdr.Close();
            con.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=192.168.172.77;Initial Catalog=proftaakproject;Persist Security Info=True;User ID=Omar;Password=&Wy%EN%EzvByVB26";
            con.Open();
            SqlCommand afvallen = new SqlCommand("Select TOP 8 Product,Hoeveelheid,Eenheid,Kcal,Eiwit, Koolh, Vet from Voeding Where Kcal <= @Kcal and Kcal>= @Kcal - 10  ORDER BY NEWID()", con);
            SqlCommand aankomen = new SqlCommand("Select TOP 8 Product,Hoeveelheid,Eenheid,Kcal,Eiwit, Koolh, Vet from Voeding Where Kcal >= @Kcal and Kcal <= @Kcal + 10 ORDER BY NEWID()", con);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            if (ClassDieet.Getpersonsate() == true)
            {
                GetItems(afvallen);
            }
            else if (ClassDieet.Getpersonsate() == false)
            {
                GetItems(aankomen);
            }

            }
        private void tbHandmatig_Click(object sender, EventArgs e)
        {
            Dieet_H new_form = new Dieet_H();
            this.Hide();
            new_form.Show();
        }
        private void btHome_Click(object sender, EventArgs e)
        {
            DieetSport HomePagina = new DieetSport();
            this.Hide();
            HomePagina.Show();

        }

        private void Dieet_A_Load(object sender, EventArgs e)
        {

        }
    }
}

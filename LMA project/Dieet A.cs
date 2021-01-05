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

  

      

        private void Button8_Click(object sender, EventArgs e)
        {
            panelPbox1.Hide();
            panelPbox2.Show();
            DBAccess objDBAccess = new DBAccess();
            objDBAccess.createConn();
            DataTable dtUsers = new DataTable();
            string ingredienten = textBox1.Text;
            string query = "Select *  from Ingredienten Where Product= '" + ingredienten + "'";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count == 1)
            {
                MessageBox.Show("Gelukt");
                objDBAccess.closeConn();
                //  this.Hide();

            }
            else
            {
                MessageBox.Show("Fout, Probeer later opnieuw");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=192.168.172.77;Initial Catalog=proftaakproject;Persist Security Info=True;User ID=Omar;Password=&Wy%EN%EzvByVB26";
            con.Open();
            MessageBox.Show("Connection created");
            SqlCommand cmd = new SqlCommand("Select Product,Hoeveelheid,Eenheid,Kcal,Eiwit,Koolh from Ingredienten Where Vet=@Vet",con);
            cmd.Parameters.AddWithValue("@Vet", 5.0);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                textBox1.Text= (dr.GetString(0));
                textBox2.Text = (dr.GetString(1));
                textBox3.Text = (dr.GetString(2));
                textBox4.Text = (dr.GetInt32(3).ToString());
                textBox5.Text = (dr.GetString(4));

            }
            dr.Close();
            con.Close();    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

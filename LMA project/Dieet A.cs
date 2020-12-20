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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select *  from [Ingredienten]";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            { 
            Product.Text = rd["Product"].ToString();
            }
        }
    }
}

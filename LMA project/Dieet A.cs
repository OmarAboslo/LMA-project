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
           public void voeding (int aantal)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=192.168.172.77;Initial Catalog=proftaakproject;Persist Security Info=True;User ID=Omar;Password=&Wy%EN%EzvByVB26";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Product,Hoeveelheid,Eenheid,Kcal,Eiwit,Koolh,Vet from Voed Where ID=@ID", con);
            Random NR = new Random();
        
            cmd.Parameters.AddWithValue( "@ID",  NR.Next(1,930) );         
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

           

                label1.Text = (dr.GetString(0)) ;              
                label2.Text = (dr.GetString(1)) ;              
               label3.Text = (dr.GetString(2)) ;
                label4.Text = (dr.GetInt32(3).ToString());
               label5.Text = (dr.GetDouble(4).ToString());  
            }
            dr.Close();
            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
                voeding(5);
            

           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* public void voeding(int aantal)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=192.168.172.77;Initial Catalog=proftaakproject;Persist Security Info=True;User ID=Omar;Password=&Wy%EN%EzvByVB26";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select TOP(@ID) Product,Hoeveelheid,Eenheid,Kcal,Eiwit,Koolh,Vet from Voed", con);
            listBox1.Items.Add("dit is een test");
            cmd.Parameters.AddWithValue("@ID", aantal);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                textBox1.Text += (dr.GetString(0)) + "\n";
                label2.Text = (dr.GetString(1));
                label3.Text = (dr.GetString(2));
                label4.Text = (dr.GetInt32(3).ToString());
                label5.Text = (dr.GetDouble(4).ToString());

                listBox1.Items.Add(dr.FieldCount.ToString());
            }
            dr.Close();
            con.Close();

        }
       */
    }
}

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
using System.Data.Common;

namespace LMA_project
{
    public partial class Dieet_H : Form
    {
        public Dieet_H()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source = 192.168.172.77; Initial Catalog = proftaakproject; Persist Security Info=True;User ID = Omar; Password=&Wy%EN%EzvByVB26");
        SqlCommand cmd;
        SqlDataReader dr;

        private void Dieet_H_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select Product from Voeding ", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                Collection.Add(dr.GetString(0));
            }
            textBox1.AutoCompleteCustomSource = Collection;
            dr.Close();
            cn.Close();
        }

        private void btshow_Click(object sender, EventArgs e)
        {
            cn.Open();
          //  AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
           // textBox1.AutoCompleteCustomSource = Collection;
            string result = textBox1.Text;
            SqlCommand cmdd = new SqlCommand("Select Product,Hoeveelheid,Eenheid,Kcal,Eiwit,Koolh,Vet from Voeding Where Product=@Product", cn);
            cmdd.Parameters.AddWithValue("@Product" , result);
            SqlDataReader drr = cmdd.ExecuteReader();

            while (drr.Read())
            {
                label1.Text = (drr.GetString(0));
                label2.Text = (drr.GetString(1));
               label3.Text = (drr.GetString(2));
                label4.Text = (drr.GetInt32(3).ToString());
                label5.Text = (drr.GetDouble(4).ToString());
                label6.Text = (drr.GetString(5));
               label7.Text = (drr.GetDouble(6).ToString());
            }
            drr.Close();
            cn.Close();
        }
    }
}

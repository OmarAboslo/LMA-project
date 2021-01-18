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
    }
}

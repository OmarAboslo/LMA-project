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
       ClassDieet aantalKcal = new ClassDieet();
        Dieet_A new_form = new Dieet_A();
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
            string result = textBox1.Text;
            double sum = 0;
            cn.Open();
            SqlCommand cmdd = new SqlCommand("Select Product,Hoeveelheid,Eenheid,Kcal,Eiwit,Koolh,Vet from Voeding Where Product=@Product", cn);
            cmdd.Parameters.AddWithValue("@Product" , result);
            SqlDataReader drr = cmdd.ExecuteReader();

            while (drr.Read())
            {
                listBox1.Items.Add (drr.GetString(0));
               listBox2.Items.Add (drr.GetString(1) + "  "+ drr.GetString(2));             
                listBox3.Items.Add  (drr.GetInt32(3).ToString());
              listBox4.Items.Add  (drr.GetDouble(4).ToString());
               listBox5.Items.Add (drr.GetString(5));
               listBox6.Items.Add  (drr.GetDouble(6).ToString());
            }
            drr.Close();
            cn.Close();
            for (int i = 0; i < listBox3.Items.Count; i++)
            {

                sum += Convert.ToDouble(listBox3.Items[i]);
                if (sum > ClassDieet.GetKcal())
                {
                    MessageBox.Show("Jij heb te veel gekozen, jij bent boven de limiet" + sum);
                }


            }

        }

        private void btautomatisch_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_form.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
        
        public void ListBoxRemove()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();


        }

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

     
        private void btMaandagAdd_Click(object sender, EventArgs e)
        {
            string gebruikerInput = tbmaandag.Text;
            listbMmaandag.Items.Add(gebruikerInput);

        }

        private void btMaandagRemove_Click(object sender, EventArgs e)
        {
            listbMmaandag.Items.Clear();
        }

        private void btDinsAdd_Click(object sender, EventArgs e)
        {
            string gebruikerInput = tbDins.Text;
            listbDins.Items.Add(gebruikerInput);
        }

        private void btMaandag_Click(object sender, EventArgs e)
        {

            plmaandag.Visible = true;
            plDinsdag.Visible = false;
            plWoensdag.Visible = false;
            plDonderdag.Visible = false;
            plVrijdag.Visible = false;
            plZaterdag.Visible = false;
            plZondag.Visible = false;
            ListBoxRemove();
        }

        private void btDinsdag_Click(object sender, EventArgs e)
        {
            plmaandag.Visible = false;
            plDinsdag.Visible = true;
            plWoensdag.Visible = false;
            plDonderdag.Visible = false;
            plVrijdag.Visible = false;
            plZaterdag.Visible = false;
            plZondag.Visible = false;
            ListBoxRemove();
        }

        private void tbmaandag_MouseClick(object sender, MouseEventArgs e)
        {
            tbmaandag.Text = "";
        }

        private void tbDins_MouseClick(object sender, MouseEventArgs e)
        {
            tbDins.Text = "";

        }

        private void btWoensdag_Click(object sender, EventArgs e)
        {
            plmaandag.Visible = false;
            plDinsdag.Visible = false;
            plWoensdag.Visible = true;
            plDonderdag.Visible = false;
            plVrijdag.Visible = false;
            plZaterdag.Visible = false;
            plZondag.Visible = false;
            ListBoxRemove();
        }

        private void btDonderdag_Click(object sender, EventArgs e)
        {
            plmaandag.Visible = false;
            plDinsdag.Visible = false;
            plWoensdag.Visible = false;
            plDonderdag.Visible = true;
            plVrijdag.Visible = false;
            plZaterdag.Visible = false;
            plZondag.Visible = false;
            ListBoxRemove();
        }

        private void btVrijdag_Click(object sender, EventArgs e)
        {
            plmaandag.Visible = false;
            plDinsdag.Visible = false;
            plWoensdag.Visible = false;
            plDonderdag.Visible = false;
            plVrijdag.Visible = true;
            plZaterdag.Visible = false;
            plZondag.Visible = false;
            ListBoxRemove();
        }

        private void btZaterdag_Click(object sender, EventArgs e)
        {
            plmaandag.Visible = false;
            plDinsdag.Visible = false;
            plWoensdag.Visible = false;
            plDonderdag.Visible = false;
            plVrijdag.Visible = false;
            plZaterdag.Visible = true;
            plZondag.Visible = false;
            ListBoxRemove();
        }

        private void btZondag_Click(object sender, EventArgs e)
        {
            plmaandag.Visible = false;
            plDinsdag.Visible = false;
            plWoensdag.Visible = false;
            plDonderdag.Visible = false;
            plVrijdag.Visible = false;
            plZaterdag.Visible = false;
            plZondag.Visible = true;
            ListBoxRemove();
        }

        private void btZondagAdd_Click(object sender, EventArgs e)
        {
            string gebruikerInput = tbZondag.Text;
            listbZondag.Items.Add(gebruikerInput);
        }

        private void btWoensdagAdd_Click(object sender, EventArgs e)
        {
            string gebruikerInput = tbWoensdag.Text;
            listbWoensdag.Items.Add(gebruikerInput);
        }

        private void btZaterdagAdd_Click(object sender, EventArgs e)
        {
            string gebruikerInput = tbZaterdag.Text;
            listbZaterdag.Items.Add(gebruikerInput);
        }

        private void btDonderdagAdd_Click(object sender, EventArgs e)
        {
            string gebruikerInput = tbDonderdag.Text;
            listbDonderdag.Items.Add(gebruikerInput);
        }

        private void btVrijdagAdd_Click(object sender, EventArgs e)
        {
            string gebruikerInput = tbVrijdag.Text;
            listbVrijdag.Items.Add(gebruikerInput);
        }

        private void btZondagRemove_Click(object sender, EventArgs e)
        {
            listbZondag.Items.Clear();
        }

        private void btWoesdagRemove_Click(object sender, EventArgs e)
        {
            listbWoensdag.Items.Clear();
        }

        private void btDinsRemove_Click(object sender, EventArgs e)
        {
           listbDins .Items.Clear();
        }

        private void btZaterdagRemove_Click(object sender, EventArgs e)
        {
            listbZaterdag.Items.Clear();
        }

        private void btDonderdagRemove_Click(object sender, EventArgs e)
        {
            listbDonderdag.Items.Clear();
        }

        private void btVrijdagRemove_Click(object sender, EventArgs e)
        {
            listbVrijdag.Items.Clear();
        }

        private void tbZondag_MouseClick(object sender, MouseEventArgs e)
        {
            tbZondag.Text = "";
        }

        private void tbVrijdag_MouseClick(object sender, MouseEventArgs e)
        {
            tbVrijdag.Text = "";
        }

        private void tbWoensdag_MouseClick(object sender, MouseEventArgs e)
        {
            tbWoensdag.Text = "";
        }

        private void tbZaterdag_MouseClick(object sender, MouseEventArgs e)
        {
            tbZaterdag.Text = "";
        }

        private void tbDonderdag_MouseClick(object sender, MouseEventArgs e)
        {
            tbDonderdag.Text = "";
        }


        private void btHome_Click(object sender, EventArgs e)
        {
            DieetSport HomePagina = new DieetSport();
            this.Hide();
            HomePagina.Show();
        }

        private void pichelp_MouseHover(object sender, EventArgs e)
        {
            lblhelp.Visible = true;
            lblhelp.Text = ("U kunt hier voedsel en dranken zoeken, toevoegen aan uw lijst, en opslaan in een andere lijst");
        }

        private void pichelp_MouseLeave(object sender, EventArgs e)
        {
            lblhelp.Visible = false;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

 
    }
}

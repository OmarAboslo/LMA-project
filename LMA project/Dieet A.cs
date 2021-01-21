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

        DBAccess automatisch = new DBAccess();
    
        public Dieet_A()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        public void GetItems(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Kcal", ClassDieet.GetKcal() / 8);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (plEerste.Visible == true)

                {
                    listB1Eerte.Items.Add(rdr.GetString(0));
                    listBox2Eerste.Items.Add(rdr.GetString(1) + "  " + rdr.GetString(2));
                    listB3Eerste.Items.Add(rdr.GetInt32(3));
                    listB4Eerste.Items.Add(rdr.GetDouble(4));
                    listB5Eerste.Items.Add(rdr.GetString(5));
                    listB6Eerste.Items.Add(rdr.GetDouble(6));
                }
                else if (plTweede.Visible == true)
                {
                   listB1Tweede.Items.Add(rdr.GetString(0));
                    listB2Tweede.Items.Add(rdr.GetString(1) + "  " + rdr.GetString(2));
                    listB3Tweede.Items.Add(rdr.GetInt32(3));
                    listB4Tweede.Items.Add(rdr.GetDouble(4));
                    listB5Tweede.Items.Add(rdr.GetString(5));
                    listB6tweede.Items.Add(rdr.GetDouble(6));
                }
                else if (plDerde.Visible == true)
                {
                    listB1Derde.Items.Add(rdr.GetString(0));
                    listB2Derde.Items.Add(rdr.GetString(1) + "  " + rdr.GetString(2));
                    listB3Derde.Items.Add(rdr.GetInt32(3));
                    listB4Derde.Items.Add(rdr.GetDouble(4));
                    listB5Derde.Items.Add(rdr.GetString(5));
                    listB6Derde.Items.Add(rdr.GetDouble(6));
                }
                else if (plVierde.Visible == true)
                {
                    listB1Vierde.Items.Add(rdr.GetString(0));
                    listB2Vierde.Items.Add(rdr.GetString(1) + "  " + rdr.GetString(2));
                    listB3Vierde.Items.Add(rdr.GetInt32(3));
                    listB4Vierde.Items.Add(rdr.GetDouble(4));
                    listB5Vierde.Items.Add(rdr.GetString(5));
                    listB6Vierde.Items.Add(rdr.GetDouble(6));
                }
                else if (plVijfde.Visible == true)
                {
                    listB1Vijfde.Items.Add(rdr.GetString(0));
                    listB2Vijfde.Items.Add(rdr.GetString(1) + "  " + rdr.GetString(2));
                    listB3Vijfde.Items.Add(rdr.GetInt32(3));
                    listB4Vijfde.Items.Add(rdr.GetDouble(4));
                    listB5vijfde.Items.Add(rdr.GetString(5));
                    listB6Vijfde.Items.Add(rdr.GetDouble(6));
                }
                else if (plZesde.Visible == true)
                {
                    listB1zesde.Items.Add(rdr.GetString(0));
                    listB2zesde.Items.Add(rdr.GetString(1) + "  " + rdr.GetString(2));
                    listB3zesde.Items.Add(rdr.GetInt32(3));
                    listB4zesde.Items.Add(rdr.GetDouble(4));
                    listB5zesde.Items.Add(rdr.GetString(5));
                    listB6zesde.Items.Add(rdr.GetDouble(6));
                }
                else if (plZevende.Visible == true)
                {
                    listB1Zevende.Items.Add(rdr.GetString(0));
                    listB2Zevende.Items.Add(rdr.GetString(1) + "  " + rdr.GetString(2));
                    listB3Zevende.Items.Add(rdr.GetInt32(3));
                    listB4Zevende.Items.Add(rdr.GetDouble(4));
                    listB5Zevende.Items.Add(rdr.GetString(5));
                    listBox6Zevende.Items.Add(rdr.GetDouble(6));
                }
            }
            rdr.Close();
            
        }
        public void Items()
        {

            con.ConnectionString = @"Data Source=192.168.172.77;Initial Catalog=proftaakproject;Persist Security Info=True;User ID=Omar;Password=&Wy%EN%EzvByVB26";
            con.Open();

            SqlCommand afvallen = new SqlCommand("Select TOP 8 Product,Hoeveelheid,Eenheid,Kcal,Eiwit, Koolh, Vet from Voeding Where Kcal <= @Kcal and Kcal>= @Kcal - 10  ORDER BY NEWID()", con);
            SqlCommand aankomen = new SqlCommand("Select TOP 8 Product,Hoeveelheid,Eenheid,Kcal,Eiwit, Koolh, Vet from Voeding Where Kcal >= @Kcal and Kcal <= @Kcal + 10 ORDER BY NEWID()", con);

            if (ClassDieet.Getpersonsate() == true)
            {
                GetItems(afvallen);
            }
            else if (ClassDieet.Getpersonsate() == false)
            {
                GetItems(aankomen);
            }
            con.Close();
        }
        public void ListBox_Leegmaken()
        {
            if (plEerste.Visible == true)

            {
                listB1Eerte.Items.Clear();
                listBox2Eerste.Items.Clear();
                listB3Eerste.Items.Clear();
                listB4Eerste.Items.Clear();
                listB5Eerste.Items.Clear();
                listB6Eerste.Items.Clear();
            }
            else if (plTweede.Visible == true)
            {
                listB1Tweede.Items.Clear();
                listB2Tweede.Items.Clear();
                listB3Tweede.Items.Clear();
                listB4Tweede.Items.Clear();
                listB5Tweede.Items.Clear();
                listB6tweede.Items.Clear();
            }
            else if (plDerde.Visible == true)
            {
                listB1Derde.Items.Clear();
                listB2Derde.Items.Clear();
                listB3Derde.Items.Clear();
                listB4Derde.Items.Clear();
                listB5Derde.Items.Clear();
                listB6Derde.Items.Clear();
            }
            else if (plVierde.Visible == true)
            {
                listB1Vierde.Items.Clear();
                listB2Vierde.Items.Clear();
                listB3Vierde.Items.Clear();
                listB4Vierde.Items.Clear();
                listB5Vierde.Items.Clear();
                listB6Vierde.Items.Clear();
            }
            else if (plVijfde.Visible == true)
            {
                listB1Vijfde.Items.Clear();
                listB2Vijfde.Items.Clear();
                listB3Vijfde.Items.Clear();
                listB4Vijfde.Items.Clear();
                listB5vijfde.Items.Clear();
                listB6Vijfde.Items.Clear();
            }
            else if (plZesde.Visible == true)
            {
                listB1zesde.Items.Clear();
                listB2zesde.Items.Clear();
                listB3zesde.Items.Clear();
                listB4zesde.Items.Clear();
                listB5zesde.Items.Clear();
                listB6zesde.Items.Clear();
            }
            else if (plZevende.Visible == true)
            {
                listB1Zevende.Items.Clear();
                listB2Zevende.Items.Clear();
                listB3Zevende.Items.Clear();
                listB4Zevende.Items.Clear();
                listB5Zevende.Items.Clear();
                listBox6Zevende.Items.Clear();
            }
        }





        bool eerste = true;
        bool tweede = true;
        bool derde = true;
        bool vierde = true;
        bool vijfde = true;
        bool zesde = true;
        bool zevende = true;

        private void tbHandmatig_Click(object sender, EventArgs e)
        {
            Dieet_H new_form = new Dieet_H();
            this.Hide();
            new_form.Show();
            new_form.plmaandag.Visible = false;
            new_form.plDinsdag.Visible = false;
            new_form.plWoensdag.Visible = false;
            new_form.plDonderdag.Visible = false;
            new_form.plVrijdag.Visible = false;
            new_form.plZaterdag.Visible = false;
            new_form.plZondag.Visible = false;
        }
        private void btHome_Click(object sender, EventArgs e)
        {
            DieetSport HomePagina = new DieetSport();
            this.Hide();
            HomePagina.Show();

        }
        private void btTweede_Click(object sender, EventArgs e)
        {
            plEerste.Visible = false;
            plTweede.Visible = true;
            plDerde.Visible = false;
            plVierde.Visible = false;
            plVijfde.Visible = false;
            plZesde.Visible = false;
            plZevende.Visible = false;
            if (tweede ==true)
            {
                Items();
             
            }
            tweede = false;

       
        }

        private void btDerde_Click(object sender, EventArgs e)
        {
            plEerste.Visible = false;
            plTweede.Visible = false;
            plDerde.Visible = true;
            plVierde.Visible = false;
            plVijfde.Visible = false;
            plZesde.Visible = false;
            plZevende.Visible = false;

            if (derde == true)
            {
                Items();
           
            }
            derde = false;
   
        }

        private void btVierde_Click(object sender, EventArgs e)
        {
            plEerste.Visible = false;
            plTweede.Visible = false;
            plDerde.Visible = false;
            plVierde.Visible = true;
            plVijfde.Visible = false;
            plZesde.Visible = false;
            plZevende.Visible = false;

            if (vierde == true)
            {
                Items();
               
            }
            vierde = false;
             
        }
        private void btVijfde_Click(object sender, EventArgs e)
        {
            plEerste.Visible = false;
            plTweede.Visible = false;
            plDerde.Visible = false;
            plVierde.Visible = false;
            plVijfde.Visible = true;
            plZesde.Visible = false;
            plZevende.Visible = false;
            if (vijfde == true)
            {
                Items();
           
            }
            vijfde = false;
         
           
        }

        private void btZesde_Click(object sender, EventArgs e)
        {
            plEerste.Visible = false;
            plTweede.Visible = false;
            plDerde.Visible = false;
            plVierde.Visible = false;
            plVijfde.Visible = false;
            plZesde.Visible = true;
            plZevende.Visible = false;
            if (zesde == true)
            {
                Items();
       
            }
            zesde = false;
          

        }

        private void btZevende_Click(object sender, EventArgs e)
        {
            plEerste.Visible = false;
            plTweede.Visible = false;
            plDerde.Visible = false;
            plVierde.Visible = false;
            plVijfde.Visible = false;
            plZesde.Visible = false;
            plZevende.Visible = true;
            if (zevende==true)
            {
                Items();
            
            }
            zevende = false;
               
        }

        private void btEerste_Click_1(object sender, EventArgs e)
        {
            plEerste.Visible = true;
            plTweede.Visible = false;
            plDerde.Visible = false;
            plVierde.Visible = false;
            plVijfde.Visible = false;
            plZesde.Visible = false;
            plZevende.Visible = false;
            if (eerste == true)
            {
                Items();
            }
            eerste = false;


        }

        private void btverwerken_Click(object sender, EventArgs e)
        {

            if (plEerste.Visible == true)
            {
                ListBox_Leegmaken();
                Items();
            }
            if (plTweede.Visible == true)
            {
                ListBox_Leegmaken();
                Items();
            }
            if (plDerde.Visible == true)
            {
                ListBox_Leegmaken();
                Items();
            }
            if (plVierde.Visible == true)
            {
                ListBox_Leegmaken();
                Items();
            }
            if (plVijfde.Visible == true)
            {
                ListBox_Leegmaken();
                Items();
            }
            if (plZesde.Visible == true)
            {
                ListBox_Leegmaken();
                Items();
            }
            if (plZevende.Visible == true)
            {
                ListBox_Leegmaken();
                Items();
            }
        }
    }
}

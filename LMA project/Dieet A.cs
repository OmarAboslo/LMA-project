using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataTable dtUsers = new DataTable();
            string ingredienten = textBox1.Text;
            string query = "Select *  from Ingredienten Where Producten= '" + ingredienten + "'";
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

   

     
    }
}

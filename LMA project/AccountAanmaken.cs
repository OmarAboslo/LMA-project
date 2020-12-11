using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMA_project
{
    public partial class AccountAanmaken : Form
    {
        public AccountAanmaken()
        {
            InitializeComponent();
        }

        private void btnAccountAanmaken_Click(object sender, EventArgs e)
        {
            string writerfile = "Vars.txt";
            using (StreamWriter writer = new StreamWriter(writerfile, true))
            {
                writer.WriteLine(TbEmail.Text);
                writer.WriteLine(TbWachtwoord.Text);
            }
        }
    }
}

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
    public partial class SchemaMaken : Form
    {
        public SchemaMaken()
        {
            InitializeComponent();
        }

        private void btnBiceps_Click(object sender, EventArgs e)
        {
            Biceps formBiceps = new Biceps();
            formBiceps.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SchemaKiezen formSchemaKiezen = new SchemaKiezen();
            formSchemaKiezen.Show();
            this.Hide();
        }
    }
}

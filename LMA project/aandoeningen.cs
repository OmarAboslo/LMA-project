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
    public partial class aandoeningen : Form
    {
        public aandoeningen()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAstma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cdc.gov/asthma/faqs.htm");
        }

        private void ButtonGriep_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://influenzastichting.nl/wat-is-influenza/?gclid=Cj0KCQiAwf39BRCCARIsALXWETz2PADRm2tvYcZ8e1fFhb6qMoJzBbrXvl7sHK7F5MtG606k2Fuf92QaAkiOEALw_wcB");
        }

        private void ButtonAdhd_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wijzijnmind.nl/psychische-klachten/psychipedia/adhd?gclid=Cj0KCQiAwf39BRCCARIsALXWETxq-TsEBhY9s7-KlMYwbtWyKtaEF7N3W3gzh5njv1Ob69qnUJuO9toaAokWEALw_wcB");
        }

        private void ButtonAids_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://metterdaad.eo.nl/projecten/afgeronde-projecten/aidsslachtoffers-kenia/aids-je-zult-het-maar-hebben?gclid=Cj0KCQiAwf39BRCCARIsALXWETzAhENbOG9vEgCBFe4j_h4jrapiXCzvM-1S4VYk1QNz0OP-3rkvxf4aAgh8EALw_wcB");
        }

        private void ButtonKeelontsteking_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.zorgwijzer.nl/zorgwijzers/keelontsteking");
        }

        private void ButtonAlzheimer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.alz.org/alzheimers-dementia/what-is-alzheimers");
        }

        private void Buttondepressie_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.113.nl/depressie?gclid=Cj0KCQiAwf39BRCCARIsALXWETzOPUaK2SNXKiLpWhPucqaofmm3PyaKA8gnEWw1bByusC1YvwdtvdoaAn15EALw_wcB");
        }

        private void Buttonhooikoorts_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mijnluchtwegallergie.nl/hooikoorts/");
        }
    }
}

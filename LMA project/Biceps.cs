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
    public partial class Biceps : Form
    {
        public Biceps()
        {
            InitializeComponent();
        }

        int test = 20;
        int test2 = 30;
        int res = 0;
        int sum = 0;
        int sum2;
        int sum3;
        int test3 = 50;
        int sumUncheck = 0;
        int sumUncheck2 = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Add("Test");
                sum = res + test;
                textBox1.Text = sum.ToString();
            }

            else
            {
                listBox1.Items.Remove("Test");
                sumUncheck = sum - sum;
                textBox1.Text = sumUncheck.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                listBox1.Items.Add("Test2");
                sum2 = sum + test2;
                textBox1.Text = sum2.ToString();
            }
            
            else
            {
                listBox1.Items.Remove("Test2");
                sumUncheck2 = sum2 - test2;
                textBox1.Text = sumUncheck2.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                listBox1.Items.Add("Test3");
                sum3 = sum2 + test3;
                textBox1.Text = sum3.ToString();
            }

            else
            {
                    listBox1.Items.Remove("Test3");
                }
            }
        }
    }
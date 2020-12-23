using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Big_Data
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        double a1, b1,a2,b2,a3,b3;

        private void tabPage1_Layout(object sender, LayoutEventArgs e)
        {
            textBox2.Text = "[c,d]";
            textBox1.Text = "[a,b]";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            string[] numbersA = textBox4.Text.Split(',');
            string[] numbersB = textBox5.Text.Split(',');
            a1 = double.Parse(numbersA[0]);
            a2 = double.Parse(numbersA[1]);
            a3 = double.Parse(numbersA[2]);
            b1 = double.Parse(numbersB[0]);
            b2 = double.Parse(numbersB[1]);
            b3 = double.Parse(numbersB[2]);
                Fuzzy A = new Fuzzy(a1, a2, a3);
                Fuzzy B = new Fuzzy(b1, b2, b3);
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        {
                            A=A + B; break;
                        }
                    case 1:
                        {
                            A = A - B;
                            break;
                        }
                    case 2:
                        {
                            A = A * B;
                            break;
                        }
                    case 3:
                        {
                            A = A / B;
                            break;
                        }
                    default:
                        break;
                }
                textBox6.Text = A.fResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Layout(object sender, LayoutEventArgs e)
        {
            textBox4.Text = "[ a, a_l, a_r ]";
            textBox5.Text = "[ b, b_l, b_r ]";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "[ a, a_l, a_r ]")
            {
                textBox4.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "[ b, b_l, b_r ]")
            {
                textBox5.Text = "";
            }
        }

        

        private void textBox4_Click(object sender, EventArgs e)
        {
            
        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] numbersA = textBox1.Text.Split(',');
                string[] numbersB = textBox2.Text.Split(',');
                a1 = double.Parse(numbersA[0]);
                b1 = double.Parse(numbersA[1]);
                a2 = double.Parse(numbersB[0]);
                b2 = double.Parse(numbersB[1]);

                var A = new Interval(a1, b1);
                var B = new Interval(a2, b2);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            textBox3.Text = (A + B).ToString();
                            break;
                        }
                    case 1:
                        {
                            textBox3.Text = (A - B).ToString();
                            break;
                        }
                    case 2:
                        {
                            textBox3.Text = (A * B).ToString();
                            break;
                        }
                    case 3:
                        {
                            textBox3.Text = (A / B).ToString();
                            break;
                        }

                    default:
                        break;
                }
            }
            catch 
            {

            }
           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "[a,b]")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "[c,d]" )
            {
                textBox2.Text = "";
            }
        }
    }

   

}

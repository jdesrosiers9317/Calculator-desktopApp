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

namespace calculator
{
    public partial class CalcForm : Form
    {
        private const string filePath = "memory.txt";
        public CalcForm()
        {
            InitializeComponent();
        }

        float num;
        float answer;
        int count;
        string operation;

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            calc();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            operation = num.ToString() + "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            operation = num.ToString() + "/";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            operation = num.ToString() + "+";
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            operation = num.ToString() + "-";
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        private void buttonMC_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string s = "";
                while ((s = sr.ReadToEnd()) != null)
                {
                    textBox1.Text = s;
                }
                sr.Close();
            }
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(textBox1.Text);
            }
        }

        private void buttonMD_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }

        public void calc()
        {
            switch(count)
            {
                case 1:
                    answer = num + float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;

                case 2:
                    answer = num - float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;

                case 3:
                    answer = num * float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 4:
                    if (num == 0)
                    {
                        textBox1.Text = "Error Cannot Divide by 0";
                        break;
                    }
                    else
                    {
                        answer = num / float.Parse(textBox1.Text);
                        textBox1.Text = answer.ToString();
                        break;
                    }

                default:
                    break;
            }//end switch
        }//end calc()
    }//end form
}//end namespace

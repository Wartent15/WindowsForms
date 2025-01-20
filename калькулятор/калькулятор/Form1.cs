using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        double FirstValue;

        string arithmetic;
        public Form1()
        {
            InitializeComponent();
            n1.Click += zeroDel;
            n2.Click += zeroDel;
            n3.Click += zeroDel;
            n4.Click += zeroDel;
            n5.Click += zeroDel;
            n6.Click += zeroDel;
            n7.Click += zeroDel;
            n8.Click += zeroDel;
            n9.Click += zeroDel;
            n0.Click += zeroDel;

        }
         private void zeroDel(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = button.Text;
                }
                else
                {
                    textBox1.Text += button.Text;
                }
            }
        }

        private async void button17_Click(object sender, EventArgs e)
        {
            double SecondValue;
            double Result;

            SecondValue = Convert.ToDouble(textBox1.Text);
            if (arithmetic == "+")
            {
                Result = FirstValue + SecondValue;
                textBox1.Text = Convert.ToString(Result);
                FirstValue = Result;
            }
            if (arithmetic == "-")
            {
                Result = FirstValue - SecondValue;
                textBox1.Text = Convert.ToString(Result);
                FirstValue = Result;
            }
            if (arithmetic == "*")
            {
                Result = FirstValue * SecondValue;
                textBox1.Text = Convert.ToString(Result);
                FirstValue = Result;
            }
            if (arithmetic == "/")
            {
                if (SecondValue == 0) // защита от дурака
                {
                    textBox1.Text = "Поменяй значение математик";
                    await Task.Delay(3000); // чтобы сообщение повисело а потом исчезло и можно было писать 

                    textBox1.Clear();
                    textBox1.Text = "0";
                }
                else
                {
                    Result = FirstValue / SecondValue;
                    textBox1.Text = Convert.ToString(Result);
                    FirstValue = Result;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {

        }

        private void n2_Click(object sender, EventArgs e)
        {

        }

        private void n3_Click(object sender, EventArgs e)
        {

        }

        private void n4_Click(object sender, EventArgs e)
        {

        }

        private void n5_Click(object sender, EventArgs e)
        {

        }

        private void n6_Click(object sender, EventArgs e)
        {

        }

        private void n7_Click(object sender, EventArgs e)
        {

        }

        private void n8_Click(object sender, EventArgs e)
        {

        }

        private void n9_Click(object sender, EventArgs e)
        {

        }

        private void n0_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void nC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void nPLU_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "+";
        }

        private void nMIN_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "-";
        }

        private void nSLA_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "/";
        }

        private void nMUL_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "*";
        }
    }
}

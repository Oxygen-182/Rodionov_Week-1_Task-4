using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_4_2_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string f(int n)
        {
            int newNum = n % 10;
            string s = newNum + " ";
            n /= 10;
            
            if (n > 0)
                s += f(n);

            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            int a;
            if (int.TryParse(textBox1.Text, out a) && a > 0)
            {
            }
            else
            {
                textBox3.Text += "Число A введено некорректно";
                return;
            }

            int b = int.Parse(textBox2.Text);
            if (int.TryParse(textBox2.Text, out b) && b > 0)
            {
            }
            else
            {
                textBox3.Text += "Число B введено некорректно";
                return;
            }

            if (a > b)
            {
                textBox3.Text += "Число A не может быт больше B";
                return;
            }
            if (a <= 0 && b <= 0)
            {
                textBox3.Text += "Числа не могут иметь значения меньше или равные нулю";
                return;
            }
            if (a <= 0)
            {
                textBox3.Text += "Число A не может иметь значение меньше или равное нулю";
                return;
            }
            if (b <= 0)
            {
                textBox3.Text += "Число B не может иметь значение меньше или равное нулю";
                return;
            }

            textBox3.Text += "Цифры натуральных чисел из интервала (AB) в прямом порядке:" + Environment.NewLine;

            string s = "";
            for (int i = a; i <= b; i++)
            {
                s += f(i);
            }
            textBox3.Text = s;
        }
    }
}

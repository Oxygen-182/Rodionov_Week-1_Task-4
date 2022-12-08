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
        static void f(int n, TextBox textBox3)
        {
            if (n % 10 == n)
            {
                textBox3.Text += n + " ";
            }
            if (n / 10 == 0) return;
            f(n / 10, textBox3);
            textBox3.Text += (n % 10) + " ";
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

            for (int i = a; i <= b; i++)
            {
                f(i, textBox3);
            }
        }
    }
}

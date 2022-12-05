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
                textBox3.Text += n + Environment.NewLine;
            }
            if (n / 10 == 0) return;
            f(n / 10, textBox3);
            textBox3.Text += (n % 10) + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            if (a % 1 != 0)
            {
                textBox3.Text += "Число a введено некорректно";
                return;
            }

            if (b % 1 != 0)
            {
                textBox3.Text += "Число b введено некорректно";
                return;
            }

            if (a > b)
            {
                textBox3.Text += "Число A не может быт больше B";
                return;
            }

            Console.WriteLine("\nЦифры натуральных чисел из интервала (AB) в прямом порядке:\n");

            for (int i = a; i <= b; i++)
            {
                f(i, textBox3);
                textBox3.Text += Environment.NewLine;
            }
        }
    }
}

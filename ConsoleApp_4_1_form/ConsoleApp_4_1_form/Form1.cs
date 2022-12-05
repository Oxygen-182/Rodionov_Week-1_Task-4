using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsoleApp_4_1_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + f(n - 1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            double m = double.Parse(textBox1.Text);
            double k = double.Parse(textBox2.Text);

            if (m % 1 != 0) 
            {
                textBox3.Text += "Число m введено некорректно";
                return;
            }
            if (k % 1 != 0)
            {
                textBox3.Text += "Число m введено некорректно";
                return;
            }
            if (m < 1 && k < 1)
            {
                textBox3.Text += "Оба числа введены некорректно";
                return;
            } 
            if (m < 1)
            {
                textBox3.Text += "Число m введено некорректно";
                return;
            }
            if (k < 1)
            {
                textBox3.Text += "Число k введено некорректно";
                return;
            }

            double x = f(m) + f(2 * k);

            textBox3.Text += $"{x}";
        }
    }
}

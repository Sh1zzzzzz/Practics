using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SelectedItem = new int();
            double Answer = new int();
            double X = new int();

            double x = Convert.ToDouble(textBox1.Text);

            textBox2.Text = "Результаты работы программы ст. Чурсинова Г.С. " + Environment.NewLine;

            textBox2.Text += "При X = " + textBox1.Text + Environment.NewLine;

            if (sh.Checked)
                SelectedItem = 1;
            if (ch.Checked)
                SelectedItem = 2;
            if (exp.Checked)
                SelectedItem = 3;

            switch (SelectedItem)
            {
                case 1:
                    X = Math.Sinh(x);
                    break;
                case 2:
                    X = Math.Cosh(x);
                    break;
                case 3:
                    X = Math.Exp(x);
                    break;
                default:
                    textBox2.Text += "Решение не найдено" + Environment.NewLine;
                    return;
            }

            if (x >= 7)
                Answer = 4;
            if ((-2 < x) && (x < 7))
                Answer = X - 2;
            if (x <= -2)
                Answer = Math.Sqrt(x + 2);

            textBox2.Text += "y = " + Answer.ToString() + Environment.NewLine;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
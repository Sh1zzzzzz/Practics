using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "Практическая работа №1 Чурсинов Г.С.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
      textBox2.Text += Environment.NewLine + "При x = " + x.ToString();
      double y;
      switch (comboBox1.Text)
      {
        case "5":
          y = (x + Math.Sin(0.5 * x) + Math.Sqrt(Math.Log(x, 10)) / (2 + 3 * Math.Cos(x)) + (Math.Pow(Math.E, 2 * x - 0.5)) / (2 + x));
          textBox2.Text += Environment.NewLine + "№ 5 Результат y = " + y.ToString();
          break;
        case "8":
          y = (3 * (x * x - Math.Abs(3 * x) + Math.Abs(1 - Math.Cos(x * x)))) / (2 * Math.Pow(Math.E, 3 * x - 2) - 3 * ((2 + x) / x));
          textBox2.Text += Environment.NewLine + "№ 8 Результат y = " + y.ToString();
          break;
        case "11":
          y = (Math.Sqrt(3 + Math.Log(x, 10) + 15 - x)) / (1 + Math.Sin((2 + x * x) / (1 + x)));
          textBox2.Text += Environment.NewLine + "№11 Результат y = " + y.ToString();
          break;
        case "14":
          y = (Math.Sqrt(2 + 0.5 * x * x + Math.Pow(Math.E, x + 2))) / (x * x * x - 3 * Math.Pow(2 * x - 1, 2));
          textBox2.Text += Environment.NewLine + "№14 Результат y = " + y.ToString();
          break;
        case "2":
          y = (0.5 * x * x - 1) / (Math.Sqrt(x)) + (Math.Abs(10 - Math.Pow(Math.E, 0.5 * x * x + 1))) / (Math.Log(2 * x, 10) - 1);
          textBox2.Text += Environment.NewLine + "№ 2 Результат y = " + y.ToString();
          break;
        }

      // 5  = (x + Math.Sin(0.5 * x) + Math.Sqrt(Math.Log(x, 10)) / (2 + 3 * Math.Cos(x)) + (Math.Pow(Math.E, 2 * x - 0.5)) / (2 + x));
      // 8  = (3 * (x * x - Math.Abs(3 * x) + Math.Abs(1 - Math.Cos(x * x)))) / (2 * Math.Pow(Math.E, 3 * x - 2) - 3 * ((2 + x) / x));
      // 11 = (Math.Sqrt(3 + Math.Log(x, 10) + 15 - x)) / (1 + Math.Sin((2 + x * x) / (1 + x)));
      // 14 = (Math.Sqrt(2 + 0.5 * x * x + Math.Pow(Math.E, x + 2))) / (x * x * x - 3 * Math.Pow(2 * x - 1, 2));
      // 2  = (0.5 * x * x - 1) / (Math.Sqrt(x)) + (Math.Abs(10 - Math.Pow(Math.E, 0.5 * x * x + 1))) / (Math.Log(2 * x, 10) - 1);
        }
    }
}
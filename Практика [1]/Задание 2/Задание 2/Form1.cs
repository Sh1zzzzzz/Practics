using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DodgerBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Начало работы";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "До свидания!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Привет!";
        }
    }
}
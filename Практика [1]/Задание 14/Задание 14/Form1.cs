using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Мина!";
            this.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "Мина!";
            this.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "0";
        }
    }
}
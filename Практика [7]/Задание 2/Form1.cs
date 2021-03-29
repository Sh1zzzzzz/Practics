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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
                col.Width = 30;
                
            int[,] a = new int[15, 15];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 15; i++)
            for (j = 0; j < 15; j++)
                a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 15; i++)
            for (j = 0; j < 15; j++)
                dataGridView1.Rows[i].Cells[j].Value =
                    Convert.ToString(a[i, j]);
            
            // Задание
            int min = -100;
            int max = 100;
            for (i = 0; i < 15; i++) {
                if (a[i, 14 - i] > min)
                    min = a[i, 14 - i];
                if (a[i, 14 - i] < max)
                    max = a[i, 14 - i];
            }
            textBox1.Text = Convert.ToString(min);
            textBox2.Text = Convert.ToString(max);
        }
    }
}
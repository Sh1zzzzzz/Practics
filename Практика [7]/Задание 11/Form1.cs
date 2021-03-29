﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_11
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
                dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
            
            // Задание
            int max = -100;
            int min = 100;
            for (i = 0; i < 15; i++) {
                for (j = 0; j < 15; j++) {
                    if (i % 2 == 0 & a[i, j] > max)
                        max = a[i, j];
                    if (i % 2 == 1 & a[i, j] < min)
                        min = a[i, j];
                }
            }
            textBox1.Text = Convert.ToString(max);
            textBox2.Text = Convert.ToString(min);
        }
    }
}
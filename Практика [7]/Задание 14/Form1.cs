﻿using System;
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
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 17;
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
            int variable = -100;
            for (i = 0; i < 15; i++) {
                for (j = 0; j < 15; j++)
                    if (a[i, j] > 0 & a[i, j] > variable)
                        variable = a[i, j];
                dataGridView1.Rows[i].Cells[15].Value = "Max: ";
                dataGridView1.Rows[i].Cells[16].Value = Convert.ToString(variable);
                variable = 0;
            }
            
        }
    }
}
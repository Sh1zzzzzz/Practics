using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Задание_14
{
    public partial class Form1 : Form
    {
        private int x, y, x1, y1;
        private double a;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.Red), x1,y1, 10,10);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            x1 += rnd.Next(-50, 50);
            if (ClientSize.Width < x1 ^ x1 < 0)
                x1 = ClientSize.Width / 2;
            y1 += rnd.Next(-50, 50);
            if (ClientSize.Height < y1 ^ y1 < 0)
                y1 = ClientSize.Height / 2;
            Invalidate();
        }
    }
}
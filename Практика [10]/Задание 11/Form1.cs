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

namespace Задание_11
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
            Point[] curvePoints = {new Point(x1+3, y1+50), new Point(x1+45, y1+37), new Point(x1+60, y1+0), new Point(x1+75, y1+37), new Point(x1+115, y1+50), new Point(x1+73, y1+60), new Point(x1+60, y1+100), new Point(x1+46, y1+60)};
            g.FillPolygon(new SolidBrush(Color.Yellow), curvePoints);
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
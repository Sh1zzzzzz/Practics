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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // g.DrawLine(pen, 0, 300, 600, 300);
            g.FillRectangle(new SolidBrush(Color.SkyBlue), 0, 0, 600, 300);
            g.FillEllipse(new SolidBrush(Color.Yellow), 20, 10, 40, 40);
            g.FillRectangle(new SolidBrush(Color.ForestGreen), 0, 300, 600, 100);
            g.FillRectangle(new SolidBrush(Color.Brown), 200, 200, 100, 100);
            g.FillRectangle(new SolidBrush(Color.CadetBlue), 225, 225, 50, 50);
            Point[] curvePoints = {new Point(165, 200), new Point(250, 150), new Point(335, 200)};
            g.FillPolygon(new SolidBrush(Color.SaddleBrown), curvePoints);
            g.FillRectangle(new SolidBrush(Color.SaddleBrown), 450, 225, 20, 100);
            g.FillEllipse(new SolidBrush(Color.Green), 425, 190, 70, 70);
        }
    }
}
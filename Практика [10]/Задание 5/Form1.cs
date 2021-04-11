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
using System.Windows.Forms.VisualStyles;

namespace Задание_5
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2, r;
        private double a;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.LightBlue), x2, y2, 10, 10);
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            a += 0.1;
            r -= 1;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        x1 = ClientSize.Width / 2;
        y1 = ClientSize.Height / 2;
        r = 150; //задаем радиус
        a = 0;   //задаем угол поворота
        //определяем конец часовой стрелки с учетом центра экрана
        x2 = x1 + (int) (r * Math.Cos(a));
        y2 = y1 - (int) (r * Math.Sin(a));
        }
    }
}
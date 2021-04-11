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

namespace Задание_2
{
    public partial class Form1 : Form
    {
        //описываем переменные доступные в любом обработчике событий класса Form1
        private int x1, y1, x2, y2, x3, y3, r;
        private double a;
        private Pen pen = new Pen(Color.Gray, 10);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, (ClientSize.Width / 2) - 100 ,(ClientSize.Height / 2) - 100, 200,200);
            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x1, y1, x3, y3);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            a -= 0.5;//уменьшаем угол на 0,1 радиану
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            x3 = x1 + (int)(r * Math.Cos(3.14+a));
            y3 = y1 - (int)(r * Math.Sin(3.14+a));
            Invalidate(); //вынудительный вызов перерисовки (Paint)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            r = 100; //задаем радиус
            a = 0;   //задаем угол поворота
            x2 = x1 + (int) (r * Math.Cos(a));
            y2 = y1 - (int) (r * Math.Sin(a));
            x3 = x1 + (int) (r * Math.Cos(3.14+a));
            y3 = y1 - (int) (r * Math.Sin(3.14+a));

        }
    }
}
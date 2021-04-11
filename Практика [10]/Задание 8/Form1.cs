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

namespace Задание_8
{
    public partial class Form1 : Form
    {
        private int x, y;
        private int x2, y2, r;
        private double a;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // g.DrawEllipse(new Pen(Color.Black), 10, 10, ClientSize.Width-30, (ClientSize.Height)-30);
            g.FillEllipse(new SolidBrush(Color.Red), x2, y2, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Red), x, y, 10, 10);
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            a += 0.1;
            //определяем конец часовой стрелки с учетом центра экрана
            x2 = x + (int)(r * Math.Cos(a));
            y2 = y - (int)(r * Math.Sin(a));
            Invalidate(); //вынудительный вызов перерисовки (Paint)


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            x = ClientSize.Width / 2;
            y = ClientSize.Height / 2;
            r = x - 30;
            a = 0;
            x2 = x + (int) (r * Math.Cos(a));
            y2 = y - (int) (r * Math.Sin(a));

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            x = ClientSize.Width / 2;
            y = ClientSize.Height / 2;
            r = x - 30;
        }
    }
}
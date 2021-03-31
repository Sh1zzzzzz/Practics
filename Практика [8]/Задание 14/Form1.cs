using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Задание_14
{
    public partial class Form1 : Form
    {
        private double XMin = 0.5;
        private double XMax = 10;
        private double Step = 0.5;
        private double[] x;
        private double[] y;
        Chart chart;
        private void CalcFunction()
        {
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
            x = new double[count];
            y = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = XMin + Step * i;
                y[i] = (Math.Sqrt(2 + 0.5 * x[i] * x[i] + Math.Pow(Math.E, x[i] + 2))) / (x[i] * x[i] * x[i] - 3 * Math.Pow(2 * x[i] - 1, 2));
            }
        }
        private void CreateChart()
        {
            chart = new Chart();
            chart.Parent = this;
            chart.SetBounds(0, 0, ClientSize.Width, ClientSize.Height);
            ChartArea area = new ChartArea();
            area.Name = "myGraph";
            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;
            area.AxisX.MajorGrid.Interval = Step;
            chart.ChartAreas.Add(area);
            Series series1 = new Series();
            series1.ChartArea = "myGraph";
            series1.ChartType = SeriesChartType.Spline;
            series1.BorderWidth = 3;
            series1.LegendText = "Задание №14";
            chart.Series.Add(series1);
            Legend legend = new Legend();
            chart.Legends.Add(legend);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChart();
            CalcFunction();
            chart.Series[0].Points.DataBindXY(x, y);
        }
    }
}
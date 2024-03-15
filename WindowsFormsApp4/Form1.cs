using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        private Random rand = new Random(0);
        private double[] RandomWalk(int points = 5, double start = 100, double mult = 50)
        {
            // return an array of difting random numbers
            double[] values = new double[points];
            values[0] = start;
            for (int i = 1; i < points; i++)
                values[i] = values[i - 1] + (rand.NextDouble() - .5) * mult;
            return values;
        }

        public Form1()
        {
            InitializeComponent();
            // generate some random XY data
            int pointCount = 1_000;
            double[] xs1 = RandomWalk(pointCount);
            double[] ys1 = RandomWalk(pointCount);
            double[] xs2 = RandomWalk(pointCount);
            double[] ys2 = RandomWalk(pointCount);
            // create the model and add the lines to it
            var model = new OxyPlot.PlotModel
            {
                Title = $"Scatter Plot ({pointCount:N0} points each)"
            };
            for (int i = 0; i < 2, i++)
            {
                var line = new OxyPlot.Series.LineSeries()
                {
                    Title = $"Series 1",
                    Color = OxyPlot.OxyColors.Undefined,
                    StrokeThickness = 1,
                    MarkerSize = 2,
                    MarkerType = OxyPlot.MarkerType.Circle
                };
                for (int i = 0; i < pointCount; i++)
                {
                    line.Points.Add(new OxyPlot.DataPoint(xs1[i], ys1[i]));
                }
                model.Series.Add(line);
            }

            // load the model into the user control
            plotView1.Model = model;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Wpf;
using OxyPlot.Axes;

using CsvHelper;
using System.Collections;
using System.IO;
using System.Globalization;

namespace Project2
{
    public partial class Form1 : Form
    {
        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );*/

        private List<Student> students;

        private void UpdateTable()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("surname", "Surname");
            dataGridView1.Columns.Add("group", "Group");
            dataGridView1.Columns.Add("performance", "Performance");
            dataGridView1.Columns.Add("averageperformance", "Average Performance");
            foreach (Student student in students)
            {
                dataGridView1.Rows.Add(student.Name, student.Surname, student.Group, string.Join(",", student.AcademicPerformance), student.averageValue());
            }
        }


        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            students = new List<Student> { 
                new Student("Lana", "Noble", "1"), 
                new Student("Alayah", "Fields", "2"),
                new Student("Scout", "Villa", "1"),
                new Student("Malia", "Morse", "2"),
                new Student("Mae", "Miller", "1"),
                new Student("Anaya", "Vasquez", "2"),
                new Student("Maria", "Johnson", "1")
            };

            UpdateTable();
            plotView1.Model = ScatterPlot();
        }

        private PlotModel ScatterPlot()
        {
            List<OxyPlot.Series.Series> list = new List<OxyPlot.Series.Series>();
            foreach (Student student in students)
            {
                var line = new OxyPlot.Series.LineSeries()
                {
                    Title = student.Name,
                    Color = GetRandomColor(),
                    StrokeThickness = 1,
                    MarkerSize = 2,
                    MarkerType = OxyPlot.MarkerType.Circle
                };
                for (int i = 0; i < 50; i++)
                {
                    line.Points.Add(new OxyPlot.DataPoint(i, student.AcademicPerformance[i]));
                }
                list.Add(line);
                Console.WriteLine(student.AcademicPerformance[0]);
            }
            var model = new OxyPlot.PlotModel
            {
                Title = $"Scatter Plot"
            };
            var l = new Legend
            {
                LegendPlacement = LegendPlacement.Inside,
                LegendPosition = LegendPosition.RightTop,
                LegendBackground = OxyColor.FromAColor(200, OxyColors.White),
                LegendBorder = OxyColors.Black,
            };
            model.Legends.Add(l);
            foreach (OxyPlot.Series.Series series in list)
            {
                model.Series.Add(series);
            }
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                AbsoluteMaximum = 5.5,
                AbsoluteMinimum = 0,
            });
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                AbsoluteMaximum = 50,
                AbsoluteMinimum = 0,
            });
            model.ResetAllAxes();
            return model;
        }

        private OxyColor GetRandomColor()
        {
            var fields = typeof(OxyColors).GetFields();
            return (OxyColor)fields[IntUtil.Random(0, fields.Length - 1)].GetValue(null);
        }

        private void plotAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            plotView1.Model = ScatterPlot();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 dialogForm = new Form2())
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    students.Add(dialogForm.getRes());
                }
                dialogForm.Close();
            }
            UpdateTable();
            plotView1.Model = ScatterPlot();
        }

        private string fileNmae = null;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            students = new List<Student>();
            fileNmae = openFileDialog.FileName;
            var lines = File.ReadLines(fileNmae);
            foreach (var line in lines)
            {
                string[] slist = line.Split(';');
                Student student = new Student(slist[0], slist[1], slist[2]);
                students.Add(student);
            }
            UpdateTable();
            plotView1.Model = ScatterPlot();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            string s = "";
            foreach(Student student in students)
            {
                s += student.Name + ";" + student.Surname + ";" + student.Group + "\n";
            }
            File.AppendAllText(sfd.FileName + ".csv", s);
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students = new List<Student>();
            UpdateTable();
            plotView1.Model = ScatterPlot();
        }
    }
}

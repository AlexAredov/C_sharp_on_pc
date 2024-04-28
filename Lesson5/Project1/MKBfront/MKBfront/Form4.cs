using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Annotations;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace MKBfront
{
    public partial class Form4 : Form
    {
        List<Patient> patients;
        public Form4(List<Patient> patients1)
        {
            InitializeComponent();
            patients = patients1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<String> num;
            if (comboBox1.Text.Equals("Больезнь по МКБ"))
            {
                num = (from pat in patients select pat.MKBnumber).Distinct();
                var dictionary = new Dictionary<string, int>();
                foreach (String cityString in num)
                {
                    dictionary.Add(cityString, 0);
                }
                foreach (Patient pat in patients)
                {
                    dictionary[pat.MKBnumber] += 1;
                }
                chart1.Series["Series1"].Points.DataBindXY(dictionary.Keys, dictionary.Values);
                chart1.Refresh();
            } else if (comboBox1.Text.Equals("Город"))
            {
                num = (from pat in patients select pat.City).Distinct();
                var dictionary = new Dictionary<string, int>();
                foreach (String cityString in num)
                {
                    dictionary.Add(cityString, 0);
                }
                foreach (Patient pat in patients)
                {
                    dictionary[pat.City] += 1;
                }
                chart1.Series["Series1"].Points.DataBindXY(dictionary.Keys, dictionary.Values);
                chart1.Refresh();
            } else if (comboBox1.Text.Equals("Страна"))
            {
                num = (from pat in patients select pat.Country).Distinct();
                var dictionary = new Dictionary<string, int>();
                foreach (String cityString in num)
                {
                    dictionary.Add(cityString, 0);
                }
                foreach (Patient pat in patients)
                {
                    dictionary[pat.Country] += 1;
                }
                chart1.Series["Series1"].Points.DataBindXY(dictionary.Keys, dictionary.Values);
                chart1.Refresh();
            } else if (comboBox1.Text.Equals("Пол"))
            {
                num = (from pat in patients select pat.Gender).Distinct();
                var dictionary = new Dictionary<string, int>();
                foreach (String cityString in num)
                {
                    dictionary.Add(cityString, 0);
                }
                foreach (Patient pat in patients)
                {
                    dictionary[pat.Gender] += 1;
                }
                chart1.Series["Series1"].Points.DataBindXY(dictionary.Keys, dictionary.Values);
                chart1.Refresh();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            IEnumerable<String> num = (from pat in patients select pat.Country).Distinct();
            var dictionary = new Dictionary<string, int>();
            foreach (String cityString in num)
            {
                dictionary.Add(cityString, 0);
            }
            foreach (Patient pat in patients)
            {
                dictionary[pat.Country] += 1;
            }
            chart1.Series["Series1"].Points.DataBindXY(dictionary.Keys, dictionary.Values);
        }
    }
}

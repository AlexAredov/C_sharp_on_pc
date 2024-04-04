using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        Data date1;
        Data date2;
        int days;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            date1 = new Data();
            textBox1.Text = date1.Day.ToString();
            textBox2.Text = date1.Month.ToString();
            textBox3.Text = date1.Year.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            date2 = new Data();
            textBox5.Text = date2.Day.ToString();
            textBox6.Text = date2.Month.ToString();
            textBox7.Text = date2.Year.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            date1 = new Data(
                Convert.ToInt32(textBox1.Text), 
                Convert.ToInt32(textBox2.Text), 
                Convert.ToInt32(textBox3.Text));
            days = Convert.ToInt32(textBox4.Text);
            Data data = date1 + days;
            textBox8.Text = data.Conv();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            date1 = new Data(
                Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text),
                Convert.ToInt32(textBox3.Text));
            date2 = new Data(
                Convert.ToInt32(textBox5.Text),
                Convert.ToInt32(textBox6.Text),
                Convert.ToInt32(textBox7.Text));
            int data = date1 - date2;
            textBox9.Text = Math.Abs(data).ToString();
        }
    }
}

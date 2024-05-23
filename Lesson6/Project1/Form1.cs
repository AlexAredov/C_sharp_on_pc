using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Numbers numbers;

        private void button1_Click(object sender, EventArgs e)
        {
            numbers = new Numbers(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label2.Text = numbers.Min();
            label2.Text += "\n" + numbers.Contains(textBox2.Text);
            if (textBox2.Text.Contains(','))
            {
                label2.Text += "\n" + "с плавающей точкой";
            }
            else if (textBox2.Text.Contains('@'))
            {
                label2.Text += "\n" + "символьное";
            }
            else
            {
                label2.Text += "\n" + "целое";
            }
            
        }
    }
}

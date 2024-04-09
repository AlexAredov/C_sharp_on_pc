using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            char start;
            char finish;
            try
            {
                start = Convert.ToChar(textBox2.Text);
                if (!char.IsLetter(start))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input: start");
                return;
            }

            try
            {
                finish = Convert.ToChar(textBox3.Text);
                if (!char.IsLetter(finish))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input: finish");
                return;
            }

            string st = textBox1.Text;
            Regex regex = new Regex(start+@"\w*"+finish);
            MatchCollection matches = regex.Matches(st);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    label3.Text += match.Value + "\n";
            }
            else
            {
                label3.Text = "Совпадений не найдено";
            }
        }
    }
}

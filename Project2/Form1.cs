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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            try
            {
                s = textBox1.Text;
            }
            catch (Exception)
            {
                return;
            }
            label1.Text = "Заглавных: " + s.Count(m => char.IsUpper(m)).ToString() + "\nСтрочных: " + s.Count(m => char.IsLower(m)).ToString();
        }
    }
}

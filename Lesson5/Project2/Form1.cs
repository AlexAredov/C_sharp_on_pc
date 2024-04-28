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
        unsafe
        public int f(int* m1, int* m0, int n)
        {
            *m0 = int.Parse(n.ToString()[n.ToString().Length - 1].ToString());
            *m1 = int.Parse(n.ToString()[0].ToString());
            Console.WriteLine(n.ToString()[n.ToString().Length - 1]);
            Console.WriteLine(n.ToString()[0]);
            return n;
        }

        unsafe
        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            try
            {
                int start = 0;
                int end = 0;
                num = Math.Abs(int.Parse(textBox1.Text));
                num = f(&start, &end, num);
                label1.Text = start.ToString() + " " + end.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}

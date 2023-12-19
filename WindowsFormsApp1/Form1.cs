using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Мак, гак, как, лок, гуг, лвмлмлмл, мствао, ламла, тмао, ккккглоао

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            String[] arr = str.Replace(" ", "").ToLower().Split(',');
            for(int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Equals("мак"))
                {
                    label1.Text += arr[i] + ", ";
                }
                if (arr[i].Length == 3)
                {
                    label3.Text += arr[i] + ", ";
                }
                label4.Text += arr[i][arr[i].Length - 1];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arr = textBox1.Text.Split('\n');
            String[,] matrix_a = new String[6,6];
            for (int i = 0; i < arr.Length; i++)
            {
                String[] arr1 = arr[i].Split();
                for (int j = 0; j < arr1.Length; j++)
                {
                    matrix_a[i, j] = arr1[j];
                }
            }

            arr = textBox2.Text.Split('\n');
            String[,] matrix_b = new String[5, 5];
            for (int i = 0; i < arr.Length; i++)
            {
                String[] arr1 = arr[i].Split();
                for (int j = 0; j < arr1.Length; j++)
                {
                    matrix_a[i, j] = arr1[j];
                }
            }

            int ind = 5;
            for (int j = 0; j < 5; j++)
            {
                if (matrix_a[0, j] != matrix_b[0, j])
                {
                    ind = j;
                }
            }
        }
    }
}

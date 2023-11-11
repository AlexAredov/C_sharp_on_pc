using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Project4
{
    public partial class Form1 : Form
    {
        private int[] arr;
        private int predel_summa;
        public Form1()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (numbers.Text.Length > 0 && pred_summa.Text.Length > 0)
            {
                arr = numbers.Text.Replace(" ", "").Split(',')?.Select(Int32.Parse)?.ToArray();
                predel_summa = Convert.ToInt32(pred_summa.Text);
                int suma = 0;
                int k = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (suma + arr[i] < predel_summa)
                    {
                        suma += arr[i];
                        k++;
                    }
                }
                summa.Text = suma.ToString();
                neel.Text = (arr.Length - k).ToString();
            }
        }
    }
}

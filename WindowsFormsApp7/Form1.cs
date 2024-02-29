using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string BinaryCode = Convert.ToString(Math.Abs(Convert.ToUInt32(s)), 2);
            label1.Text = BinaryCode;
            string y = BinaryCode;
            if (BinaryCode.Length != 7)
            {
                if (BinaryCode.Length > 7)
                {
                    y = Convert.ToString(Convert.ToUInt32(s) >> (BinaryCode.Length - 7), 2);
                    label1.Text += "\n" + y + " >> " + (BinaryCode.Length - 7).ToString();
                }
                else
                {
                    y = Convert.ToString(Convert.ToUInt32(s) << (7 - BinaryCode.Length), 2);
                    label1.Text += "\n" + y + " << " + (7 - BinaryCode.Length).ToString();
                }
            }
            BinaryCode = y;
            uint nol = Convert.ToUInt32(BinaryCode, 2) >> BinaryCode.Length - 1;
            nol = nol << BinaryCode.Length - 1;
            label1.Text += "\n" + Convert.ToString(nol, 2) + " *Сделали ноль*";
            for (int i = 1; i < BinaryCode.Length; i++)
            {
                if (BinaryCode[i].Equals('0'))
                {
                    BinaryCode = Convert.ToString(Convert.ToUInt32(BinaryCode, 2) + (nol >> i), 2);
                    label1.Text += "\n" + BinaryCode + " + " + " nol >> " + i.ToString();
                }
            }
            label1.Text += "\n" + BinaryCode;
        }
    }
}

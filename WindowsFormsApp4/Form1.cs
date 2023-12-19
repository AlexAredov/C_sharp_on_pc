using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string obrat(string norm)
        {
            char[] arr = norm.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private string solve(string s)
        {
            s = s + "a";
            string st = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Equals('-') && char.IsDigit(s[i+1]))
                {
                    st = st + "-";
                }
                else if (char.IsDigit(s[i]))
                {
                    st = st + s[i].ToString();
                    if (!char.IsDigit(s[i + 1]) && i + 1 != s.Length-1)
                    {
                        st = st + ",";
                    }
                }
            }
            return st;
        }

        private string perevod(int temp, int ff)
        {
            bool f = temp < 0;
            temp = Math.Abs(temp);
            int temp1 = 0;
            string s = "";
            while (temp > 0)
            {
                temp1 = temp % 2;
                temp = temp / 2;
                s += temp1;
            }
            string st = s;
            s = obrat(s);
            if (s.Length > 7)
            {
                return "Ошибка переполнения";
            }
            for (int i = s.Length; i < 7; i++)
            {
                st += "0";
            }
            s = obrat(st);
            if (f)
            {
                s = s.Replace("1", "t").Replace("0", "1").Replace("t", "0");
                int t = Convert.ToInt32(s, 2) + 1;
                s = perevod(t, 0);
                s = "1" + s;
                ff = 0;
            }
            if (ff == 1)
            {
                s = "0" + s;
            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string[] res = solve(s).Split(',');
            int[] arr = new int[res.Length];
            string sss = "";
            string binar = "";
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] != "")
                {
                    arr[i] = Convert.ToInt32(res[i]);
                    binar = binar + perevod(arr[i], 1) + " ";
                    sss = sss + arr[i].ToString() + " ";
                }
            }
            label1.Text = sss;
            label2.Text = binar;
            label3.Text = arr.Sum().ToString();
            label4.Text = arr.Max() + " " + arr.Min();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Project3
{
    public partial class Form1 : Form
    {
        string month = "января";
        string day = "понедельник";
        string[] days = { "воскресенье", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота" };
        public Form1()
        {
            InitializeComponent();
            label4.Text = month + "  это - " + day;
        }

        private string select_day(int firstDay, int Today)
        {
            int num_day = firstDay + Convert.ToInt32(Today % 7);
            if (num_day >= 7)
            {
                return days[num_day - 7];
            }
            else
            {
                return days[num_day];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBox1.SelectedItem.Equals("апреля") || comboBox1.SelectedItem.Equals("июня") 
                || comboBox1.SelectedItem.Equals("сентября") || comboBox1.SelectedItem.Equals("ноября"))
            {
                numericUpDown1.Maximum = 30;
            }
            else if (comboBox1.SelectedItem.Equals("января") || comboBox1.SelectedItem.Equals("марта") 
                || comboBox1.SelectedItem.Equals("мая") || comboBox1.SelectedItem.Equals("июля") 
                || comboBox1.SelectedItem.Equals("августа") || comboBox1.SelectedItem.Equals("октября") 
                || comboBox1.SelectedItem.Equals("декабря"))
            {
                numericUpDown1.Maximum = 31;
            }
            else if (comboBox1.SelectedItem.Equals("февраля"))
            {
                numericUpDown1.Maximum = 28;
            }
            else
            {
                numericUpDown1.Maximum = 1;
            }*/
            month = (string)comboBox1.SelectedItem;
            label4.Text = month + "  это - " + day;
            switch (comboBox1.SelectedItem)
            {
                case "января":
                    numericUpDown1.Maximum = 31;
                    break;
                case "февраля":
                    numericUpDown1.Maximum = 28;
                    break;
                case "марта":
                    numericUpDown1.Maximum = 31;
                    break;
                case "апреля":
                    numericUpDown1.Maximum = 30;
                    break;
                case "мая":
                    numericUpDown1.Maximum = 31;
                    break;
                case "июня":
                    numericUpDown1.Maximum = 30;
                    break;
                case "июля":
                    numericUpDown1.Maximum = 31;
                    break;
                case "августа":
                    numericUpDown1.Maximum = 31;
                    break;
                case "сентября":
                    numericUpDown1.Maximum = 30;
                    break;
                case "октября":
                    numericUpDown1.Maximum = 31;
                    break;
                case "ноября":
                    numericUpDown1.Maximum = 30;
                    break;
                case "декабря":
                    numericUpDown1.Maximum = 31;
                    break;
                default:
                    numericUpDown1.Maximum = 1;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            day = select_day(comboBox2.SelectedIndex, Convert.ToInt32(numericUpDown1.Value % 7));
            label4.Text = month + "  это - " + day;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            day = select_day(comboBox2.SelectedIndex, Convert.ToInt32(numericUpDown1.Value % 7));
            label4.Text = month + "  это - " + day;
        }
    }
}

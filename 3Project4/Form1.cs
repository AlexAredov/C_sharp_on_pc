using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double HbHt(double hb, double ht)
        {
            return (hb / ht) * 100;
        }

        private void render(Label label, double res)
        {
            if (res >= 31 && res <= 38)
            {
                label.Text = "Результат является нормой";
            }
            else
            {
                if (res < 31)
                {
                    label.Text = "Результат является абсолютной гиперхромией";
                }
                else
                {
                    label.Text = "Результат является абсолютной гипохромией";
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double res = HbHt((double)numericUpDown2.Value, (double)numericUpDown3.Value);
            textBox1.Text = Convert.ToString(res);
            render(label8, res);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double res = HbHt((double)numericUpDown2.Value, (double)numericUpDown3.Value);
            textBox1.Text = Convert.ToString(res);
            render(label8, res);
        }
    }
}

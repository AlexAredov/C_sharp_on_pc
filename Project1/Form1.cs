using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.Equals("комплексное"))
            {
                textBox1.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                textBox6.Visible = false;
                flag = 0;
            }
            else if (comboBox3.SelectedItem.Equals("действительное"))
            {
                textBox6.Visible = true;
                textBox1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;
                label3.Visible = false;
                comboBox2.SelectedItem = "комплексное";
                flag = 1;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.Equals("комплексное"))
            {
                textBox4.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                textBox5.Visible = false;
                flag = 0;
            }
            else if (comboBox2.SelectedItem.Equals("действительное"))
            {
                textBox5.Visible = true;
                textBox4.Visible = false;
                label5.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                comboBox3.SelectedItem = "комплексное";
                flag = 2;
            }
        }

        private Complex OperCompNum(Complex num1, Complex num2)
        {
            switch (comboBox1.SelectedItem)
            {
                case "+":
                    return OperComplexNum.Addition(num1, num2);
                case "-":
                    return OperComplexNum.Subtraction(num1, num2);
                case "*":
                    return OperComplexNum.Multiplication(num1, num2);
                case "/":
                    return OperComplexNum.Division(num1, num2);
                default:
                    return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                double Re_num1 = Convert.ToDouble(textBox1.Text);
                double Im_num1 = Convert.ToDouble(textBox2.Text);
                Complex num1 = new Complex(Re_num1, Im_num1);
                double Re_num2 = Convert.ToDouble(textBox4.Text);
                double Im_num2 = Convert.ToDouble(textBox3.Text);
                Complex num2 = new Complex(Re_num2, Im_num2);

            }
            else if(flag == 1)
            {

            }
            else
            {

            }
        }
    }
}

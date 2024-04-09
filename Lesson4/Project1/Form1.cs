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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PEDROOOO dialogForm = new PEDROOOO())
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                dialogForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num;
            try
            {
                num = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                return;
            }
            Circle circle = new Circle(num);
            Square square = new Square(num);
            Triangle triangle = new Triangle(num);
            label1.Text = "Circle: \n" + " perimeter: " + circle.perimeter().ToString() + "\n square: " + circle.square().ToString() +
                "\nSquare: \n" + " perimeter: " + square.perimeter().ToString() + "\n square: " + square.square().ToString() +
                "\nTriangle: \n" + " perimeter: " + triangle.perimeter().ToString() + "\n square: " + triangle.square().ToString();
        }
    }
}

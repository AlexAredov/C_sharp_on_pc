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
        Pharmacy[] pharmacies = new Pharmacy[]
{
                new Drug("Сиофор", "Германия", "Да", "2025"),
                new Drug("Предуктал МБ", "Индия", "Нет", "2024"),
                new Annotation("Диосмин", "Россия", "Диосмин", "1000", "30"),
                new ElectronicResource("Дигоксин", "Россия", "Сердечная недостаточность")
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                for (int i = 0; i < pharmacies.Length; i++)
                {
                    textBox1.Text += pharmacies[i].Display().Replace("\n", Environment.NewLine) + Environment.NewLine;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pharmacies.Length; i++)
            {
                if (textBox2.Text.Equals(pharmacies[i].Name))
                {
                    textBox3.Text += pharmacies[i].Display().Replace("\n", Environment.NewLine) + Environment.NewLine;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Student getRes()
        {
            return new Student(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox6.Enabled = false;
            textBox5.Enabled = false;
            textBox4.Enabled = false;
            textBox8.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public List<Pharmacy> getRes()
        {
            List<Pharmacy> pharmacies = new List<Pharmacy>();
            if (checkBox1.Checked)
            {
                pharmacies.Add(new Drug(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), textBox3.Text));
            }
            if (checkBox2.Checked)
            {
                pharmacies.Add(new Annotation(textBox1.Text, textBox2.Text, textBox6.Text, textBox5.Text, textBox4.Text));
            }
            if (checkBox3.Checked)
            {
                pharmacies.Add(new ElectronicResource(textBox1.Text, textBox2.Text, textBox8.Text));
            }
            return pharmacies;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox6.Enabled = true;
                textBox5.Enabled = true;
                textBox4.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox8.Enabled = true;
            }
        }
    }
}

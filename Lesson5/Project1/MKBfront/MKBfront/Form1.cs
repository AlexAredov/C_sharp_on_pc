using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MKBfront
{
    public partial class Form1 : Form
    {
        private static HttpClient client = new HttpClient();
        DataTable dtSales = new DataTable();
        string url_start = "http://:8080";
        List<Patient> items;


        public Form1()
        {
            InitializeComponent();
        }

        private async void Update()
        {
            var url = url_start + "/patient/all";
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            items = JsonConvert.DeserializeObject<List<Patient>>(content);
            foreach (Patient patient in items)
            {
                if (patient.Gender.Equals("1"))
                {
                    patient.Gender = "жен";
                }
                else
                {
                    patient.Gender = "муж";
                }
                var response1 = await client.GetAsync(url_start + "/MKB/" + patient.MKBnumber);
                var content1 = await response1.Content.ReadAsStringAsync();
                if (!content1.Equals("Disease not found"))
                {
                    var name = JsonConvert.DeserializeObject<MKB>(content1);
                    patient.MKBname = name.ICD_code;
                }
                else
                {
                    patient.MKBname = "NaN";
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                string json = JsonConvert.SerializeObject(items);
                dtSales = JsonConvert.DeserializeObject<DataTable>(json);
                dataGridView1.DataSource = dtSales;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var url = url_start + "/patient/all";
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            items = JsonConvert.DeserializeObject<List<Patient>>(content);
            foreach (Patient patient in items)
            {
                if (patient.Gender.Equals("1"))
                {
                    patient.Gender = "жен";
                }
                else
                {
                    patient.Gender = "муж";
                }
                var response1 = await client.GetAsync(url_start + "/MKB/" + patient.MKBnumber);
                var content1 = await response1.Content.ReadAsStringAsync();
                if (!content1.Equals("Disease not found"))
                {
                    var name = JsonConvert.DeserializeObject<MKB>(content1);
                    patient.MKBname = name.ICD_code;
                }
                else
                {
                    patient.MKBname = "NaN";
                }
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            string json = JsonConvert.SerializeObject(items);
            dtSales = JsonConvert.DeserializeObject<DataTable>(json);
            dataGridView1.DataSource = dtSales;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Name", textBoxName.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Surname", textBoxSurname.Text);
        }

        private void textBoxSecSur_TextChanged(object sender, EventArgs e)
        {
            dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "SecondSurname", textBoxSecSur.Text);
        }

        private void textBoxMKBnum_TextChanged(object sender, EventArgs e)
        {
            dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "MKBnumber", textBoxMKBnum.Text);
        }

        private void textBoxMKBname_TextChanged(object sender, EventArgs e)
        {
            dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "MKBname", textBoxMKBname.Text);
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "City", textBoxCity.Text);
        }

        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
            dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Country", textBoxCountry.Text);
        }

        private void textBoxGender_TextChanged(object sender, EventArgs e)
        {
            dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Gender", textBoxGender.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (Form2 dialogForm = new Form2(items[dataGridView1.CurrentCell.RowIndex]))
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    Update();
                }
                dialogForm.Close();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            using (Form3 dialogForm = new Form3())
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    Update();
                }
                dialogForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form4 dialogForm = new Form4(items))
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    Update();
                }
                dialogForm.Close();
            }
        }
    }
}

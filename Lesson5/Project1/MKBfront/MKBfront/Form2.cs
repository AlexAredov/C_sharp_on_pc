using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKBfront
{
    public partial class Form2 : Form
    {
        private static HttpClient client = new HttpClient();
        string url_start = "http://:8080";
        List<MKB> items;
        List<string> stritems = new List<string>();
        Patient patient;

        public Form2(Patient pat)
        {
            InitializeComponent();
            patient = pat;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            var url = url_start + "/MKB/all";
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            items = JsonConvert.DeserializeObject<List<MKB>>(content);
            InitializeComboBox();
            textBoxName.Text = patient.Name;
            textBoxSurname.Text = patient.Surname;
            textBoxSecondSurname.Text = patient.SecondSurname;
            textBoxCity.Text = patient.City;
            textBoxCountry.Text = patient.Country;
            if(patient.Gender == "0")
            {
                comboBoxGender.Text = "муж";
            }
            else
            {
                comboBoxGender.Text = "жен";
            }
            dateTimePicker1.Value = DateTime.ParseExact(patient.DateOfBirth, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            comboBox1.Text = patient.MKBnumber + patient.MKBname;
        }


        private async void InitializeComboBox()
        {
            
            foreach (var item in items)
            {
                if(item.ICD_code != null)
                {
                    stritems.Add(item.Disease_name + " " + item.ICD_code);
                }
                
            }

            comboBox1.DataSource = stritems;
            comboBox1.Text = "";
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty)
            {
                comboBox1.DataSource = stritems;
                comboBox1.Text = "";
            }
            else
            {
                string tempStr = comboBox1.Text;
                IEnumerable<String> data = (from m in stritems where m.Contains(tempStr) select m);

                comboBox1.DataSource = null;
                comboBox1.Items.Clear();

                foreach (var temp in data)
                {
                    comboBox1.Items.Add(temp);
                }
                comboBox1.DroppedDown = true;
                Cursor.Current = Cursors.Default;

                comboBox1.Text = tempStr;
                comboBox1.Select(comboBox1.Text.Length, 0);

            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r') return;

            if (this.ActiveControl != null)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
            e.Handled = true; // Mark the event as handled
        }

        private async void buttonDone_Click(object sender, EventArgs e)
        {
            var method = new HttpMethod("PATCH");
            int gen = 1;
            if(comboBoxGender.Text == "муж")
            {
                gen = 0;
            }
            /*Console.WriteLine(url_start + "/update/" + id +
                "?name=" + textBoxName.Text +
                "&surname=" + textBoxSurname.Text +
                "&secondsurname=" + textBoxSecondSurname.Text +
                "&country=" + textBoxCountry.Text +
                "&city=" + textBoxCity.Text +
                "&dateofbirth=" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                "&gender=" + gen.ToString() +
                "&mkbnumber=" + comboBox1.Text.Split(' ')[0]);*/
            var request = new HttpRequestMessage(method, url_start + "/update/" + patient.Id + 
                "?name=" + textBoxName.Text +
                "&surname=" + textBoxSurname.Text +
                "&secondsurname=" + textBoxSecondSurname.Text +
                "&country=" + textBoxCountry.Text +
                "&city=" + textBoxCity.Text +
                "&dateofbirth=" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                "&gender=" + gen.ToString() +
                "&mkbnumber=" + comboBox1.Text.Split(' ')[0]);

            HttpResponseMessage response = new HttpResponseMessage();
            response = await client.SendAsync(request);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var method = new HttpMethod("GET");
            var request = new HttpRequestMessage(method, url_start + "/delete/" + patient.Id);

            HttpResponseMessage response = new HttpResponseMessage();
            response = await client.SendAsync(request);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

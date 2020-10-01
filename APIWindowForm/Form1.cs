/*Author: Lam Nguyen
 * Date: 10/01/2020
 * Description: Create a WPF to read and Insert data through API
 */
using DTO_WindowForm_API.JsonParseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIWindowForm
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            JsonObject jsonobject = new JsonObject();
            var persons = jsonobject.Get();
            if (persons != null)
            {
                dataGridView1.DataSource = persons;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            JsonObject jsonobject = new JsonObject();
            HttpResponseMessage response = jsonobject.Post(textBox1.Text, textBox2.Text, textBox3.Text);
            if (response.IsSuccessStatusCode)

            {

                MessageBox.Show("Employee Added");

                textBox1.Text = "";

                textBox2.Text = "";

                textBox3.Text = "";

                var persons = jsonobject.Get();
                if (persons != null)
                {
                    dataGridView1.DataSource = persons;
                }


            }

            else

            {

                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);

            }

        }
    }
}

/*
 * Author: Lam Nguyen
 * Created Data 09/14/2020
 * Desciption: Create connection and a form to input data into the database
 */
using DTO.Data;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataBaseWindowForm
{

    public partial class InputDatabaseForm : Form
    {
       
        public InputDatabaseForm()
        {
            InitializeComponent();
        }
        //DTO-WPF data
        private void button1_Click(object sender, EventArgs e)
        {//Open Connection
            Person person = new Person();
            person.FirstName = textBox1.Text;
            person.LastName = textBox2.Text;
            person.Phone = textBox3.Text;
            PersonData data = new PersonData();
            data.SavePerson(person);
            MessageBox.Show("Saved");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

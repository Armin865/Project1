/*
 * Author: Lam Nguyen
 * Created Data 09/14/2020
 * Desciption: Create connection and a form to input data into the database
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace DataBaseWindowForm
{

    public partial class InputDatabaseForm : Form
    {
        private SqlCeConnection con = new SqlCeConnection(@"Data Source=..\..\..\ConsoleApp2\App-Data\Person.sdf");

        public InputDatabaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Open Connection
            con.Open();
            //Create a query text to insert data
            string Query = "INSERT INTO [NABA] ([firstname],[lastname]) VALUES (N'" + textBox1.Text + "',N'" + textBox2.Text + "')";
           //Create query command
            SqlCeCommand cmd = new SqlCeCommand(Query, con);
            //Execute query command
            cmd.ExecuteNonQuery();
            //Close Connection
            con.Close();
            MessageBox.Show("Saved");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

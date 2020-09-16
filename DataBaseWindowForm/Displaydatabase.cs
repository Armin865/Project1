/*
 * Author: Lam Nguyen
 * Data:09/16/2020
 * Dscription: Display database into a grid view
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
    public partial class Displaydatabase : Form
    {
        private SqlCeConnection con = new SqlCeConnection(@"Data Source=..\..\..\ConsoleApp2\App-Data\Person.sdf");

        public Displaydatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            //Create query to show data
            SqlCeDataAdapter SQLData = new SqlCeDataAdapter("SELECT * FROM NABA", con);
            //create new table to insert data
            DataTable dttb = new DataTable();
            //Fill the table with data from database
            SQLData.Fill(dttb);
            //Fill the GridView with the datatable
            GridView1.DataSource = dttb;
            //close the connection
            con.Close();

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

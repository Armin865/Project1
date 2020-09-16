/*
 * Author: Lam Nguyen
 * Created Data 09/14/2020
 * Desciption: Create a form to display 2 buttons with insert and display database function
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
    public partial class ShowDatabaseForm : Form
    {   /// <summary>
    // Created Connection then add show database function into button1 and insert database function into button2
    /// </summary>
        private SqlCeConnection con = new SqlCeConnection(@"Data Source=..\..\..\ConsoleApp2\App-Data\Person.sdf");

        public ShowDatabaseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Show database button
private void button1_Click(object sender, EventArgs e)
        {//Open Connection
            Displaydatabase f1 = new Displaydatabase();
            f1.Show();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Show insert form 
        private void button2_Click(object sender, EventArgs e)
        {
            InputDatabaseForm f2 = new InputDatabaseForm();
            f2.Show();

        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

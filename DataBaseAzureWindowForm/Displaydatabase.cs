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
using DTO.Data;
using DTO.Model;

namespace DataBaseWindowForm
{
    public partial class Displaydatabase : Form
    {
        List<Person> people = new List<Person>();
       
        public Displaydatabase()
        {
            InitializeComponent();
            PeopleFoundList.DataSource = people;
            PeopleFoundList.DisplayMember = "FullInfo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //get data from Azure Sql using dapper
            PersonData db = new PersonData();
            //save data to people variable
            people = db.GetPerson();
            //refresh the list box to show the result
            PeopleFoundList.Refresh();
            PeopleFoundList.DataSource = people;
            PeopleFoundList.DisplayMember = "FullInfo";
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Displaydatabase_Load(object sender, EventArgs e)
        {

        }

        private void PeopleFoundList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

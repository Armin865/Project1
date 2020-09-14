using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleApp2

{ 
    class SQLServer
    {
        public SqlCeConnection con;
        public string getFirstName()
        {
            Console.WriteLine("What is your first name?");
            string fname = Console.ReadLine();
            return fname;
        }
        public string getLastName()
        {
            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();
            return lname;
        }
       
        public void InsertDataBase()
        {
            string fname = getFirstName();
            string lname = getLastName();
            con = new SqlCeConnection(@"Data Source=..\..\App-Data\Person.sdf");
            con.Open();
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO [NABA] ([firstname],[lastname]) VALUES (N'"+fname+"',N'"+lname+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            Console.ReadLine();
        }
        public void ReadDataBase()
        {
            con = new SqlCeConnection(@"Data Source=..\..\App-Data\Person.sdf");
            con.Open();
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT firstname, lastname FROM NABA";
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("First Name :"+reader["firstname"].ToString()+", Last Name: "+reader["lastname"].ToString());
            }
            reader.Close();

        }
    }
}

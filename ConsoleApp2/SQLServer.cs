using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Security.Cryptography;
using System.Collections;

namespace ConsoleApp2

{ 
    class SQLServer
    {   //Establish Connection with the Data Base
        private SqlCeConnection con = new SqlCeConnection(@"Data Source=..\..\App-Data\Person.sdf");
        public string getFirstName()//Get the first name
        {
            Console.WriteLine("What is your first name?");
            string fname = Console.ReadLine();
            return fname;
        }
        public string getLastName()//Get the last name
        {
            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();
            return lname;
        }
        public void InsertDataBase(string firstname, string lastname)
        {
           
            //Open the Data Base
            con.Open();
            //Create new Query command
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO [NABA] ([firstname],[lastname]) VALUES (N'" + firstname + "',N'" + lastname + "')";
            //Execute the Insert Query
            cmd.ExecuteNonQuery();
            //After finish the excution, close the connection
            con.Close();
           
        }
        public void InsertDataBase()
        {
            string fname = getFirstName();//save fisrt name 
            string lname = getLastName();//save last name
            
            //Open the Data Base
            con.Open();
            //Create new Query command
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO [NABA] ([firstname],[lastname]) VALUES (N'"+fname+"',N'"+lname+"')";
            //Execute the Insert Query
            cmd.ExecuteNonQuery();
            //After finish the excution, close the connection
            con.Close();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
        public int getLength()
        {   //Open the connection
            con.Open();
            //Create new Query command
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM NABA";
            //Execute Query command
            SqlCeDataReader reader = cmd.ExecuteReader();
            //create an instant to copy the database length
            int count = 0;
            count = (int)cmd.ExecuteScalar();
            //Close the connection
            con.Close();
            return count;

        }
        public Person[] ReadDataBase()
        {   //Open the Data base
            Person[] person = new Person[getLength()];
            var count = 0;
            con.Open();
            //Create new Query command
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT firstname, lastname FROM NABA";
            //Create a reader object to retreive the information from the data base
            SqlCeDataReader reader = cmd.ExecuteReader();
            //Execute reader
            reader = cmd.ExecuteReader();

            //while the reader object read the database
            while (reader.Read())
            {

                person[count] = new Person(reader["firstname"].ToString(), reader["lastname"].ToString());
                count++;
            }
            //close the connection
            reader.Close();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
           
            return person;
        }
    }
}

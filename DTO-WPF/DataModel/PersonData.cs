
//Author: Lam Nguyen
//Date:09/29/2020
//Description: This is the Person container 


using DTO.Internal.SqlDataAccess;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO.Data
{
   public class PersonData
    {
       
        // Get all the record from sql data using dapper
        public List<Person> GetPerson()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<Person, dynamic>("dbo.spPerson_Get", new { }, "DataBase");
            return output;
        }
        // Save record into sql server using dapper
        public void SavePerson(Person person)
        {
            SqlDataAccess sql = new SqlDataAccess();
            sql.SaveData("dbo.spPerson_Save", person, "Database");
        } 
    }
}

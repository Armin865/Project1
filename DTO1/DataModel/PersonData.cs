
//Author: Lam Nguyen
//Date:09/29/2020
//Description: This is the Person container 


using DTO.Internal.SqlDataAccess;
using DTO.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO.Data
{
   public class PersonData
    {
        private readonly IConfiguration _config;

        public PersonData(IConfiguration config)
        {
            _config = config;
        }
        // Get all the record from sql data 
        public List<Person> GetPerson()
        {
            SqlDataAccess sql = new SqlDataAccess(_config);
            var output = sql.LoadData<Person, dynamic>("dbo.spPerson_Get", new { }, "DataBase");
            return output;
        }
        // Save record into sql server
        public void SavePerson(Person person)
        {
            SqlDataAccess sql = new SqlDataAccess(_config);
            sql.SaveData("dbo.spPerson_Save", person, "Database");
        } 
    }
}

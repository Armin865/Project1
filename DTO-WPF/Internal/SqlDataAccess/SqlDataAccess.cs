/*Author: Lam Nguyen
 * Date: 09/29/2020
 * Description: This is the configuration for Sql Server Access withConnectionString from appsettings.json from api 
 * */
using Dapper;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//I use Dapper extension to execute the query in SQL Server
namespace DTO.Internal.SqlDataAccess
{
   public class SqlDataAccess  
    {
        
        //config is the configuration in appsettings.json located in api 
      
        //With the config we will get the connectionstring in the config
        public string GetConnectionString(string name)
        {
            return "Data Source=naba.database.windows.net;Initial Catalog=BeautySignInDev;User ID=ditran;Password=LamSystemData#2020;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString; this is used to get connectionstring with API .NetFramwork
        }
        //This function get data from the SQL Server and return the values
        public List<T> LoadData<T, U>(string storedProcedures, U parameters, string connectionStringName)
        {
            string connectionstring = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                List<T> rows = connection.Query<T>(storedProcedures, parameters,
                    commandType: CommandType.StoredProcedure).ToList();
                return rows;
            }
        }
        //This function Load the data into SQL Server 
        public void SaveData<T>(string storedProcedures, T parameters, string connectionStringName)
        {
            string connectionstring = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                connection.Execute(storedProcedures, parameters, commandType: CommandType.StoredProcedure);
                
            }
        }

    }
}

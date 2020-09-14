/*
 * Author: Lam Nguyen
 * Date: 09-09-20202
 * Description: First input output console app
 *          
 *           - Create excel file, insert and read data from .elxs
 */

//test
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using IronXL;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    class FirstInternshipProject
    {

        static void Main(string[] args)
        {
            SQLServer ServerCompact = new SQLServer();
            ServerCompact.InsertDataBase();
            ServerCompact.ReadDataBase();
            Console.ReadLine();
        }

      
    }

}
/*
 * Author: Lam Nguyen
 * Date: 09-09-20202
 * Description: Execute classes
 *          
 *           
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
            DTO_Controller person = new DTO_Controller();
            person.printData();
        }
    }

}
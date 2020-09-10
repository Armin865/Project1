/*
 * Author: Lam Nguyen
 * Date: 09-09-20202
 * Description: First input output console app
 *          
 *           - Create excel file, insert and read data from .elxs
 */


using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IronXL;

namespace InternshipProject
{
    class FirstInternshipProject
    {

        static void Main(string[] args)
        {
           
            DataIn DataIn1 = new DataIn();
            DataOut Outexcel = new DataOut(2);
            DataIn1.Create();
            DataIn1.WriteData();
            Outexcel.setCount(DataIn1.getCount());
            Console.WriteLine(Outexcel.count);
            Outexcel.Read(2, 2);
            Console.ReadLine();
        }


    }

}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DTO_Person
    {
        SQLServer ServerCompact = new SQLServer();
        Person[] person;
        int count;
       public DTO_Person()
        {   //copy the length of the database
            count = ServerCompact.getLength();
            //create new person object array
            person = new Person[count];
            //Copy all the data from database into person array object
            person = ServerCompact.ReadDataBase();

        }
        public void printData()
        {
            for(var i =0; i < count; i++)
            {
                Console.WriteLine("First Name: " + person[i].firstname + ", Last Name: " + person[i].lastname);
            }
            Console.ReadLine();
        }
    }
}
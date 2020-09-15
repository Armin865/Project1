using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class DTO_Controller
    {
        private SQLServer ServerCompact = new SQLServer();
        private Person[] person;
        int count;
       public DTO_Controller()
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
                Console.WriteLine("Info: "+ person[i]);
            }
            Console.ReadLine();
        }
        public void ExcelDataToDataBase()
        { DataOut Data = new DataOut();
            
            
            Person[] excel = new Person[Data.count];
            excel = Data.ReadAndReturnArray();
            SQLServer DataBase = new SQLServer();
            for(var i = 0; i < Data.count; i++)
            {
                DataBase.InsertDataBase(excel[i].Firstname.ToString(), excel[i].Lastname.ToString());
            }
            Console.WriteLine("Inserted Into Database");
            Console.ReadLine();
        }
    }
}

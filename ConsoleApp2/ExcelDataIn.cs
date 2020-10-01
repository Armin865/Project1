/*Author: Lam Nguyen
 * Date:09/10/2020
 * Desciption: First internship project
 *          Create object to create new Exel file, write data to excel file, insert random string to excel file.
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using IronXL;

namespace ConsoleApp2
{

    class ExcelDataIn
    {
        public int count;
        // Constructor 
        public ExcelDataIn()
        {
            count = 1;
            WorkBook workbook = WorkBook.Load(@"..\..\App-data\Book1.xlsx");
            WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            sheet["A1"].Value = "First name";
            sheet["B1"].Value = "Last name";


        }
        public void Create()//Create new excel file
        {   //Create new workbook
            WorkBook xlsWorkbook = WorkBook.Create(ExcelFileFormat.XLS);
            
            //Add a blank WorkSheet
            WorkSheet xlsSheet = xlsWorkbook.CreateWorkSheet("Sheet1");

            if (!File.Exists(@"..\..\App-data\Book1.xlsx"))
               {
                //Save the excel file
                xlsWorkbook.SaveAs(@"..\..\App-data\Book1.xlsx");
            }
            else
            {
                Console.WriteLine("The File exists already");
            }

        }
      
        public void WriteData()//Insert data to excel file with a signle name
        {   
            string fname, lname;
            Console.WriteLine("What is your first name?");
            fname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lname = Console.ReadLine();
            //Ask for First Name and Last Name
            WorkBook workbook = WorkBook.Load(@"..\..\App-data\Book1.xlsx");//Open the file 
            WorkSheet sheet = workbook.GetWorkSheet("Sheet1");//Open the sheet
            //Initalize first row with First name and Last name labels
            sheet["A1"].Value = "First name";
            sheet["B1"].Value = "Last name";
            //Find the next blank row in the file to insert the name
            while ((sheet["A" + count].Value) != "" && (sheet["B" + count].Value) != "")
            {
                count++;
            }
            //Insert the name in the avalavable row
            sheet["A" + count].Value = fname;
            sheet["B" + count].Value = lname;
            count++;//Keep track of the available row
            workbook.SaveAs(@"..\..\App-data\Book1.xlsx");
        }
        public void WriteData(string fname, string lname)//Helper function to add name with arguments 
        {

                //Open the Excel file
            WorkBook workbook = WorkBook.Load(@"..\..\App-data\Book1.xlsx");
            //Open the Sheet in Excel file
            WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            //Initialize the first row with Values first name and last name
            sheet["A1"].Value = "First name";
            sheet["B1"].Value = "Last name";
            //Find the next available row to insert
            while ((sheet["A" + count].Value) != "" && (sheet["B" + count].Value) != "")
            {
                count++;
            }
            //Insert the name
            sheet["A" + count].Value = fname;
            sheet["B" + count].Value = lname;
            count++;//Increase to keep track of availabe row
            //Save the changes
            workbook.SaveAs(@"..\..\App-data\Book1.xlsx");
        }
        //Write Data to Excel file with multiple times 
        public void WriteData(int times)
        {   //Open the file and the sheet
            WorkBook workbook = WorkBook.Load(@"..\..\App-data\Book1.xlsx");
            WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            //Initalize the first row
            sheet["A1"].Value = "First name";
            sheet["B1"].Value = "Last name";
            
            for (var i = 0; i < times; i++)
            {
                string fname, lname;
                Console.WriteLine("What is your first name?");
                fname = Console.ReadLine();
                Console.WriteLine("What is your last name?");
                lname = Console.ReadLine();

                //Find the next available row 
                while ((sheet["A" + count].Value) != "" && (sheet["B" + count].Value) != "")
                {
                    count++;
                }
                //Insert the data
                sheet["A" + count].Value = fname;
                sheet["B" + count].Value = lname;
                count++;
            }
            //Save the changes
            workbook.SaveAs(@"..\..\App-data\Book1.xlsx");
        }
      
        public string Randomstring(int charLength)//Create a random string, this is a helper function
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[charLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
        public void insertRandomString(int length, int charLength)//Insert the value of randomstring function to the data
        {

            for (var i = 0; i < length; i++)
            {
                WriteData(Randomstring(charLength), Randomstring(charLength));

            }
        }
    }
}


          


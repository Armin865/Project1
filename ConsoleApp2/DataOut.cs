/* Author: Lam Nguyen
 * Data:09/10/2020
 * Desciption: Read the Excel file from an existing path
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
    class DataOut
    {
        public int count;
        public DataOut(int count)//Constructor
        {
            this.count = count;
        }
        public void setCount(int count)//set count to keep track of row
        {
            this.count = count;
        }
        public void Read()//Output the everything in the excel file
        {
            WorkBook workbook = WorkBook.Load(@"C:\Users\Lam Nguyen\Desktop\FileIo\Book1.xlsx");
            WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            for (var i = 2; i < count; i++)
            {
                Console.WriteLine("First name: {0} , Last name: {1}", sheet["A" + i].Value, sheet["B" + i].Value);
            }
            // Console.ReadLine();
            //Reset current row back to the top
            this.count = 0;
        }
        public void Read(int times, int order)//Output a range of item in the excel file
        {
            WorkBook workbook = WorkBook.Load(@"C:\Users\Lam Nguyen\Desktop\FileIo\Book1.xlsx");
            WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            int i;
            if (count >= order)//Checking if the current seected row is out of range 
            {   
                for (i = 0; i < times; i++)
                {
                    if ((sheet["A" + order].Value) == "" && (sheet["B" + order].Value) == "")
                    {
                        break;//break if we reach an empty row
                    }
                    else
                    {   //Print the data
                        Console.WriteLine("First name: {0} , Last name: {1}", sheet["A" + order].Value, sheet["B" + order].Value);
                        order++;
                    }

                }//end of for loop
               
                Console.WriteLine("Do you want to keep reading next lines:");
                string Ans = Console.ReadLine();//If the user want to keep reading the data
                if (Ans == "yes" && (sheet["A" + order].Value) != "" && (sheet["B" + order].Value) != "")//Checking if the row is not empty and the answer is yes
                {
                    Read(10, order);
                }
                else if ((sheet["A" + order].Value) == "" && (sheet["B" + order].Value) == "")//Checking if the row is empty
                {
                    Console.WriteLine("There is no more");
                }
                else//Exit out 
                {
                    Console.WriteLine("Exit Now");
                }


            }

            //reset the current row back to the top
            this.count = 0;
        }
    }

}

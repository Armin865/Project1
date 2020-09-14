### Author:
---------------
###  Lam Nguyen 
###  The first co-op rotation 
####  Objective:
 	  Practice object oriented programming with C#
  	 Practice writing document follow guildline.
 #### Product:
  	 Three objects : DataIn, DataOut,SQLServer
----------------
#### Functions:
	      DataIn: int count, DataIn(), Create(),  WriteData(), WriteData(string, string), WriteData(int),  getCount(), Randomstring(int), insertRandomString(int, int).
	      DataOut:  int count, DataOut(int), setCount(int), Read(), Read(int, int).
		  SQLServer: string con,InsertDataBase(),ReadDataBase().
----------------------
	DataIn Object: 
 - int count: keep track of the current row in excel
 - DataIn(): initalize the first row with "First name" and "Last name"
 - Create(): create a new excel file in the data folder
 - WriteData(), WriteData(string,string) and Writedata(int): have the same functionality to insert new data in the excel file, WriteData only take data 1 time following with user input for first name and last name, WriteData(string,string) can write data without user input, WriteData(int) is used to ask user input multiple times.
 - getCount(): use to get the number of the current row.
 - Randomstring(int): generate a random string with require the length for the argument of the string and return the string.
 - inserRandomString(int,int): write the random string from the Randomstring() to the excel file with 2 argument  which take the first argument for the number of string to insert and second argument to select the length of the string.
 ---------------
 	DataOut Object:
-  int count: keep track of the current row of the excel.
- DataOut(int): the constructor which takes 1 argument. The argument is to use to keep track of the current row.
- setCount(int): use to set the cursor to the specific row which take 1 argument to set the cursor.
- Read():  prints out the whole list in the excel.
- Read(int, int): prints out the list with specific range. It take 2 arguments. The first argument is for the range and the second argument is for the root position.
----------
	SQLSerer Object:
- string con: Establish the connection string.
- InsertDataBase(): Insert the first name and last name into the data base.
- ReadDataBase(): Retreiving the first name and last name from Database.
----------
	SQL Server Additional Information:
- https://docs.microsoft.com/en-us/previous-versions/sql/compact/sql-server-compact-4.0/ec4st0e3(v=vs.100)
----------
	My experience:
- SQL Server Compact
	- I find SQL Server Compact Edition is very limited with only 4GB and does not have that mnay functions as SQL Server Express.
	- SQL Server Ce(Compact Edition) only have toolbox within Visual Studio IDE to connect with the database.
	- I watched https://www.youtube.com/watch?v=blNb-9vhFLM&t=431s to find the method to insert the data into databse.
	- I also watched https://www.youtube.com/watch?v=rV6kRpYsJZg&t=553s to find the method to read the data from database.
-Excel:
	- https://ironsoftware.com/csharp/excel/examples/read-excel/ 
	- I use IronXL library to read and write data to an exce file.
	- I did not know how to connect to the excel file .
-----------
	Challenge
   - Follow strictly Object Oriented Program
   - Config the right Console App to run the references.
   - Find the right directory to open and save the excel file.
   - Learn Sql Server Compact.
   - Learn Microsoft.Data.SqlServerCe class.
# New American Business Association


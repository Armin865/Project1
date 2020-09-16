### Author:
---------------
###  Lam Nguyen 
###  The first co-op rotation 
####  Objective:
 	  Practice object oriented programming with C#
  	 Practice writing document follow guildline.
 #### Product:
	 Window Forms: ShowDatabaseForm,InputDatabaseForm,Displaydatabase.
  	 ConsoleApp : DataIn, DataOut,SQLServer,DTO_Person,Person
-----------
# ConsoleApp
----------------
#### Functions:
	      DataIn: int count, DataIn(), Create(),  WriteData(), WriteData(string, string), WriteData(int),  getCount(), Randomstring(int), insertRandomString(int, int).
	      DataOut:  int count, DataOut(int), setCount(int), Read(), Read(int, int).
		  SQLServer: string con,InsertDataBase(),ReadDataBase().
----------------------
	DataIn Object: 
 - int count: keep track of the current row in excel
 - DataIn(): initalize the first row with "First name" and "Last name"
 - void Create(): create a new excel file in the data folder
 - void WriteData(),void WriteData(string,string) andvoid  Writedata(int): have the same functionality to insert new data in the excel file, WriteData only take data 1 time following with user input for first name and last name, WriteData(string,string) can write data without user input, WriteData(int) is used to ask user input multiple times.
 - void insertRandomString(int,int): write the random string from the Randomstring() to the excel file with 2 argument  which take the first argument for the number of string to insert and second argument to select the length of the string.
 ---------------
 	DataOut Object:
-  int count: keep track of the current row of the excel.
- DataOut(): Constructor initialize count.
- void setCount(int): use to set the cursor to the specific row which take 1 argument to set the cursor.
- void Read():  prints out the whole list in the excel.
- void Read(int, int): prints out the list with specific range. It take 2 arguments. The first argument is for the range and the second argument is for the root position.
- int getCount(): return the total valued row number.
- void setCount(int): Take one argument that set the number of count.
- Persion[] ReadAndReturnArray(): Retreive data from excel file then return the data in array format.
----------
	SQLSerer Object:
- string con: Establish the connection string.
- void InsertDataBase(): Insert the first name and last name into the data base.
- Person[] ReadDataBase(): Return an array that have all the first name and the last name of the database.
- int getLength(): Return the number of the all the rows.
- string getFirstName(): Ask input then return the input.
- string getLastName(): Ask input the return the input.
----------
	Person Object:
- string firstname, lastname: contain first name and last name.
- Person(): Initialize first name and last name.
------------
	DTO_Person Object:
- SQLServer ServerCompact: Create connection to the database
- Person[] person: array to contain all Person class.
- DTO_Person(): Initilize the person array and copy person array with database row.
- void PrintData(): print the person array with first name and last name.
- void ExcelDataToDataBase(): Insert data from DTO into database.
------------
	SQL Server Additional Information:
- https://docs.microsoft.com/en-us/previous-versions/sql/compact/sql-server-compact-4.0/ec4st0e3(v=vs.100)
----------
	My experience:
- SQL Server Compact
	- I find SQL Server Compact Edition is very limited with only 4GB and does not have that mnay functions as SQL Server Express.
	- SQL Server Ce(Compact Edition) only have toolbox within Visual Studio IDE to connect with the database.
	- I watched https://www.youtube.com/watch?v=blNb-9vhFLM&t=431s to find the method to insert the data into databse.
	- I also watched https://www.youtube.com/watch?v=rV6kRpYsJZg&t=553s to find the method to read the data from database.
	- After finish coding for the sql server compact I have to read about DTO.
---------
- Excel:
	- https://ironsoftware.com/csharp/excel/examples/read-excel/ 
	- I use IronXL library to read and write data to an exce file.
	- I did not know how to connect to the excel file .
------------
- DTO:
	- This is the website with the function count all the row of the db:https://stackoverflow.com/questions/20160928/how-to-count-the-number-of-rows-from-sql-table-in-c#:~:text=You%20need%20to%20make%20a,pass%20below%20query%20as%20commandText.&text=Use%20ExecuteScalar%2FExecuteReader%20to%20get%20the%20returned%20count.
	- I create a DTO blueprint and DTO_Person as a bucket for all the DTOs.
	- All DTOs is created inside the ReadDataBase and return as an array and pass the return array into DTO_Person object.
	- I learn how to move a DTO class into a different project and how to access the class from different project with the keyword public.(https://social.msdn.microsoft.com/Forums/en-US/fa3e311e-0bfe-4838-9688-72b3c1dde13f/how-to-call-another-project-from-a-project-in-the-same-solution?forum=Vsexpressvcs).
	- I can check the data from DTO if it already existed in sql server!(https://stackoverflow.com/questions/20971680/sql-server-insert-if-not-exists).
-----------
	Challenge
   - Follow strictly Object Oriented Program
   - Config the right Console App to run the references.
   - Find the right directory to open and save the excel file.
   - Learn Sql Server Compact.
   - Learn Microsoft.Data.SqlServerCe class.
   - Create DTO object that contains all the first name and last name.
----------
# WindowForm:
	ShowDatabaseForm form:
- Show two buttons to show 2 more forms(Displaydatabase form and InputDatabaseForm form)
--------
	Displaydatabase form:
- Has 1 button to open connection and display the database into a grid view.
--------
	InputDatabaseForm form:
- Has 2 text field to input text.
- 1 button to take the text from 2 text input field and insert it into database.
--------
	My experience:
		Website aobut how to display database:https://www.youtube.com/watch?v=C9s0H6yeFLQ.
		Website about how to insert database:https://www.youtube.com/watch?v=sSBx9_eddmo&t=115s.
		This is my first windowform app. I found out UI can be easily to implement code similar to ConsoleApp code. I noticed that when you create a form and then you create another form inside the same project it wont show the created form that after the original one. To show the second form you have to call it in the first form.

# New American Business Association


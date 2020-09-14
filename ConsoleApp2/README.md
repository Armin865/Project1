### Author:
---------------
###  Lam Nguyen 
###  The first co-op rotation 
####  Objective:
 	  Practice object oriented programming with C#
  	 Practice writing document follow guildline.
 #### Product:
  	 Two object : DataIn, DataOut.
----------------
#### Functions:
	      DataIn: int count, DataIn(), Create(),  WriteData(), WriteData(string, string), WriteData(int),  getCount(), Randomstring(int), insertRandomString(int, int).
	      DataOut:  int count, DataOut(int), setCount(int), Read(), Read(int, int).
----------------------
	DataIn Object: 
 - int count is used to keep track of the current row in excel
 - DataIn() is the constructor which initalize the first row with "First name" and "Last name"
 - Create() can create a new excel file in the data folder
 - WriteData(), WriteData(string,string) and Writedata(int) have the same functionality to insert new data in the excel file, WriteData only take data 1 time following with user input for first name and last name, WriteData(string,string) can write data without user input, WriteData(int) is used to ask user input multiple times.
 - getCount() is use to get the number of the current row.
 - Randomstring(int) can generate a random string with require the length for the argument of the string and return the string.
 - inserRandomString(int,int) can write the random string from the Randomstring() to the excel file with 2 argument  which take the first argument for the number of string to insert and second argument to select the length of the string.
 ---------------
 	DataOut Object
-  int count is used to keep track of the current row of the excel.
- DataOut(int) is the constructor which takes 1 argument. The argument is to use to keep track of the current row.
- setCount(int) is use to set the cursor to the specific row which take 1 argument to set the cursor.
- Read()  prints out the whole list in the excel.
- Read(int, int) prints out the list with specific range. It take 2 arguments. The first argument is for the range and the second argument is for the root position.
----------
	Challenge
   - Follow strictly Object Oriented Program
   - Config the right Console App to run the references.
   - Find the right directory to open and save the excel file.
# New American Business Association


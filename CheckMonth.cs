/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw2
*/
/*
  5
-----
* *a.* Write a program named **CheckMonth** that prompts 
a user to enter a birth month. If the value entered is 
greater than 12 or less than 1, display an error message; 
otherwise, display the valid month with a message such as 
3 is a valid month.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CheckMonth
{
    class CheckMonth
    {
        static void Main(string[] args)
        {
            WriteLine("hw2#5a - Patrick Barnes");
            WriteLine("CheckMonth");

			int inMonth = 0;
            Write("Enter month (#):");
			inMonth = int.Parse(ReadLine());
			
			if (inMonth >= 1 && inMonth <= 12)
				WriteLine("{0} Valid", inMonth);
			else
				WriteLine("Invalid");

            WriteLine("--End--");

        }
    }
}

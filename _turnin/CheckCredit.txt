/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw2
*/
/*
  1
-----
Write a program named **CheckCredit** that prompts users to 
enter a purchase price for an item. If the value entered is 
greater than a credit limit of $8,000, display an error 
message; otherwise, display `Approved`.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CheckCredit
{
    class CheckCredit
    {
        static void Main(string[] args)
        {
            WriteLine("hw2#1 - Patrick Barnes");
            WriteLine("CheckCredit");

            double convert;
			Write("Enter credit limit:");
			convert = Convert.ToDouble(ReadLine());
			if (convert > 8000)
			{
				WriteLine("Approved");
			}
			else
			{
				WriteLine("Error");
			}
            WriteLine("--End--");

        }
    }
}

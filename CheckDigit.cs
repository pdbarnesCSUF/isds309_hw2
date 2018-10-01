/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw2
*/
/*
  6
-----
Account numbers sometimes contain a check digit that is 
the result of a mathematical calculation. The inclusion 
of the digit in an account number helps ascertain whether 
the number is a valid one. Write an application named 
**CheckDigit** that asks a user to enter a four-digit 
account number and determines whether it is a valid number. 
The number is valid if the fourth digit is the remainder 
when the number represented by the first three digits of 
the four-digit number is divided by 7. For example, 7770 
is valid, because 0 is the remainder when 777 is divided by 7.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CheckDigit
{
    class CheckDigit
    {
        static void Main(string[] args)
        {
            WriteLine("hw2#6 - Patrick Barnes");
            WriteLine("CheckDigit");

            int inAcct = 0;
			int first3 = 0;
			int last = 0;
			int checkValue = 0;

			Write("Enter account number:");
			inAcct = int.Parse(ReadLine());
			
			if (inAcct >= 0 && inAcct < 10000)
			{
				first3 = inAcct / 10;
				last = inAcct % 10;
				checkValue = first3 / 7;
				if (checkValue == last)
					WriteLine("Valid");
				else
					WriteLine("Invalid");
			}
			else //not 4 digits
				WriteLine("Invalid");

            WriteLine("--End--");

        }
    }
}

/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw2
*/
/*
* *b.* Write a program named **CheckMonth2** that prompts 
a user to enter a birth month and day. Display an error 
message if the month is invalid (not 1 through 12) or the 
day is invalid for the month (for example, not between 1 
and 31 for January or between 1 and 29 for February). If 
the month and day are valid, display them with a message.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CheckMonth2
{
    class CheckMonth2
    {
        static void Main(string[] args)
        {
            WriteLine("hw2#5b - Patrick Barnes");
            WriteLine("CheckMonth2");

            int inMonth = 0;
			int inDay = 0;
            Write("Enter month (#):");
			inMonth = int.Parse(ReadLine());
			Write("Enter day (#):");
			inMonth = int.Parse(ReadLine());
			
			if (inMonth >= 1 && inMonth <= 12)
			{
				WriteLine("Month {0} Valid", inMonth);
				//lots of days ):
				if (inDay >= 1)
				{
					switch(inDay)
					{
						//31 days
						case 1:
						case 3:
						case 5:
						case 7:
						case 8:
						case 10:
						case 12:
							if (inDay <= 31)
								WriteLine("Day {0} Valid", inDay);
							else
								WriteLine("Day {0} Invalid!", inDay);
							break;
						//30 days
						case 4:
						case 6:
						case 9:
						case 11:
							if (inDay <= 30)
								WriteLine("Day {0} Valid", inDay);
							else
								WriteLine("Day {0} Invalid!", inDay);
							break;
						//29 days
						case 2:
							if (inDay <= 29)
								WriteLine("Day {0} Valid", inDay);
							else
								WriteLine("Day {0} Invalid!", inDay);
							break;
					}//switch(inDay)
				}//if (inDay >= 1)
				else
					WriteLine("Day {0} Invalid!", inDay);
			}//if (inMonth >= 1 && inMonth <= 12)
			else
				WriteLine("Month {0} Invalid!", inMonth);
			
			
            WriteLine("--End--");
        }
    }
}

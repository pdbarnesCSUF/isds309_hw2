/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw2
*/
/*
  4
-----
The Saffir-Simpson Hurricane Scale classifies hurricanes 
into five categories numbered 1 through 5. Write an 
application named **Hurricane** that outputs a hurricane’s 
category based on the user’s input of the wind speed. 
Category 5 hurricanes have sustained winds of at least 
157 miles per hour. The minimum sustained wind speeds for 
categories 4 through 1 are 130, 111, 96, and 74 miles per 
hour, respectively. Any storm with winds of less than 74 
miles per hour is not a hurricane.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Hurricane
{
    class Hurricane
    {
        static void Main(string[] args)
        {
            WriteLine("hw2#3 - Patrick Barnes");
            WriteLine("Hurricane");

			int windspeed = 0;
			Write("Windspeed mph:");
			windspeed = int.parse(ReadLine());
			
			if (windspeed >= 157)
				WriteLine("Category 5");
			else if (windspeed >= 130)
				WriteLine("Category 4");
			else if (windspeed >= 111)
				WriteLine("Category 3");
			else if (windspeed >= 96)
				WriteLine("Category 2");
			else if (windspeed >= 74)
				WriteLine("Category 1");
			else
				WriteLine("Not Hurricane");
			
            WriteLine("--End--");

        }
    }
}

/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw2
*/
/*
  3
-----
Write a program named **Admission** for a college’s 
admissions office. The user enters a numeric high school 
grade point average (for example, 3.2) and an admission 
test score. Display the message `Accept` if the student 
meets either of the following requirements:

* A grade point average of 3.0 or higher, and an admission 
test score of at least 60

* A grade point average of less than 3.0, and an admission 
test score of at least 80

* If the student does not meet either of the qualification 
criteria, display `Reject`.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Admission
{
    class Admission
    {
        static void Main(string[] args)
        {
            WriteLine("hw2#3 - Patrick Barnes");
            WriteLine("Admission");

			double gpa = 0;
			double test = 0;
			
            Write("GPA:");
			gpa = Convert.ToDouble(ReadLine());
			Write("Test:");
			test = Convert.ToDouble(ReadLine());
			
			if ( test >= 80)
				WriteLine("Accept");
			else if ( gpa >= 3.0 && test >= 60)
				WriteLine("Accept");
			else
				WriteLine("Reject");
			
            WriteLine("--End--");

        }
    }
}

/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw2
*/
/*
  2
-----
Write a program named **Twitter** that accepts a user’s 
message and determines whether it is short enough for a 
social networking service that does not accept messages of 
more than 140 characters.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Twitter
{
    class Twitter
    {
        static void Main(string[] args)
        {
            WriteLine("hw2#2 - Patrick Barnes");
            WriteLine("Twitter");

            string msg;
			Write("Message:");
			msg = ReadLine();
			if (msg.length > 140)
			{
				WriteLine("Message TOO LONG");
			}
			else
			{
				WriteLine("Message OK");
			}

            WriteLine("--End--");

        }
    }
}

/*
    Patrick Barnes
    https://github.com/pdbarnesCSUF/isds309_hw2
*/
/*

The next problems rely on the generation of a random number. 
You can create a random number that is at least min but less 
than max using the following statements:
Program code. In the code, the words in the variable names 
are merged.
```cs
Random ranNumberGenerator = new Random();
int randomNumber;
randomNumber = ranNumberGenerator.Next(min, max);
```
  7
-----
Write a program named **GuessingGame** that generates a 
random number between 1 and 10. (In other words, in the 
example above, `min` is 1 and `max` is 11.) Ask a user 
to guess the random number, then display the random number 
and a message indicating whether the user’s guess was too 
high, too low, or correct.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace GuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            WriteLine("hw2#7 - Patrick Barnes");
            WriteLine("GuessingGame");
			
			const int MIN = 1;  //inclusive
			const int MAX = 11; //exclusive
            int randomNumber = 0;
			int guess = 0;
			
			Random ranNumberGenerator = new Random();
												//(inclusive,	exclusive)
			randomNumber = ranNumberGenerator.Next(MIN, 		MAX);
			//WriteLine("DEBUG:randomNumber={0}",randomNumber); //DEBUG
			Write("Guess a number ({0}-{1}):",MIN , MAX-1);
			guess = int.Parse(ReadLine());
			if (guess == randomNumber)
				WriteLine("Correct!");
			else if (guess < randomNumber)
				WriteLine("Too low");
			else
				WriteLine("Too high");
			
            WriteLine("--End--");

        }
    }
}

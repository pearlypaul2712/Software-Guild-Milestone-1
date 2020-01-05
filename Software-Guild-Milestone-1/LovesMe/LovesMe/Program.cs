using System;

/**
 * 
 * Write a program that picks petals off a daisy (ordinarily 34 petals!) and prints out "It LOVES me NOT!" or "It LOVES me!" for every other petal until it runs out of petals. 
 * 
 * Feel free to print a happy message at the end too … since the result should ALWAYS be the same.

Did you write it in a while, or do/while loop? Why? (answer in a comment)*/


namespace LovesMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 34;
            do
            {
                
              
                if (a % 2 != 0)
                {
                    Console.WriteLine("It LOVES me!");
                }

                if (a % 2 == 0)
                {
                    Console.WriteLine("It loves me NOT!");
                }
                a--;
            }
            while (a >= 0);
   

           


        }
    }
}

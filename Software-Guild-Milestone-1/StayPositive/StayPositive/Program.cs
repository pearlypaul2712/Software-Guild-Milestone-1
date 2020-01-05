using System;

/**
 * 
 * Write a while loop that asks the user for a number and counts down from it, printing out each number until it reaches zero, and then stops. (Stop at zero because the numbers after, they just get too NEGATIVE to deal with!)

BONUS: Print out 10 numbers per line, and then start a new line ...

What You Should See (Example)
What number should I count down from? 59

Here goes!

59 58 57 56 55 54 53 52 51 50
49 48 47 46 45 44 43 42 41 40
39 38 37 36 35 34 33 32 31 30
29 28 27 26 25 24 23 22 21 20
19 18 17 16 15 14 13 12 11 10
9 8 7 6 5 4 3 2 1 0

Whew, better stop there...! 
    
     * **/


namespace StayPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number should I count down from ?");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;


            while (a >= 0)
            {
                

                Console.Write(" " + a + " ");
                count++;


                if (count%10 == 0 && count!=0)
                {

                    Console.WriteLine();
                }
                a--;
               
            }

            Console.WriteLine("Whew, better stop there...! ");
        }
    
    }
}

/**
 * Author : Pearly Merin Paul
 * 
 * 
 * Write a program that asks for a number.
Match that number against the month number.
Printout the name of the month and its corresponding birth stone.
Use Ifs and Elses to complete it.
Month/Birthstone
1 - January - Garnet
2 - February - Amethyst
3 - March - Aquamarine
4 - April - Diamond
5 - May - Emerald
6 - June - Pearl
7 - July - Ruby
8 - August - Peridot
9 - September - Sapphire
10 - October - Opal
11 - November - Topaz
12 - December - Turquoise
    What You Should See (Example 1)
        What month's birthstone are you wanting to know? 12
        December's birthstone is Turquoise.
    What You Should See (Example 2)
        What month's birthstone are you wanting to know? -1
        I think you must be confused, -1 doesn't match a month.
 * 
 * 
 * */
using System;

namespace BirthStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month's birthstone are you wanting to know?");
                int number_entered = Convert.ToInt32(Console.ReadLine());
            if(number_entered == 1)
            {
                Console.WriteLine("January's birthstone is Garnet");
            }
            else if (number_entered == 2)
            {
                Console.WriteLine("February's birthstone is Amethyst");
            }
            else if (number_entered == 3)
            {
                Console.WriteLine("March's birthstone is Aquamarine");
            }
            else if (number_entered == 4)
            {
                Console.WriteLine("April's birthstone is Diamond");
            }
            else if (number_entered == 5)
            {
                Console.WriteLine("May's birthstone is Emerald");
            }
            else if (number_entered == 6)
            {
                Console.WriteLine("June's birthstone is Pearl");
            }
            else if (number_entered == 7)
            {
                Console.WriteLine("July's birthstone is Ruby");
            }
            else if (number_entered == 8)
            {
                Console.WriteLine("August's birthstone is Peridot");
            }

            else if (number_entered == 9)
            {
                Console.WriteLine("September's birthstone is Sapphire");
            }
            else if (number_entered == 10)
            {
                Console.WriteLine("October's birthstone is Opal");
            }
            else if (number_entered == 11)
            {
                Console.WriteLine("November's birthstone is Topaz");
            }
            else if (number_entered == 12)
            {
                Console.WriteLine("December's birthstone is Turquoise");
            }
            else
            {
                Console.WriteLine("I think you must be confused, " +number_entered + " doesn't match a month.");
            }
        }
    }
}

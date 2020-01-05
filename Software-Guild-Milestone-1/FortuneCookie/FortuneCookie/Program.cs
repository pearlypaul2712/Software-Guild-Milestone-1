using System;

/**Author : Pearly Paul
 * 
 * Write a program that randomly prints out one of the following to the screen.

“Those aren’t the droids you’re looking for.”
“Never go in against a Sicilian when death is on the line!”<
“Goonies never say die.”
“With great power there must also come — great responsibility.”
“Never argue with the data.”
“Try not. Do, or do not. There is no try.”
“You are a leaf on the wind, watch how you soar.”
“Do absolutely nothing, and it will be everything that you thought it could be.”
“Kneel before Zod.”
“Make it so.”**/



namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int choice = randomizer.Next(11);

       

            if(choice == 1)
            {
                Console.WriteLine("Your Geek Fortune : Those aren’t the droids you’re looking for.");
            }

            else if (choice == 2)
            {
                Console.WriteLine("Your Geek Fortune :Never go in against a Sicilian when death is on the line!");
            }

            else if (choice == 3)
            {
                Console.WriteLine("Your Geek Fortune : Goonies never say die.");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Your Geek Fortune :With great power there must also come — great responsibility.");
            }

            else if (choice == 5)
            {
                Console.WriteLine("Your Geek Fortune : Never argue with the data.");
            }

            else if (choice == 6)
            {
                Console.WriteLine("Your Geek Fortune :Try not. Do, or do not. There is no try.");
            }

            else if (choice == 7)
            {
                Console.WriteLine("Your Geek Fortune : You are a leaf on the wind, watch how you soar.");
            }

            else if (choice == 8)
            {
                Console.WriteLine("Your Geek Fortune : Do absolutely nothing, and it will be everything that you thought it could be.");
            }
            else if (choice == 9)
            {
                Console.WriteLine("Your Geek Fortune : Kneel before Zod.");
            }

            else if (choice == 10)
            {
                Console.WriteLine("Your Geek Fortune : Make it so.");
            }


        }
    }
}

/**
 * I've chosen a number between -100 and 100. Betcha can't guess it!
Your guess: 44

Ha, nice try - too low! Try again!
Your guess: 99

Wow, nice guess! That was it!**/





using System;

namespace GuessMeMore
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            int x = randomizer.Next(-101,101);
            Console.WriteLine("I've chosen a number between -100 and 100. Betcha can't guess it!");
            Console.WriteLine("Your guess: ");

            int input = Convert.ToInt32(Console.ReadLine());

            if (x != input)
            {
               
                if (x > input)
                {
                    Console.WriteLine("Ha, nice try -too low! Try again!");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    input = input1;
                }
                else if (x < input)
                {
                    Console.WriteLine("Ha, nice try -too high! Try again!");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    input = input1;
                }
                
               

                if (x == input)
                {
                    

                   Console.WriteLine("Wow, nice guess! That was it!");
                }
            }


        }
    }
}

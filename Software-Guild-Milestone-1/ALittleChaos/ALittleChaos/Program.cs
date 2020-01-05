

/**
 * Ever had a hard time making up your mind? Don't worry! Random is here to save you!
All you have to do is write down ALLLLL the choices (if statements are good for this!), and then have random choose between them!

Whew! Aren't computers the BEST?!

What You Should Do
Filename: Opinionator.sln
Type in the following code, make it work!
There is a bug in our code though, find it and fix it! (Explain in a comment!)

 * Bug in this code was  this should have been instead of 5 
 * 
 *  int x = randomizer.Next(5);
 *  Replaced Code
 * int x = randomizer.Next(6);
 * 
 * **/

using System;

namespace ALittleChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            Console.WriteLine("I can't decide what animal I like the best.");
            Console.WriteLine("I know! Random can decide FOR ME!");

            int x = randomizer.Next(6);

            Console.WriteLine("The number we chose was: " + x);

            if (x == 0)
            {
                Console.WriteLine("Llamas are the best!");
              
            }
            else if (x == 1)
            {
                Console.WriteLine("Dodos are the best!");
            }
            else if (x == 2)
            {
                Console.WriteLine("Woolly Mammoths are DEFINITELY the best!");
            }
            else if (x == 3)
            {
                Console.WriteLine("Sharks are the greatest, they have their own week!");
            }
            else if (x == 4)
            {
                Console.WriteLine("Cockatoos are just so awesomme!");
            }
            else if (x == 5)
            {
                Console.WriteLine("Have you ever met a Mole-Rat? They're GREAT!");
            }
          
                Console.WriteLine("Thanks Random, maybe YOU'RE the best!");
        
          
        }

    }
    }


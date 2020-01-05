/**
 * 
 * Filename: LazyTeenager.sln
Write a program that simulates a lazy teenager who won't clean their room until their parent tells them repeatedly to do it.

You should write this in a do/while loop, which continues to execute until the room is clean.

Every time the loop executes, the parent should tell the teenager to clean their room. Each time the teenager is told to clean their room, it increases the chance the teenager will clean the room by 5%. However, by the 15th time, they're going to get grounded and have their xbox confiscated. (Note: Use a break, not a compound condition to stop the loop in that case.)

So the first time they're told, there is only a 5% chance they'll clean it.
The second time, there's a 10% chance. Use Random to calculate this “chance” check.

What You Should See (Example 1)
Clean your room!! (x1)
Clean your room!! (x2)
Clean your room!! (x3)
Clean your room!! (x4)
Clean your room!! (x5)
FINE! I'LL CLEAN MY ROOM. BUT I REFUSE TO EAT MY PEAS.

 * Clean your room!! (x1)
Clean your room!! (x2)
Clean your room!! (x3)
Clean your room!! (x4)
Clean your room!! (x5)
Clean your room!! (x6)
Clean your room!! (x7)
Clean your room!! (x8)
Clean your room!! (x9)
Clean your room!! (x10)
Clean your room!! (x11)
Clean your room!! (x12)
Clean your room!! (x13)
Clean your room!! (x14)
Clean your room!! (x15)
Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!**/



using System;

namespace LazyTeenager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            int input = randomizer.Next(1, 20);
            int count = 0;
            int count1 = 1;

          
            do
            {
                Console.WriteLine("Clean your room!! (x" +count1 +")");
               
                if (count >75 )
                {
                    Console.WriteLine(" Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
                   
               
                    break;
                }


                if ( input==1)
                {
                    Console.WriteLine(" FINE! I'LL CLEAN MY ROOM. BUT I REFUSE TO EAT MY PEAS.");
                    break;
                }
                if(input==0)
                {
                    break;
                }



                count += 5;
                input--;
                count1++;

            } while (input!=0);
        }
    }
}

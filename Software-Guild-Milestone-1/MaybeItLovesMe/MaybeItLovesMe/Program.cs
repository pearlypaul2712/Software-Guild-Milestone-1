using System;


/**
 * Author : PEarly Paul
 * Change your daisy-prediction program from before, to have a RANDOM number of petals for the daisy (range is usually from 13 - 89 petals).
If the last petal ends on "it loves me NOT" print "Awwww, bummer." otherwise print "Oh, wow! It really LOVES me!"
    
     * **/


namespace MaybeItLovesMe
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomizer = new Random();

            int input = randomizer.Next(13, 89);
            String out1 = "It LOVES me!";
            String out2 = "It loves me NOT!";
            String output;

            int count = 0;

            while (input >= 13)
            {

                count++;
                if (count % 2 == 0)

                {
                    Console.WriteLine(out1);
                    output = out1;
                }
                else
                {
                    Console.WriteLine(out2);
                    output = out2;
                }

                

                if (output.Equals(out1) && input==13)
                {
                    Console.WriteLine("Oh, wow! It really LOVES me!");
                }
                else if ((output.Equals(out2) && input == 13))
                {

                    Console.WriteLine("Awwww, bummer.");
                }
                input--;
                
            }

       
        }
    }
}

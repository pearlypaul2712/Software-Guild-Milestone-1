using System;

/*
 * 
 * Code Topic 
Save your code in a file that matches the above - make it work!
Write a program that displays a different message based on the year someone was born to make them feel old. (Relevant xkcd (Links to an external site.)):
If they were born before 2005, print out that Pixar's 'Up' came out half a decade ago.
If they were born before 1995, print out that the first Harry Potter came out over 15 years ago.
If they were born before 1985, print out Space Jam came out not last decade, but the one before THAT.
If they were born before 1975, print out that the original Jurassic Park release is closer to the lunar landing, than today.
If they were born before 1965, print out that the MASH has been around for almost half a century!
Note: A person who is born in 1980 should display three messages, one for being born before 2005, one for 1995, and finally for 1985.


 
     */
namespace YourLifeInMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, let's play a game! What's your name?");
            String input_name = Console.ReadLine();
            Console.WriteLine("Ok," + input_name + ", when were you born? ");

            int input_year = Convert.ToInt32(Console.ReadLine());



            if (input_year < 2005)
            {
                Console.WriteLine("Pixar's 'Up' came out half a decade ago");


                if (input_year < 1995 )
                {
                    Console.WriteLine("That the first Harry Potter came out over 15 years ago.");

                }
                if (input_year < 1985 )
                {
                    Console.WriteLine("Space Jam came out not last decade, but the one before THAT.");

                }
                if (input_year < 1975 )
                {
                    Console.WriteLine("that the original Jurassic Park release is closer to the lunar landing, than today.");

                }
                if (input_year < 1965 )
                {
                    Console.WriteLine(" that the MASH has been around for almost half a century!");

                }
            }












        }
    }
}

using System;
/**
 * 
 * Take your number guessing program and improve it EVEN MORE!
Instead of letting the user only try once more if they get it wrong, make them keep going until they get it right!
If they get it on the first try print out "Wow, nice guess! That was it!" otherwise print out "Finally, it's about time you got it!"
What You Should See
I've chosen a number between -100 and 100. Betcha can't guess it!
Your guess: 44

Ha, nice try - too low! Try again!
Your guess: 99

Too bad, way too high. Try again!
Your guess: 74

Ha, nice try - too low! Try again!
Your guess: 82

Finally! It's about time you got it!**/


namespace GuessMeFinally
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomizer = new Random();

            int secret = randomizer.Next(-100, 100);

            int count = 0;
                int a = 0;
            Console.WriteLine(secret);

            while (count==0)
            {
                Console.WriteLine("Enter number");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > secret )
                {
                    Console.WriteLine(" Too bad, way too high. Try again!");
                   

                }
                else if (guess < secret)
                {
                    Console.WriteLine(" Ha, nice try - too low! Try again!");
                    
                }

                if (guess == secret)
                {
                    if(a==0)
                    {
                        Console.WriteLine("Wow, nice guess! That was it!");
                        break;
                    }
                    Console.WriteLine("Finally! It's about time you got it!");
                   
                    break;

                }
                a++;
            }
        }
    }
}

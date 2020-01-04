/**
 * Author : Pearly Merin Paul
 * Write a program that prints out a series of multiple choice questions (minimum 3!) and asks the user for the answer to each.
 Your program should tally the number of correct answers, and print out the results at the end!
Bonus: Have another print out if they get all or none of the questions correct.
What You Should See (Example)
It's TRIVIA NIGHT! Are you ready?!

FIRST QUESTION!
What is the Lowest Level Programming Language?
1) Source Code             2) Assembly Language
3) C#                      4) Machine Code

YOUR ANSWER: 4

SECOND QUESTION!
Website Security CAPTCHA Forms Are Descended From the Work of?
1) Grace Hopper            2) Alan Turing<
3) Charles Babbage         4) Larry Page<

YOUR ANSWER: 2
LAST QUESTION!
Which of These Sci-Fi Ships Was Once Slated for a Full-Size Replica in Las Vegas?
1) Serenity                2) The Battlestar Galactica
3) The USS Enterprise      4) The Millennium Falcon

YOUR ANSWER: 3

Nice job - you got 3 correct!
 * 
 */

using System;

namespace TriviaNight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's TRIVIA NIGHT! Are you ready?!");
            Console.WriteLine("FIRST QUESTION!");

            Console.WriteLine("What is the Lowest Level Programming Language ?");
                Console.WriteLine("1) Source Code             2) Assembly Language");
                Console.WriteLine("3) C#                      4) Machine Code");
            Console.WriteLine("Your Answer");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Website Security CAPTCHA Forms Are Descended From the Work of ?");
            Console.WriteLine("1) Grace Hopper            2) Alan Turing<");
            Console.WriteLine("3) Charles Babbage         4) Larry Page<");

            Console.WriteLine("Your Answer");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("LAST QUESTION!!");
            Console.WriteLine("Which of These Sci-Fi Ships Was Once Slated for a Full-Size Replica in Las Vegas ?");
            Console.WriteLine("1) Serenity                2) The Battlestar Galactica");
            Console.WriteLine("3) The USS Enterprise      4) The Millennium Falcon");

            Console.WriteLine("Your Answer");
            int input3 = Convert.ToInt32(Console.ReadLine());


            if (input1 == 4 && input2 == 2 && input3 == 3)
            {
                Console.WriteLine("Nice job - you got 3 correct!");
            }

            else if (input1 == 4 || input2 == 2 || input3 == 3)
            {
                Console.WriteLine("Nice job - you got 1 correct!");
            }

            else if ((input1 == 4 && input2 == 2)|| (input3 == 3 && input2 == 2)|| (input3 == 3 && input1 == 4))
            {
                Console.WriteLine("Nice job - you got 2 correct!");
            }

            else
            {
                Console.WriteLine("None Correct");
            }
        }
    }
}

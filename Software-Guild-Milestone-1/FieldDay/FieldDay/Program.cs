using System;

/**
 * Author : Pearly
 * To do that they want to assign all the people who show up to certain teams based on their last name - they've figured out the distribution break down - all they need YOU to do is to write the program that can sort them! (ie take a last name as input, output the team name!).

Here’s the specs:

If a person's name falls before Baggins then they are on the team "Red Dragons"
If it falls after Baggins, but before Dresden, they are on the team "Dark Wizards"
If it falls after Dresden, but before Howl, they are on the team "Moving Castles"
If it falls after Howl, but before Potter, they are on the team "Golden Snitches"
If it falls after Potter, but before Vimes, they are on the team "Night Guards"
If it falls after Vimes, they are on the team “Black Holes”
What You Should See (Example)
What’s your last name? Weasley
Aha! You’re on the team “Black Holes”!
Good luck in the games!*//

namespace FieldDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What’s your last name?");
            string last_name = Console.ReadLine();

            if (last_name.CompareTo("Baggins")==-1){

                Console.WriteLine("Aha! You’re on the team “Red Dragons”!");

            }

            else if (last_name.CompareTo("Baggins") == 1 && last_name.CompareTo("Dresden") == -1)
            {

                Console.WriteLine("Aha! You’re on the team “Dark Wizards”!");


            }

            else if (last_name.CompareTo("Dresden") == 1 && last_name.CompareTo("Howl") == -1)
            {

                Console.WriteLine("Aha! You’re on the team “Moving Castles”!");

            }
            else if (last_name.CompareTo("Howl") == 1 && last_name.CompareTo("Potter") == -1)
            {

                Console.WriteLine("Aha! You’re on the team Golden Snitches!");

            }

            else if (last_name.CompareTo("Potter") == 1 && last_name.CompareTo("Vimes") == -1)
            {

                Console.WriteLine("Aha! You’re on the team “Night Guards”!");

            }
            else
            {
                Console.WriteLine("Aha! You’re on the team “Black Holes”!");
            }

           


        }
    }
}

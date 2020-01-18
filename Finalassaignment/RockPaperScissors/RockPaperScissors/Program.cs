using System;

namespace RockPaperScissors
{
    class Program
    {
        public int MaxnumberOFRounds = 10;
        public int MinNumberOfRounds = 1;
        public int output;
        bool User_input = false;
        public int start_condition = 0;

        public int NumberOfRounds()
        {

            Console.WriteLine("RockPaperScissors");
            Console.WriteLine("Please enter the number of rounds you want to play (Min number of Rounds :1 and Max number of rounds:10)");
            while (true)
            {
                Console.Write("Enter a number between 1 and 10: ");
                string NumberOfRoundsUserWantsToPlay = Console.ReadLine();

                if (int.TryParse(NumberOfRoundsUserWantsToPlay, out output))
                {
                    // it was an int, now is it between 1 and 10?
                    if (output >= 1 && output <= 10)
                    {

                        break; // good input
                    }

                }
                else
                {
                    Console.WriteLine("That was not a number!");
                    break;
                }

            }
            return output;
        }

        public void Game(int chances)
        {
            int rounds = 1;

            int ties = 0;
            int UserWins = 0;
            int user_1 = 0;
            Random inputOfComputer = new Random();
            int ComputerWins = 0;
            Console.WriteLine("Lets start the Game !!!!");

            while (rounds <= chances)
            {
                Console.WriteLine("Lets Play Round " + rounds);
                Console.WriteLine("Please enter the input as below requirements!1");
                Console.WriteLine("1-Rock      2- Paper    3-Scissors");
                int v = Convert.ToInt32(Console.ReadLine());
                user_1 = v;


                Int32 Computer = inputOfComputer.Next(1, 4);
                Console.WriteLine("Computer Enters : " + Computer);

                if (user_1 >= 1 && user_1 <= 3) {
                    
                    if ((user_1 == 1 && Computer == 1) || (user_1 == 2 && Computer == 2) || (user_1 == 3 && Computer == 3))
                    {
                        Console.WriteLine("Thats a tie");
                        ties += 1;
                    }
                    else if ((user_1 == 2 && Computer == 1) || (user_1 == 3 && Computer == 2) || (user_1 == 1 && Computer == 3))
                    {
                        Console.WriteLine("USer Wins");
                        UserWins += 1;
                    }
                    else if (((Computer == 2 && user_1 == 1) || (Computer == 3 && user_1 == 2) || (Computer == 1 && user_1 == 3)))
                    {
                        Console.WriteLine("Computer Wins");
                        ComputerWins += 1;
                    }


                    if (rounds == chances)
                    {
                        Console.WriteLine("Number of rounds over");
                        Console.WriteLine("Summary :");


                    }
                }
                else
                {
                    Console.WriteLine("OutOf Scope Enter again!!");

                    rounds--;

                }
                rounds += 1;

            }
            Console.WriteLine("Total Number Of rounds " + chances);

            Console.WriteLine("Number of ties " + ties);
            Console.WriteLine("Number of ComputerWins " + ComputerWins);
            Console.WriteLine("Number of User Wins " + UserWins);
            if (ComputerWins > UserWins)
            {
                Console.WriteLine("Computer Wins");
            }
            else
            {
                Console.WriteLine("User Wins");
            }
            Console.WriteLine("Do you want to play again : 'Yes' or 'No'");
            String UserWantstoPlayagain = Console.ReadLine();

            while (true)
            {
                if (UserWantstoPlayagain.Equals("Yes"))
                {
                    User_input = true;
                    break;
                }
                else
                {
                    User_input = false;
                    start_condition = 1;
                    break;
                }

            }

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {
                if ((p.start_condition == 0 || (p.User_input == true)))
                {
                    int x = p.NumberOfRounds();


                    if (x != 0)
                    {
                        p.Game(x);
                    }
                }
                else
                {
                    Console.WriteLine("Thank You For Playing");
                    break;
                }
            }
        }
    }
}


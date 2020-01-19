//Filename: HealthyHearts.sln
//Make a simple calculator that asks the user for their age.Then calculate the healthy heart rate range for that age, and display it.

//Their maximum heart rate should be 220 - their age.
//The target heart rate zone is the 50 - 85% of the maximum.
//What You Should See
//        What is your age? 50
//        Your maximum heart rate should be 170 beats per minute
//        Your target HR Zone is 85 - 145 beats per minute

using System;

namespace HealthyHearts
{
    class Program
    {
        private int RequestAge()
        {
            Console.WriteLine("What is your age?");
            int validage=0;
            while (true)
            {
                
                int UsersAge = Convert.ToInt32(Console.ReadLine());
                if (UsersAge > 0 && UsersAge <= 120)
                {
                    validage = UsersAge;
                    break;
                                       
                }
                else
                {
                    if (UsersAge > 120)
                    {
                        Console.Write("Nowadays people dont live that long!Please enter age  between 0-120! Please enter again.");
                    }
                    else
                    {
                        Console.WriteLine("Thats not a valid age number!!");
                    }
                }


            }
            return validage;

        }

        public int MaximumHeartRate(int age)
        {
            int MaximumHeartRate = 220 - age;
            Console.WriteLine("Your maximum heart rate should be " + MaximumHeartRate + " beats per minute");
            return MaximumHeartRate;
        }
        public void targetHeartRate(int maxHeartRate )
        {
            int targetHR1 = Convert.ToInt32(.5 * maxHeartRate);
            int targetHR2 = Convert.ToInt32(.85 * maxHeartRate);
            Console.WriteLine("Your target HR Zone is " + targetHR1 +"-" + targetHR2 + " beats per minute");

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int ageInput = p.RequestAge();
            int maxheartrate=p.MaximumHeartRate(ageInput);
            p.targetHeartRate(maxheartrate);
        }
    }
}

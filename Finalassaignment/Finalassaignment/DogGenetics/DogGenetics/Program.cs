        //What is your dog's name? Sir Fluffy McFlufferkins Esquire
        //Well then, I have this highly reliable report on Sir Fluffy McFlufferkins Esquire's prestigious background right here.

        //Sir Fluffy McFlufferkins Esquire is:

        //61% St.Bernard
        //2% Chihuahua
        //29% Dramatic RedNosed Asian Pug
        //1% Common Cur
        //7% King Doberman

        //Wow, that's QUITE the dog!  



        //       What is your dog's name? Sir Fluffy McFlufferkins Esquire
        //Well then, I have this highly reliable report on Sir Fluffy McFlufferkins Esquire's prestigious background right here.

        //Sir Fluffy McFlufferkins Esquire is:

        //61% St.Bernard
        //2% Chihuahua
        //29% Dramatic RedNosed Asian Pug
        //1% Common Cur
        //7% King Doberman

        //Wow, that's QUITE the dog!
using System;

namespace DogGenetics
{
    class Program
    {
        public string [] listOfDogs = new string[5];

        public String DogName()
        {
            Console.WriteLine("What is your dog's name?");
            String DogName1 = Console.ReadLine();
            return DogName1;

        }
        
        public void GeneticCalculator(String dogname)
        {

            Random randomizer = new Random();

            int percentTotal = 100;
            int percent = 0;
         
            String [] listOfDogs ={ "St.Bernard", "Chihuahua", "Dramatic RedNosed Asian Pug", "Common Cur", "King Doberman" };
            Console.WriteLine("Well then, I have this highly reliable report on " +dogname +"'s prestigious background right here.");

            for (int i=0;i<listOfDogs.Length;i++)
            {
      

                if (i < listOfDogs.Length - 1)
                {
                   percent = randomizer.Next( percentTotal);
                   percentTotal -= percent;
                }
                else
                {
                    percent = percentTotal;
                }



                Console.WriteLine(percent+"%" + " " +listOfDogs[i] );
              

            }
            Console.WriteLine("Wow, that's QUITE the dog! ");

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            String nameInput = p.DogName();
            p.GeneticCalculator(nameInput);

        }
    }
}


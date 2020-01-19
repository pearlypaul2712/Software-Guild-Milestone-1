//Write a static method that takes in an array of ints, adds them together, and returns the result.
//Call your new method inside a main method and print out the result for the following three example arrays:

//        { 1, 90, -33, -55, 67, -16, 28, -55, 15 }
//        { 999, -60, -77, 14, 160, 301 }
//        { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 
//        140, 150, 160, 170, 180, 190, 200, -99 } 
//What You Should See
//        #1 Array Sum: 42
//        #2 Array Sum: 1337
//        #3 Array Sum: 2001


using System;

namespace SummativeSums
{
   


    class Program
    {

        public int[] array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
        public int[] array2 = { 999, -60, -77, 14, 160, 301 };
        public int[] array3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };

        public static int SumOfArray(int [] arrayInput)
        {
           
           
            int arraysum = 0;
           

                for (int i = 0; i < arrayInput.Length; i++)
                {
                    arraysum += arrayInput[i];
                }
               
                return arraysum;
 

        }
 



        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("#1 Array Sum: " +SumOfArray(p.array1));
            Console.WriteLine("#1 Array Sum: " + SumOfArray(p.array2));
            Console.WriteLine("#1 Array Sum: " + SumOfArray(p.array3));



        }
    }
}

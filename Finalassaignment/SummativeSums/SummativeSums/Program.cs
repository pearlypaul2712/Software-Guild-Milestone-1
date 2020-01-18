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
        public static int SumOfArray1()
        {
            int[] array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
           
            int arraysum1 = 0;
           

                for (int i = 0; i < array1.Length; i++)
                {
                    arraysum1 += array1[i];
                }
               
                return arraysum1;
 

        }
        public static int SumOfArray2()
        {
            int[] array2 = { 999, -60, -77, 14, 160, 301 };
            int arraysum2 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                arraysum2 += array2[i];
            }

            return arraysum2;
        }

        public static int SumOfArray3()
        {
            int[] array3 ={ 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130,
        140, 150, 160, 170, 180, 190, 200, -99 };

            int arraysum3 = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                arraysum3 += array3[i];
            }

            return arraysum3;
        }



        static void Main(string[] args)
        {
            

            Console.WriteLine("#1 Array Sum: " +SumOfArray1());
            Console.WriteLine("#2 Array Sum: " +SumOfArray2());
            Console.WriteLine("#3 Array Sum: " +SumOfArray3());


        }
    }
}

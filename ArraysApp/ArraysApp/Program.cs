using System;

namespace ArraysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[] { 1, 1, 2, 3, 5, 8 }; 
            foreach(int number in numbersArray)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}


/* Create and initialize in a single line an array with the following values: 
 1, 1, 2, 3, 5, 8. Then loop through the array and print out each value. */

//Initialize array with 1, 1, 2, 3, 5, 8 int values.
//loop through array and print.
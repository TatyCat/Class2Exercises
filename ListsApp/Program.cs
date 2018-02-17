using System;
using System.Collections.Generic;
using System.Text;

namespace ListsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list with int 1-10
            List<int> numbersList = new List<int>(new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            StringBuilder evenNumbers = new StringBuilder();

            //loop through the list of numbers to get even ones. 
            //if divisible by 2, return.
            foreach (int number in numbersList)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Append(number + ", ");
                }
            }

            evenNumbers.Remove(evenNumbers.Length - 2, 2);
            
            Console.Write($"I found: {evenNumbers} in the list!");
            Console.ReadLine();
        }
    }
}



/*Find the Sum of ALL even numbers in a list*/

    //Create a list with int 1-10
    //call the method on the list 

    //loop through the list of numbers
    //if statement, if divisible by 2, and return 
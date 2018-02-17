using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //initialize
            List<int> studentIDList = new List<int>();
            List<string> studentNamesList = new List<string>();

            List<Dictionary<int, string>> studentsAndIds = new List<Dictionary<int, string>>();
            
            bool allIds = false;

            Console.WriteLine("Welcome!");

            //User input valid student name into the studentIDList
            do
            {
                //Take user input
                Console.WriteLine("Enter student IDs (Once finished, enter 'next' to begin adding names):");
                string idInput = Console.ReadLine();
                
                //if user is finished, exit loop and enter loop for student name. 
                if (idInput.Equals("next", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                // if user did not enter 'next', convert the input string to int.
                bool convertId = int.TryParse(idInput, out int studentID);
                
                //if the input is a valid number and isn't in the list, add.
                if (convertId && idInput.Length > 1 & !studentIDList.Contains(studentID))
                {
                    studentIDList.Add(studentID);
                }
                else if (studentIDList.Contains(studentID))
                {
                    Console.WriteLine("**This ID has already been entered, enter a new ID or enter 'next' to enter names.\n");
                }
                else
                {
                    Console.WriteLine("**Please enter a valid student ID number.**\n");
                }

            }
            while (allIds == false);

            Console.WriteLine("\n");
            foreach (int printStudentID in studentIDList)
            {
                Console.WriteLine(printStudentID);
            }


            /*
        foreach (Dictionary<int, string> dict in studentIDList)
        {
            Console.WriteLine("Enter the student ID (or ENTER to finish):");
            idInput = Console.ReadLine();
            int studentID = Int32.Parse(idInput);
            do
            {
                //isNum = int.TryParse(idInput, out int studentID);

                if (idInput.Length > 2)
                {
                    dict.Add(studentID, null);
                    validID = true;
                    Console.WriteLine("inner if works! :D ");
                }


                 Console.WriteLine("this ran in the do while loop");
                }
            while (validID == false);
        }
        */

        Console.ReadLine();
        }
    }
}


/* Make a program similar to GradebookDict, but which takes in students names and ID numbers (as integers) instead of names and grades. In this case, however, the keys should be integers (the IDs) and the values should be strings (the names). Modify the roster printing code accordingly. */

    //for loop to input (instead of names/grades:
        // student names (values)
        // student int ID numbers (key)
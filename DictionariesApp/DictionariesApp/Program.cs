using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> studentIDList = new List<int>();
            List<string> studentNamesList = new List<string>();

            List<Dictionary<int, string>> studentsAndIds = new List<Dictionary<int, string>>();
            
            string idInput;
            bool validID = false;

            Console.WriteLine("Welcome!");


            do
            {
                Console.WriteLine("Enter the student ID (or ENTER to finish):");
                idInput = Console.ReadLine();
                bool convertId = int.TryParse(idInput, out int studentID);

                if (convertId && idInput.Length > 2)
                {
                    studentIDList.Add(studentID);
                    validID = true;
                    Console.WriteLine("The inner if works! :D ");
                }

            }
            while (validID == false);



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
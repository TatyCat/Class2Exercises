using System;
using System.Collections.Generic;

namespace ListsAndStringsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize list
            List<string> wordList = new List<string>(new string[] {"Let", "Word", "Chunk", "Tree", "AC", "Laptop"});
            
            foreach (string word in wordList)
            {
                if(word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
            
            Console.ReadLine();
        }
    }
}


/*Write a static method to print out each word in a list that has exactly 5 letters. */

    //create a list of words, at least one with exactly five letters.
    //write a method that loops through the list to print it out if length == 5
    //write out to console
    //readline to keep window open.
using System;
using System.Collections.Generic;

namespace VogCodeChallenge.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionClass.IterateList();
        }
    }

    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John"
        };

        // Iterate through the NamesList items without using ForEach/For loops.
        public static void IterateList()
        {
            var count = 0;

            do
            {
                System.Console.WriteLine(NamesList[count]);
                count++;
            } while (count <= NamesList.Count -1);
        }       
    }
}

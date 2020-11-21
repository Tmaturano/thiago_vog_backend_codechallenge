using System;
using System.Collections.Generic;

namespace VogCodeChallenge.Console
{
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
            } while (count <= NamesList.Count - 1);
        }

        public static dynamic TESTModule(dynamic value)
        {
            var newValue = value switch
            {
                int val when val >= 1 && val <= 4 => value * 2,
                int val when val > 4 => value * 3,
                int val when val < 1 => throw new ArgumentException("value should not be smaller than 1"),
                float val when val == 1.0f || val == 2.0f => 3.0f,
                string val => val.ToUpper(),
                _ => value
            };

            return newValue;
        }
    }
}

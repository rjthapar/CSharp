using System;
using System.Collections.Generic;

namespace Algotest
{
    class Program
    {
        /// <summary>
        /// using HashSet in C# to remove duplicate values in a String
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string whose duplicate values need to be removed:-");
            string inputString = Console.ReadLine();
            char[] inputCharValues = new char[inputString.Length];
            inputCharValues = inputString.ToCharArray();
            HashSet<char> hSet = new HashSet<char>();
            foreach(Char c in inputCharValues)
            {
                hSet.Add(c);
            }
            
            foreach(char val in hSet)
            {
                Console.Write(val);
            }

        }
    }
}

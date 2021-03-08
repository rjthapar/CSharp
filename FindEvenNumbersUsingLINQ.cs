using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algotest
{
    /// <summary>
    /// learning LINQ and finding even numbers from an array 
    /// </summary>
    class FindEvenNumbersUsingLINQ
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter length of array:-");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter {0} values", length);
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                var resultArrayEven = from s in arr
                                      where s % 2 == 0
                                      select s;
                foreach (int val in resultArrayEven)
                {
                    Console.WriteLine(val);
                }
            }
        
    }
}

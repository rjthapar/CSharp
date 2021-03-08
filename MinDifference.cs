using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algotest
{
    /// <summary>
    /// Minimum Difference Between Largest and Smallest Value in Three Moves
    /// </summary>
    class MinDifference
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter length of array:-");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} values", length);
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Solution.MinDifference(arr));
        }
    }
        public static class Solution
        {
            public static int MinDifference(int[] nums)
            {
                if (nums.Length <= 4)
                    return 0;
                Array.Sort(nums);
                int result = int.MaxValue;

                for (int i = 0; i < 4; i++)
                {
                    result = Math.Min(result, (nums[nums.Length - 1 - 3 + i] - nums[i]));
                }
                return result;
            }
        }
    
}

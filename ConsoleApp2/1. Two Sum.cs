using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        count++;
                    }
                }
            }

            if (count == 0) return null;

            int[] result = new int[count * 2];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[index++] = i;
                        result[index++] = j;
                    }
                }
            }
            return result;
        }




        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 3, 4, 5, 1, 7, 1, 1 };
            int target = 2;

            for (int i = 0; i < TwoSum(nums, target).Length; i++)
            {
                Console.Write(" " + TwoSum(nums, target)[i]);
            }
            Console.ReadLine();
        }
    }
}

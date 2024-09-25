using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
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
            int[] ints = new int[count*2];
            int k = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    
                    if (nums[i] + nums[j] == target)
                    {

                        ints[k++] = i;
                          
                            ints[k++] = j;

                        if (j==nums.Length-1)
                       return ints;
                        
                    }
                   
                }  
             }
            return null;
        }
        
      public static void Main(string[] args)
        {
            int[] nums = { 4, 1, 3, 4, 5, 1, 7, 1, 1 };
            int target = 2;
            
            for (int i = 0; i < TwoSum(nums, target).Length; i++)
            {
                Console.Write(" "+TwoSum(nums, target)[i]);
            }
            Console.ReadLine();
                
            
        }
    }
}

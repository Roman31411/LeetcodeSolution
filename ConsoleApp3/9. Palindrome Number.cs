using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp3
{
    internal class Program
    {
        public static bool IsPalindrome(int x)
        {
            string z; 
           
           z = new string(x.ToString().Reverse().ToArray());
            if (z == x.ToString())
            {
               return true;

            }
           else

            { 
                return false;
            }
              
        }
        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindrome(5321)); 
            Console.ReadLine();
        }
    }
}

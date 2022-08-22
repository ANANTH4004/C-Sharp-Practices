using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class OptionalParameters
    {
        static void Main(string[] args)
        {

            int[] nums = { 10, 20, 20 };
            Console.WriteLine("Enter First Number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number :");
            int b = Convert.ToInt32(Console.ReadLine());
            int ans1 = addition(a, b);
            Console.WriteLine("result : {0}", ans1);
            int ans = addition(a, b, nums);
            Console.WriteLine("result : {0}", ans);
            print("anand", "love" , 11);

        }
        #region params addition(int , int)
        static int addition(int i, int j, params int[] nums)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int result = i + j;
            if (nums != null)
            {
                foreach (int num in nums)
                {
                    result += num;
                }
            }
            return result;
        } 
        #endregion
        static void print(params object[] det)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in det)
            {
                Console.WriteLine(item);
            }
        }
    }
}

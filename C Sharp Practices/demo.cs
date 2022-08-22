using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class demo
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 17, 11, 15,7 };
            int target = 9;
            List<int> li = new List<int>(2);
            li = TwoSum(nums, target);
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
        }
       static public List<int> TwoSum(int[] nums, int target)
        {
            List<int> l = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
          
            for (int i = 0; i < nums.Length; i++)
            {
                int b = nums[i];
                int a = target - b;
                
                if (dic.ContainsKey(a))
                {
                    return new List<int> { dic[a], i };
                }
                dic.Add(b, i);
            }
            return new List<int> { };
        }
    }
}

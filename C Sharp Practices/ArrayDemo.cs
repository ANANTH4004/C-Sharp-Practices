using System;
//using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {2,3,4,1,5} ;
            Console.WriteLine(a.Sum());
            Console.WriteLine("=======================");
            foreach (int  item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============================");
            int[] a3 = new int[a.Length];
            Array.Copy(a, a3, a.Length);
            Array.Sort(a3);
            Array.Reverse(a3);
            foreach (var item in a3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================");
            var numbers = new Dictionary<int, string>();
            numbers.Add(1, "anand");
            numbers.Add(2, "varun");
            numbers.Add(3, "Nithya");
            numbers.Add(4, "Krish");
            numbers.Add(5, "Barath");
            foreach (var item in numbers)
            {
                Console.WriteLine("ID {0} Name {1}",item.Key,item.Value);
            }
            Console.WriteLine("==============================");

            var hash = new HashSet<int>();
            
            hash.Add(43);
            
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
           

        }
    }
}

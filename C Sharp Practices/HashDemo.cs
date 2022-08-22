using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class HashDemo
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "anand");
            h.Add(2, "varun");
            h.Add(3, "Nithya");
            h.Add(4, "Krish");
            h.Add(5, "Barath");
           
            string s  = h[5].ToString();
            IDictionaryEnumerator ie = h.GetEnumerator();
            Console.WriteLine("========While==========");
            while (ie.MoveNext())
            {
                Console.WriteLine("items {0}  {1}",ie.Key,ie.Value);
            }
            Console.WriteLine("========ForEach==========");
            
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine($"key {item.Key} value {item.Value}");
            }
            Console.WriteLine("==========TOstring===========");
            Console.WriteLine(s); ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======STACK==========");
            Stack s = new Stack();
            s.Push(new DateTime(2020,05,11));
            s.Push(101);
            s.Push("anand");
            s.Push("varun");
            s.Push(true);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========Methods ans Properties=========");
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Count);
            if (s.Contains(101))
            {
                Console.WriteLine("Contains work");
            }
           
        }
    }
}

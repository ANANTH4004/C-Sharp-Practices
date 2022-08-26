using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedListTypeInt();
        }

        private static void LinkedListTypeInt()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(10);
            list.AddLast(100);
            list.AddAfter(list.First, 20);
            list.AddBefore(list.Last, 90);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            string ans;
            Queue q = new Queue(7);
            q.Enqueue(23);
            q.Enqueue("anand");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count = {0}",q.Count);
            Console.WriteLine("=========ToString()=====");
            ans = q.ToString();
            Console.WriteLine(ans);
        }
    }
}

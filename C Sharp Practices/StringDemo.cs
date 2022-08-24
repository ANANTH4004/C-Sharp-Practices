using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class StringDemo
    {
        static void Main(string[] args)
        {
            /* string s = "   Anand     ";
             Console.WriteLine(s + " " + s.Length);
             s = s.Trim();
             Console.WriteLine(s + " " + s.Length);
             Console.WriteLine(s.IndexOf('A'));
             Console.WriteLine(s.Insert(4, " Balamurugan"));
             Console.WriteLine(s.Substring(2, 3));
             string names = "anand,varun,sam";
             string[] spl = { "," };
             string[] result = names.Split(spl, StringSplitOptions.RemoveEmptyEntries);
             foreach (var item in result)
             {
                 Console.WriteLine(item);
             }
             String[] res = names.Split('a');
             foreach (var item in res)
             {
                 Console.WriteLine(item);
             }*/
            StringBuilder sb = new StringBuilder("Hi i am Varun ");
            sb.Append("Hi i am Anand ");
            Console.WriteLine(sb);
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i] + " ");
            }
            Console.WriteLine("\n=============================" );
            Console.WriteLine(sb.ToString());
            sb.AppendLine("varun krish");
            sb.Append("Nithya");
            Console.WriteLine(sb);
            StringBuilder c = new StringBuilder("Total amount = ");
            c.AppendFormat("{0:c}",300);
            c.AppendFormat(" ON {0:D}", DateTime.Now.Date);
            Console.WriteLine(c);
        }
    }
}

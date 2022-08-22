using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class StringMethods
    {
        static void Main(string[] args)
        {
            string name = "If you expect disappointment, then you can never really be disappointed.";
            
            Console.WriteLine(name.LastIndexOf('e'));
            string name1 = String.Join("e", name);
            Console.WriteLine(name1);
            Console.WriteLine(name.Replace('e','s'));
            var list = new List<string>() { "anand ","varun","vikram","sam","sk","Nithya"};
            list.Sort();
            var charList = new List<char>();
            char[] charArray;
              charArray =  name.ToArray();
            foreach (var item in list)
            {
                Console.WriteLine($"list items {item} ");
            }
            foreach (var item in charArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

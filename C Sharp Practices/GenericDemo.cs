using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class GenericDemo
    {
        static void Main(string[] args)
        {
            var numbers = new Dictionary<int, string>();
            numbers.Add(5, "anand");
            numbers.Add(4, "varun");
            numbers.Add(3, "Nithya");
            numbers.Add(1, "Krish");
            numbers.Add(2, "Barath");
 
            foreach (var item in numbers)
            {
                Console.WriteLine($"key {item.Key} value {item.Value}");
            }
        }
    }
}

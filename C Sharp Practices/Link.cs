using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class Link
    {
        static void Main(string[] args)
        {
            LinkedListImplemetation link = new LinkedListImplemetation();
            link.InsertFront(link, "anand");
            link.InsertLast(link, "varun");
            link.InsertLast(link, "bala");
            link.InsertLast(link, "chandru");
            link.InsertLast(link, "dinesh");
            link.InsertFront(link, "nithya");
            link.InsertLast(link, "monisha");
            link.PrintList(link);
            Console.WriteLine("==================== After Reversed===================");
           // link.Reverse(link);
            link.PrintList(link);
            Console.WriteLine("==================== Insert pos=======================");
            link.Insert(link,5);
            
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Practices
{
    internal class FilesDemo
    {
        static void Main(string[] args)
        {
           // File.Create("anand.pdf");
            //File.Create("anand.txt");
            string path = @"D:\c#\C Sharp Practices\C Sharp Practices\bin\Debug\sample.pdf";
            Console.WriteLine(path);
            FileInfo PI = new FileInfo(path);
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class Exceptionmain
    {
        static void Main(string[] args)
        {
            List<int> rollNo = new List<int>();
            rollNo.Add(1);
            rollNo.Add(2);
            rollNo.Add(3);
            rollNo.Add(4);
            rollNo.Add(5);
            rollNo.Add(6);
            Console.WriteLine("Enter roll number");
            int Roll = Int32.Parse( Console.ReadLine());
            try
            {
                Console.WriteLine("Enter i");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter j");
                int j = Convert.ToInt32(Console.ReadLine());
                if (j == 0)
                {
                    throw new DivideByZeroException("This division would not be possible");

                }
                else
                {
                    int Divans = i / j;
                    Console.WriteLine(Divans);
                }

                bool ans = rollNo.Contains( Roll );
                if(ans == false)
                {
                    throw new StudentNotFoundException("Student Not Found");
                }
            }
            catch (StudentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

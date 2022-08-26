using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hr
{
    public class Employee
    {
       private int empId;
        public int getEmpId { get { return empId; } 
            set { empId = value; }
        }
        private string empName;

        public string getEmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        private string city;

        public string getCity
        {
            get { return city; }
            set { city = value; }
        }
        private int bs;

        public int getBs
        {
          get { return bs; }
           private set { bs = value; }
        }

        public double GrossSalary { get; private set; }

        public void CalculateSalary(int bs)
        {

            double grosssSal = 0;
            if (city == "Pune" || city == "Bangalore" || city == "Hyderabad")
            {
                grosssSal = bs + (bs * .10);
            }
            else
            {
                grosssSal = bs + (bs * .05);
            }
            //Console.WriteLine("Gross Salary=" +  grosssSal);
            GrossSalary = grosssSal;

        }


    }
}

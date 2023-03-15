using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class PrintSalary:Employee
    {
        public PrintSalary(int salary):base(salary)
        {
            
        }
        public void Print(string s)
        {
            switch(s)
            {
                case "January":
                    Console.WriteLine(((Months)0) + " " + salary);
                    break;
                case "February":
                    Console.WriteLine(((Months)1) + " " + salary);
                    break;
                case "March":
                    Console.WriteLine(((Months)2) + " " + salary);
                    break;
                case "April":
                    Console.WriteLine(((Months)3) + " " + salary);
                    break;
                case "May":
                    Console.WriteLine(((Months)4) + " " + salary);
                    break;
                case "June":
                    Console.WriteLine(((Months)5) + " " + salary);
                    break;
                case "July":
                    Console.WriteLine(((Months)6) + " " + salary);
                    break;
                case "August":
                    Console.WriteLine(((Months)7) + " " + " Not working month");
                    break;
                case "September":
                    Console.WriteLine(((Months)8) + " " + salary);
                    break;
                case "October":
                    Console.WriteLine(((Months)9) + " " + salary);
                    break;
                case "November":
                    Console.WriteLine(((Months)10) + " " + salary);
                    break;
                case "December":
                    Console.WriteLine(((Months)11) + " " + salary + " + 30%");
                    break;
            }
        }
    }
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}

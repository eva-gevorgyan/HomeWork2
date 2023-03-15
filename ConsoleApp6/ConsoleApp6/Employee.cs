using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Employee
    {
        public string name { get ; set; }
        protected int salary { get;set; }
        public Employee()
        {
            
        }
        public Employee(string name)
        {
            this.name = name;
        }
        public Employee(int salary)
        {
            this.salary = salary;
        }
    }
}

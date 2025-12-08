using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absClassEmployee
{
    internal class Program
    {
        abstract class Employee
        {
            public double basicSalary;
            public Employee(double salary)
            {
                basicSalary = salary;
            }

            public abstract double GetTotalSalary();
        }

        class Manager : Employee
        {
            public Manager(double salary) : base(salary) { }

            public override double GetTotalSalary()
            {
                return basicSalary + 2000;
            }
        }

        class Worker : Employee
        {
            public Worker(double salary) : base(salary) { }

            public override double GetTotalSalary()
            {
                return basicSalary + 800;
            }
        }
        static void Main(string[] args)
        {
            Employee m = new Manager(10000);
            Employee w = new Worker(8000);

            Console.WriteLine("Manager Salary: " + m.GetTotalSalary());
            Console.WriteLine("Worker Salary: " + w.GetTotalSalary());
        }
    }
}

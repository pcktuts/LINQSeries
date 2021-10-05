using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQSeries
{
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Desgination { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Why you should use LINQ?
             */
            List<Employee> Employees = new List<Employee>()
            {
                new Employee(){Name="Krishna", Salary= 15000, Desgination = "Developer"},
                new Employee(){Name="Peter", Salary= 25000, Desgination = "Developer"},
                new Employee(){Name="Joseph", Salary= 35000, Desgination = "Manager"},
                new Employee(){Name="Athira", Salary= 11000, Desgination = "Developer"},
            };

            foreach (var item in Employees)
            {
                if(item.Desgination == "Manager")
                {
                    Console.WriteLine($"{item.Name}, {item.Desgination}");
                }
            }
            var managers = from e in Employees
                           where e.Desgination == "Manager"
                           select e;
            foreach (var item in managers)
            {
                Console.WriteLine($"{item.Name} {item.Desgination}");
            }

            List<int> nums = new List<int> {22, 45, 66, 88, 90,77 };
            var evenNums = nums.Where(n => n % 2 == 0);
            foreach (var item in evenNums)
            {
                Console.WriteLine(item);
            }
        }
    }
}

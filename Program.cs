using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LINQSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} \n\n", num);
            }

            // LINQ query from XML
            // 1. Data source.
            XElement contacts = XElement.Load(@"C:\Users\krishnadas\source\repos\LINQSeries\contacts.xml");
            // 2. Query creation.
            IEnumerable<XElement> employees = from el in contacts.Elements("Employee")
                                              where (int)el.Element("EmpId") == 1
                                              select el;

            // 3. Query execution.
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}

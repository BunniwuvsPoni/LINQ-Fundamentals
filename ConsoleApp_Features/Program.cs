using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var developers = new Employee[]
            {
                new Employee { Id = 1, Name="Scott" },
                new Employee { Id = 2, Name="Chris" },
                new Employee { Id = 2, Name="Christian" }
            };

            var sales = new List<Employee>()
            {
                new Employee { Id = 3, Name="Alex" }
            };

            //  Method syntax
            var method = developers.Where(e => e.Name.Length == 5)
                                    .OrderBy(e => e.Name)
                                    .Select(e => e);

            //  Query syntax
            var query = from developer in developers
                        where developer.Name.Length == 5
                        orderby developer.Name
                        select developer;

            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}

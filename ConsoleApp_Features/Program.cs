﻿using System;
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
                new Employee { Id = 2, Name="Chris" }
            };

            var sales = new List<Employee>()
            {
                new Employee { Id = 3, Name="Alex" }
            };

            Console.WriteLine(developers.Count);
        }
    }
}
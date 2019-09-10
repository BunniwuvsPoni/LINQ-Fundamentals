using System;
using System.Collections.Generic;

namespace ConsoleApp_Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var movies = new List<Movie>
            {
                new Movie {Title = "The Dark Knight", Rating = 8.9f, Year = 2013},
                new Movie {Title = "The King's Speech", Rating = 8.0f, Year = 2017},
                new Movie {Title = "Casablanca", Rating = 8.5f, Year = 1985},
                new Movie {Title = "Star Wars V", Rating = 8.7f, Year = 1956}
            };
        }
    }
}

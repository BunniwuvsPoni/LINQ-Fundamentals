using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = @"C:\Windows";
            ShowLargeFilesWithoutLINQ(path);
            Console.WriteLine("***");
            ShowLargeFilesWithLINQ(path);
        }

        private static void ShowLargeFilesWithLINQ(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;
            foreach(var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFilesWithoutLINQ(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);  //  Creates new directory object to pull file information
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());  //  Sorts returned files
            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name, -20} : {file.Length, 10:N0}");
            }
        }
    }

    public class FileInfoComparer : IComparer<FileInfo> //  Old way of doing comparison
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}

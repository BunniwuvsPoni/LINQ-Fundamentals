using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = @"C:\Windows";
            ShowLargeFilesWithoutLINQ(path);
        }

        private static void ShowLargeFilesWithoutLINQ(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);  //  Creates new directory object to pull file information
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());  //  Sorts returned files
            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} : {file.Length}");
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

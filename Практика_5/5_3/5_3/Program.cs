﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace _5_3
{
    class Program
    {
        static string path;
        static void Search(DirectoryInfo dr, string filename)
        {
            FileInfo[] fi = dr.GetFiles();
            foreach (FileInfo info in fi)
            {
                if (info.Name == filename)
                {
                    path = info.FullName;
                    Console.WriteLine(path);
                }
            }
            DirectoryInfo[] dirs = dr.GetDirectories();
            foreach (DirectoryInfo directoryInfo in dirs)
            {
                Search(directoryInfo, filename);
            }
        }

        static void Main(string[] args)
        {
            string filename = "file.txt";

            DirectoryInfo dr = new DirectoryInfo(@"C:\file\file");
            Search(dr, filename);

            if (path == null)
                Console.WriteLine("такого файла нет");
            else
            {
                Process proc = Process.Start("notepad.exe", path);
                proc.WaitForExit();
                proc.Close();
            }
            
            Console.ReadLine();

            path = path.Replace(filename, "");

            ZipFile.CreateFromDirectory(path, @"C:\file\file\notepad.zip");

            Console.ReadLine();
        }
    }
}

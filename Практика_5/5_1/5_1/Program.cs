using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _5_1
{
    internal class Program
    {
        static string q = @"C:\file\file";
        static void Main(string[] args)
        {
            DirectoryInfo directoryinfo = new DirectoryInfo("folder");
            Console.WriteLine("Директории созданы");

            for (int i = 0; i <= 100; i++)
                if (!directoryinfo.Exists)
                    Directory.CreateDirectory(q + i);


            Console.ReadLine();

            for (int i = 0; i <= 100; i++)
                if (!directoryinfo.Exists)
                    Directory.Delete(q + i);
        }
    }
}

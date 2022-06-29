using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\file\file\test1.txt";
            Console.WriteLine("Файл создан\n");

            StreamWriter sw = new StreamWriter(path);
            Console.WriteLine("Введите данные для файла: ");
            sw.Write(Console.ReadLine());
            sw.Close();

            StreamReader sr = new StreamReader(@"C:\file\file\test1.txt");
            Console.WriteLine("\nСодержимое файла:");

            for (int i = 0; i < File.ReadAllLines(@"C:\file\file\test1.txt").Length; i++)
                Console.WriteLine(sr.ReadLine());

            Console.ReadKey();
        }
    }
}

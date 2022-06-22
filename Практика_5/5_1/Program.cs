using System;
using System.IO;

namespace _5_1
{
    class Program
    {
        static string path = @"C:\\Folder";
        static void Main(string[] args)
        {
            DirectoryInfo directoryinfo = new DirectoryInfo("Folder");

            for (int i = 0; i <= 100; i++)
                if (!directoryinfo.Exists)
                    Directory.CreateDirectory(path + i);

            Console.WriteLine("Для удаления нажмите enter ");
            Console.ReadLine();

            for (int i = 0; i <= 100; i++)
                if (!directoryinfo.Exists)
                    Directory.Delete(path + i);
            Console.WriteLine("~Все папки удалены~");
            
        }
    }
}
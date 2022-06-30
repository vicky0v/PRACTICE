using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    List<string> numbers = new List<string>();
                    Console.WriteLine("Введите числа через пробел: ");
                    var input = Console.ReadLine().Trim().Split();
                    var list = new List<int>(input.Select((int.Parse)));

                    Console.WriteLine("Введите операцию 1 - sum, 0 - exit: ");
                    int g = Convert.ToInt32(Console.ReadLine());
                    int res = 0;

                    Console.WriteLine("Результат: ");
                    if (g == 1)
                    {
                        for (int i = 0; i < list.Count; i++)
                            res += list[i];

                        Console.WriteLine(res + "\n");

                        Console.WriteLine("Продолжить? (1 - продолжить, 0 - exit)");
                        int pr = Convert.ToInt32(Console.ReadLine());
                        if (pr == 0)
                            Process.GetCurrentProcess().Kill();
                        if (pr == 1)
                            continue;
                    }
                    if (g == 0)
                        Process.GetCurrentProcess().Kill();
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}

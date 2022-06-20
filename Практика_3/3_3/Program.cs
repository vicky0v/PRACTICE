using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public static class ColorType
    {
        enum Colors
        {
            DarkBlue = 1,
            Yellow = 2,
            Red = 3,
            Black = 4,
            DarkGreen = 5

        }
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;

                default:
                    Console.WriteLine("ОШИБКА");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цвет: \n1 - Синий, \n2 - Жёлтый, \n3 - Красный, \n4 - Чёрный, \n5 - Зелёный");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            ColorType.Print(str, col);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle
    {
        private double side1, side2;

        public double Area
        {
            get { return this.AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return this.PerimeterCalculator(); }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;

            Console.Write("Длина первой стороны: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Длина второй стороны: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Rectangle n1 = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника равна {0}", n1.Area);
            Console.WriteLine("Периметр прямоугольника равен {0}", n1.Perimeter);
            Console.ReadKey();
        }
    }
}

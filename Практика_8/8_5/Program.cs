using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5
{
    class Program
    {
        class Stew
        {
            public string name;
            public int year;
            public int date;

            public Stew(string n, int y, int d)
            {
                name = n;
                year = y;
                date = d;
            }
        }
        static void Main(string[] args)
        {
            List<Stew> lstTush = new List<Stew>()   {
                new Stew("Тушенка№1", 2018, 2),
                new Stew("Тушенка№2", 2021, 1),
                new Stew("Тушенка№3", 2010, 1),
                new Stew("Тушенка№4", 2016, 2),
                new Stew("Тушенка№5", 2022, 2),
                new Stew("Тушенка№6", 2021, 2)};

            IEnumerable<Stew> StewQuery = from tush in lstTush
                                          where tush.year + tush.date < 2022
                                          select tush;

            foreach (Stew a in StewQuery)
            {
                Console.WriteLine(a.name);
            }
            Console.ReadLine();
        }
    }
}
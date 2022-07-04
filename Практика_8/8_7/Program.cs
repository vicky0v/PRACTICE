using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7
{
    class Program
    {
        class Soldier
        {
            public string name;
            public string squad;
            public string rank;
            public int time;

            public Soldier(string n, string a, string r, int t)
            {
                name = n;
                squad = a;
                rank = r;
                time = t;
            }
        }
        static void Main(string[] args)
        {
            List<Soldier> SoldierList1 = new List<Soldier>()   {

                new Soldier("Ефремова Инга Артемовна", "Воинское", "Полковник",24),
                new Soldier("Смирнов Эльдар Созонович", "Антиправительственное", "Полковник",24),
                new Soldier("Капустина Гелена Станиславовна", "Экономическое", "Рядовой",18),
                new Soldier("Емельянов Тихон Мэлорович","Экономическое", "Сержант",12)
            };

            List<Soldier> SoldierList2 = new List<Soldier>() {

                new Soldier("Смирнов Эльдар Созонович", "Стрелковое", "Генерал армии", 36),
                new Soldier("Емельянов Тихон Мэлорович", "Стрелковое", "Лейтенант", 24)
            };

            Console.WriteLine("Первый отряд до: ");
            foreach (Soldier a in SoldierList1)
            {
                Console.WriteLine(a.name);
            }
            Console.WriteLine("\nВторой отряд до:");
            foreach (Soldier a in SoldierList2)
            {
                Console.WriteLine(a.name);
            }

            IEnumerable<Soldier> Sold1 = from soldier in SoldierList1
                                         where soldier.name[0] == 'Б'
                                         select soldier;

            List<Soldier> Sold2 = new List<Soldier>();
            foreach (Soldier a in Sold1)
            {
                Sold2.Add(a);
            }

            foreach (Soldier a in Sold2)
            {
                SoldierList2.Add(a);
                SoldierList1.Remove(a);
            }


            Console.WriteLine("\n\nПервый отряд после: ");
            foreach (Soldier a in SoldierList1)
            {
                Console.WriteLine(a.name);
            }
            Console.WriteLine("\nВторой отряд после: ");
            foreach (Soldier a in SoldierList2)
            {
                Console.WriteLine(a.name);
            }
            Console.ReadLine();
        }
    }
}

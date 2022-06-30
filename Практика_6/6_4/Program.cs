using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _6_4
{
    class Program
    {
        static Dictionary<string, string> dossier = new Dictionary<string, string>();
        static void Add()
        {
            Console.WriteLine("\nВведите ФИО работника: ");
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
                name = name.Replace(" ", " ").Trim();

            Console.WriteLine("\nВведите должность: ");
            string job = Console.ReadLine();

            for (int i = 0; i < job.Length; i++)
                job = job.Replace(" ", " ").Trim();

            dossier.Add(name, job);
        }

        static void Show()
        {
            IDictionaryEnumerator de = dossier.GetEnumerator();
            int k = 1;
            while (de.MoveNext())
            {
                Console.WriteLine(k + " - " + Convert.ToString(de.Key).Replace(" ", " - ") + " - " + de.Value);
                k++;
            }
        }

        static void Delete()
        {
            Show();
            Console.WriteLine("\nВведите номер досье для удаления: ");
            int n = Convert.ToInt32(Console.ReadLine());
            IDictionaryEnumerator my = dossier.GetEnumerator();
            int k = 1;
            while (my.MoveNext() && k != n)
                k++;
            dossier.Remove(Convert.ToString(my.Key));
        }

        static void Search()
        {
            IDictionaryEnumerator meee = dossier.GetEnumerator();
            Console.WriteLine("\nВведите фамилию работника для поиска: ");
            string surname = Console.ReadLine();
            bool check = true;
            while (meee.MoveNext())
            {
                string word = Convert.ToString(meee.Key);
                if (word.Contains(surname))
                {
                    Console.WriteLine(word);
                    check = false;
                }
            }
            if (check)
            {
                Console.WriteLine("Работника с данной фамилией не существует.");
            }
        }
        static void Exit()
        {
            Process.GetCurrentProcess().Kill();
        }

        static void Main(string[] args)
        {
            int res = 1;
            while (res != 5)
            {
                Console.WriteLine("\nВыберите действия: (1 - добавить досье, 2 - вывести все досье, 3 - удалить досье, 4 - поиск по фамилии, 5 - выход)");
                try
                {
                    res = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("error");
                    continue;
                }

                try
                {
                    switch (res)
                    {
                        case 1:
                            Add();
                            break;
                        case 2:
                            Show();
                            break;
                        case 3:
                            Delete();
                            break;
                        case 4:
                            Search();
                            break;
                        case 5:
                            Exit();
                            break;
                        case 6:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
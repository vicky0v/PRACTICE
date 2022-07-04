using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        class Human
        {
            public string name;
            public int age;
            public string illness;

            public Human(string name, int age, string illness)
            {
                this.name = name;
                this.age = age;
                this.illness = illness;
            }
        }

        static void Main(string[] args)
        {
            List<Human> PatienceList = new List<Human>() {
                new Human("Яковлева Ольга Адольфовна", 56, "Сколиоз"),
                new Human("Самойлова Аделина Богуславовна", 26, "Анемия"),
                new Human("Сысоева Божена Дамировна", 35, "Сколиоз"),
                new Human("Меркушева Фия Александровна", 48, "Анемия"),
                new Human("Лебедева Юнона Святославовна", 69, "Пневмония"),
                new Human("Алексеев Лаврентий Валерьевич", 23, "Пневмония"),
                new Human("Анисимов Пантелей Вадимович", 18, "Пневмония"),
                new Human("Фокин Тарас Антонинович", 69, "Пневмония"),
                new Human("Щербаков Иннокентий Ефимович", 18, "Пневмония"),
                new Human("Журавлёв Нисон Митрофанович", 18, "Пневмония"),
            };

            int res = 5;
            IEnumerable<Human> patients;
            while (res != 0)
            {
                Console.WriteLine("Выберите действие: \n\n1 - Отсортировать пациентов по фио \n2 - Отсортировать пациентов по возрасту \n3 - Вывести пациентов с определенным заболеванием \n0 - Выход");
                res = Convert.ToInt32(Console.ReadLine());
                if (res == 1)
                {
                    patients = from ppl in PatienceList
                               orderby ppl.name
                               select ppl;
                }
                else if (res == 2)
                {
                    patients = from ppl in PatienceList
                               orderby ppl.age
                               select ppl;
                }
                else if (res == 3)
                {
                    Console.WriteLine("Введите название заболевания: ");
                    string name = Console.ReadLine().Trim();
                    patients = from human in PatienceList
                               where human.illness == name
                               select human;
                }
                else
                    continue;

                foreach (Human a in patients)
                {
                    Console.WriteLine(a.name + " - " + a.age + " - " + a.illness);
                }
                Console.WriteLine();
            }
        }
    }
}

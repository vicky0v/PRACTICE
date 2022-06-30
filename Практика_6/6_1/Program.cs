using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        public static Dictionary<string, string> list = new Dictionary<string, string>();
        public static void Pull()
        {
            Dictionary<string, string> list2 = new Dictionary<string, string>();
            
        }

        public static string Check(string str)
        {
            Dictionary<string, string> list2 = new Dictionary<string, string>();
            list.Add("Параметр_функции", "Переменная,которая используется в функции и значение которой предоставляет вызывающий объект ");
            list.Add("Аргумент_функции", "Значение, которое передается из caller в функцию и которое указывается в скобках при вызове функции");
            list.Add("Присваивание", "После объявления переменной, можно присвоить значение с помощью оператора присваивания");
            list.Add("Библиотека", "Набор скомлилированного кода, который может использоваться для повторного использования других программ");
            list.Add("Стейтмейт", "Это наиболее распространённый тип инструкций в программах. Это и есть та самая инструкция, наименьшая независимая единица в языке С++");
            list.Add("Выражение", "Математически объект, создаваемый для проведения вычислений и нахождения соответсвующего результата ");
            list.Add("Альфа-тестирование", "Это ручное тестирование потенциальными пользователями, заказчиками или независимой командой тестирования на стенде разработки.");
            list.Add("Бето-тестирование", "Интенсивное использование почти готовой версии продукта с целью выявления максимального числа ошибок в его работе для их последующего устранения перед окончательным выходом продукта на рынок, к массовому потребителю");
            list.Add("Перечисления", "Тип данных где лююбое значение определяется как символьная константа");
            list.Add("Вектор", "Это шаблон из стандартной библиотеки C++, реализующий динамический массив");
            list.Add("Литеральные_константы", "Запись в исходном коде компьютерной программы, представляющая собой фиксированное значение.");
            list.Add("Указатель", "Переменная, диапазон значений которой состоит из адресов ячеек памяти или специального значения — нулевого адреса");
            list.Add("Компаратор", "Это функция, которая как бы учит сортировать sort");
            list.Add("Инкапсуляция", "Свойство системы позволяющиее объединить данные и методы работающие с нимив классе.");
            list.Add("Наследование", "Свойство системы позволяющие описать новый класс на основе уже существующегос частичной или полньстью заимсвтовающей функциональностью");
            list.Add("Полиморфизм", "Свойство программного кода изменять свое поведение в зависимости от ситуации, возникающей при выполнении программы");
            list.Add("Консруктор", "Особый тип метода класса который автомаически вызывается при создании объекта этого же класса");
            list.Add("Тестирование", "Проверка соответствоания между реальным и ожидаемым поведением программы осущетсвляя на конечном наборе тестов выбранном определённым образом");
            list.Add("Тест_план", "Документ описывающий весь объект работ по тестированию наичная с описания объекта ");
            list.Add("Програмирование", "процесс создания компьютерных программ.");

            int k = 0;
            string near = null;

            int count = str.Length;

            IDictionaryEnumerator myEnumerator = list.GetEnumerator();

            while (myEnumerator.MoveNext())
            {
                string word = Convert.ToString(myEnumerator.Key);
                if (str.Length != word.Length)
                    continue;

                for (int i = 0; i < str.Length; i++)
                {
                    string a1 = Convert.ToString(str[i]);
                    string a2 = Convert.ToString(word[i]);
                    if (a1.ToLower() == a2.ToLower())
                    {
                        k++;
                    }
                }
                if (count - 1 <= k)
                {
                    near = word;
                }
                k = 0;
            }
            return near;
        }

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Pull();
                    Console.WriteLine("Введите слово: ");
                    string text = Console.ReadLine().ToLower().Trim();
                    while (text != "0")
                    {
                        string word;
                        string opr;

                        if (list.TryGetValue(text, out opr))
                            Console.WriteLine(opr);
                        else
                        {
                            word = Check(text);
                            if (word == null)
                                Console.WriteLine("Данного слова не существует в словаре");
                            else
                            {
                                Console.WriteLine("Слово не найдено. Вы имели ввиду \"" + word + "\"" + "? " + "(1 - yes)");
                                int x = Convert.ToInt32(Console.ReadLine());
                                if (x == 1)
                                {
                                    list.TryGetValue(word, out opr);
                                    Console.WriteLine(opr);
                                }

                            }
                        }
                        Console.WriteLine("\nДля выхода нажмите 0 или введите следующее слово:");
                        text = Console.ReadLine().ToLower().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

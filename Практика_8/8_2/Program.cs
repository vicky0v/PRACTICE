using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {

        class Criminal
        {
            public string name;
            public string сrime;

            public Criminal(string name, string сrime)
            {
                this.name = name;
                this.сrime = сrime;
            }
        }

        static void Main(string[] args)
        {
            List<Criminal> Criminals = new List<Criminal>(){
                new Criminal("Устинова Амина Филипповна", "Антиправительственное"),
                new Criminal("Фадеева Диана Пантелеймоновна","Антиправительственное"),
                new Criminal("Миронова Астра Адольфовна", "Воинское"),
                new Criminal("Калашникова Ариадна Глебовна", "Антиправительственное"),
                new Criminal("Григорьев Касьян Богуславович", "Экономическое"),
                new Criminal("Сысоев Клим Ильяович","Экономическое"),
             };

            try
            {
                IEnumerable<Criminal> CrimList = from ppl in Criminals
                                                 where
                       ppl.сrime != "Антиправительственное"
                                                 select ppl;

                Console.WriteLine("Список до амнистии: \n");
                foreach (Criminal a in Criminals)
                {
                    Console.WriteLine(a.name + " - " + a.сrime);
                }

                Console.WriteLine("\n\nСписок после амнистии: \n");
                foreach (Criminal a in CrimList)
                {
                    Console.WriteLine(a.name + " - " + a.сrime);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

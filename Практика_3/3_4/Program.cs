using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    enum Employees
    {
        Junior_Developer = 98,
        Developer = 100,
        Senior_Developer = 156,
        Team_leader = 189,
        Project_Manager = 200
    }

    class Accauntant
    {
        public bool AskForBonus(Employees PostWorker, int hours)
        {
            if ((int)PostWorker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant a = new Accauntant();
            Console.WriteLine(a.AskForBonus(Employees.Junior_Developer, 100));
            Console.WriteLine(a.AskForBonus(Employees.Developer, 101));
            Console.WriteLine(a.AskForBonus(Employees.Senior_Developer, 158));
            Console.WriteLine(a.AskForBonus(Employees.Team_leader, 188));
            Console.WriteLine(a.AskForBonus(Employees.Project_Manager, 198));
            Console.ReadKey();
        }
       
    }
    
}

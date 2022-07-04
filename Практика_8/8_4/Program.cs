using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
        class Player
        {
            public string name;
            public int level;
            public int force;


            public Player(string name, int level, int force)
            {
                this.name = name;
                this.level = level;
                this.force = force;
            }
        }
        static void Main(string[] args)
        {


            List<Player> PlayerList = new List<Player>() {
            new Player("Панфилов Вениамин Геласьевич", 97, 721),
            new Player("Беспалов Ростислав Натанович", 61, 401),
            new Player("Копылов Мартын Евсеевич", 32, 273),
            new Player("Шаров Лаврентий Анатольевич", 82, 689),
            new Player("Гущин Корнелий Еремеевич", 18, 189),
            new Player("Ефремова Инга Артемовна", 42, 365),
            new Player("Капустина Гелена Станиславовна", 32, 273),
            new Player("Шарапова Есения Вячеславовна", 61, 401),
            new Player("Юдина Галина Олеговна", 97, 721),

            };


            Console.WriteLine("Топ 3 игроков по уровню: ");

            IEnumerable<Player> playerss = from plr in PlayerList
                                           orderby plr.level descending
                                           select plr;
            foreach (Player a in playerss.Take(3))
            {
                Console.WriteLine(a.name + "\t" + a.level + "\t" + a.force);
            }

            Console.WriteLine("\nТоп 3 игроков по силе: ");

            playerss = from plr in PlayerList
                       orderby plr.force descending
                       select plr;

            foreach (Player a in playerss.Take(3))
            {
                Console.WriteLine(a.name + "\t" + a.level + "\t" + a.force);
            }

            Console.ReadLine();
        }
    }
}

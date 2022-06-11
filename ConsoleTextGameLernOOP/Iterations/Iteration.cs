using ConsoleTextGameLernOOP.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextGameLernOOP.Iteration
{
    public static class Interaction
    {
        public static void InteracionChar()
        {
            Console.WriteLine("Вы встретили торговца");
        }
        
        public static void Battle(Player player, Player player1)
        {
            bool temp = false;
            Console.WriteLine($"Вы встретили врага {player1.name} у него {player1.level} уровень.");
            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1.Атака");
                Console.WriteLine("2.Отступаем");
                string val = Console.ReadLine();
                if (val == "1" || val == "2")
                {
                    temp = true;
                    switch (val)
                    {
                        case "1":
                            Console.WriteLine("Вы решили начать бой");
                            player.Attack(player, player1);
                            break;

                        case "2":
                            Console.WriteLine("Вы решили отступить");
                            temp = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Такого действия не существует");
                }

            } while (temp);
        }
    }
}

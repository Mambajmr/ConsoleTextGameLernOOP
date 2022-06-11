using ConsoleTextGameLernOOP.GameObject;
using ConsoleTextGameLernOOP.Person;
using ConsoleTextGameLernOOP.Iteration;
using System;

namespace ConsoleTextGameLernOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Player player = new Player();
            player.name = "Артем";
            player.level = 2;
            player.hp = 100;
            player.mp = 100;
            player.money = 100;
            player.chartPointX = 0;
            player.chartPointY = 0;
            player.agl = 2;
            player.str = 3;
            player.intl = 1;


            Player AngryBird = new Player();
            AngryBird.name = "AngryBird";
            AngryBird.level = 4;
            AngryBird.hp = 100;
            AngryBird.money = 100;
            AngryBird.chartPointX = 30;
            AngryBird.chartPointY = 30;


            NPC npc = new NPC();
            npc.name = "Вася";


            (x, y) = player.Move(player.chartPointX, player.chartPointY);

            if (x == AngryBird.chartPointX && y == AngryBird.chartPointY)
            {
                Console.WriteLine("Proverka Zahoda");
                Interaction.Battle(player, AngryBird);
            }

        }
    }
}

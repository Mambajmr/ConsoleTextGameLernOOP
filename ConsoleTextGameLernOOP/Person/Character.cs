using ConsoleTextGameLernOOP.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextGameLernOOP.Person
{
    public class Character
    {

        public string name { get; set; }
        public int level { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }
        public int money { get; set; }
        public int chartPointX { get; set; }
        public int chartPointY { get; set; }

        public Tuple<int, int> Move(int x, int y)
        {
            Map map = new Map();
            int step;
            Console.WriteLine("Выберите направление движение с помощью стрелок клавиатуры");
            ConsoleKey move;
            while ((move = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                switch (move)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine($"Сколько шагов вперед вы хотите сделать?");
                        step = Convert.ToInt32(Console.ReadLine());
                        if (y + step < map.pointY)
                        {
                            y += step;
                            Console.WriteLine($"Вы сделали {step} шагов вперед");
                        }
                        else
                        {
                            Console.WriteLine("Путь закрыт, дальше земля драконов");
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        Console.WriteLine($"Сколько шагов назад вы хотите сделать?");
                        step = Convert.ToInt32(Console.ReadLine());
                        if (y - step > 0)
                        {
                            Console.WriteLine($"Вы сделали {step} шагов назад");
                            y -= step;
                        }
                        else
                        {
                            Console.WriteLine("Путь закрыт, дальше земля драконов");
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.WriteLine($"Сколько шагов влево вы хотите сделать?");
                        step = Convert.ToInt32(Console.ReadLine());
                        if (x - step > 0)
                        {
                            Console.WriteLine($"Вы сделали {step} шагов влево");
                            x -= step;
                        }
                        else
                        {
                            Console.WriteLine("Путь закрыт, дальше земля драконов");
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        Console.WriteLine($"Сколько шагов вправо вы хотите сделать?");
                        step = Convert.ToInt32(Console.ReadLine());
                        if (x + step < map.pointY)
                        {
                            Console.WriteLine($"Вы сделали {step} шагов вправо");
                            x += step;
                        }
                        else
                        {
                            Console.WriteLine("Путь закрыт, дальше земля драконов");
                        }
                        break;
                }
            }

            return Tuple.Create(x, y);
        }
    }
}

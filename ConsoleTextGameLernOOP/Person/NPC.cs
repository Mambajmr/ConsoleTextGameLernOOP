using ConsoleTextGameLernOOP.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextGameLernOOP.Person
{
    public class NPC : Character, Item
    {
        public string NameItem { get; set; }
        public int damageItem { get; set; }
        public int CostItem { get; set; }

        public void Trade(Player player, NPC npc)
        {
            if (player.money >= npc.CostItem)
            {
                player.money -= npc.CostItem;
                Console.WriteLine($"Вы купили у {npc.name} предмет {npc.NameItem} за {npc.CostItem}");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег для покупки {npc.NameItem}");
            }
        }

    }
}

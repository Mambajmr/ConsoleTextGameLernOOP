using ConsoleTextGameLernOOP.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextGameLernOOP.Person
{
    public class Player : Character, Item
    {
        public string className { get; set; }
        public int str { get; set; }
        public int agl { get; set; }
        public int intl { get; set; }
        public string NameItem { get; set; }
        public int damageItem { get; set; }
        public int CostItem { get; set; }

        public void Attack(Player player, Player player1)
        {
            int damage = this.str + this.agl + this.intl + level + damageItem;
            if (player.level < player1.level + 5)
            {
                Console.WriteLine($"{player1.name} заблокировал вашу атаку!!!");
            }
            else
            {
                Console.WriteLine($"{player} совершает атаку {player.NameItem} на {damage} HP врагу {player1}");
                player1.hp -= damage;
                Die(player1);
            }
        }

        public void Die(Player player)
        {
            Console.WriteLine($"{player.name} погибает...");
        }

    }
}

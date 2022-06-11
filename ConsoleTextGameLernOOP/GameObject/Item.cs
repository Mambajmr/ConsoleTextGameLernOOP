using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextGameLernOOP.GameObject
{
    public interface Item
    {

        public string NameItem { get; set; }
        public int CostItem { get; set; }
        public int damageItem {get; set;}
    }
}

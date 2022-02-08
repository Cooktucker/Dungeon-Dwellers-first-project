using Dungeon_Dwellers.Items.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Adventures.Models
{
    public class Chest
    {
        public bool Locked = false;
        public Trap Trap;
        public List<Item> Treasure;
        public int Gold;
    }
}

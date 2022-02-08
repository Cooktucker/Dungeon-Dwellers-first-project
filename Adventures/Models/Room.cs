using Dungeon_Dwellers.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Adventures.Models
{
    public class Room
    {
        public int RoomNumber;
        public string Description;
        public Trap Trap;
        public List<Monster> Monsters;
        public Chest Chest;
        public Objective FinalObjective;
    }
}

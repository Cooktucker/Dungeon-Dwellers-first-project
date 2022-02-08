using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Adventures.Models
{
    public class Objective
    {
        public ObjectType ObjectType;
    }

    public enum ObjectType
    {
        MonsterInRoom,
        AllMonsters,
        ItemObtained
    }
}

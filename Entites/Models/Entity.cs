using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Entites.Models
{
    public abstract class Entity
    {
        public int Hitpoints = 0;
        public Attack Attack;
    }

    public class Attack
    {
        public int BaseDie;
        public int BonusDamage;
    }
}

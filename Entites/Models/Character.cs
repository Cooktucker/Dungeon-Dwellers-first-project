using Dungeon_Dwellers.Items.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Entites.Models
{
    public class Character : Entity
    {
        public string Name;
        public int Level;
        public Abilities Abilities;
        public int Gold;
        public string BackGround;
        public int InventoryWeight;
        public List<string> AdventuresPlayed;
        public bool IsAlive;
        public int ArmorClass;
        public List<IItem> Inventory;
        public CharacterClass Class;

    }

    public class Abilities
    {
        public int Strength;
        public int Dexterity;
        public int Consitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;


    }

    public enum CharacterClass
    {
        Fighter,
        Thief,
        Wizard,
        Priest,
    }
}

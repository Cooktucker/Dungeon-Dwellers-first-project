using Dungeon_Dwellers.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Entites.Interfaces
{
    public interface ICharacterService
    {
        public Character LoadCharacter(string name);

        public List<Character> GetCharactersInRange( int minLevel = 0, int maxLevel = 20);
    }
}

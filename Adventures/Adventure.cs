using Dungeon_Dwellers.Adventures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Adventures
{
    public class Adventure
    {
        public string GUID;
        public int CompletionXPReward;
        public int CompletionGoldReward;
        public int MaxLevel;
        public int MinimumLevel;
        public string Title;
        public string Description;
        public List<Room> Rooms;


        public Adventure()
        {
            
        }

        /// <summary>
        /// THIS CLASS DOES THIS AND DOES THAT
        /// </summary>
        public void MyMethod()
        {

        }

    }
    
}

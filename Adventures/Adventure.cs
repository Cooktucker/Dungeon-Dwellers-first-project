using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Adventures
{
    public class Adventure
    {
        public string GUID { get; set; }
        public int CompletionXPReward { get; set; }
        public int CompletionGoldReward { get; set; }
        public int MaxLevel { get; set; }
        public int MinimumLevel { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

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

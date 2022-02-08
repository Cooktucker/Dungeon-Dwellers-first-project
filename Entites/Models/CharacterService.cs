using Dungeon_Dwellers.Entites.Interfaces;
using Dungeon_Dwellers.Entites.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Entites
{
    public class CharacterService : ICharacterService
    {
        
        Character ICharacterService.LoadCharacter(string name)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Characters";
            var character = new Character();

            if (File.Exists($"{basePath}\\{name}.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var CharacterJsonFile = directory.GetFiles($"{name}.json");

                using (StreamReader fi = File.OpenText(CharacterJsonFile[0].FullName))
                {
                    character = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }


            }
            else
            {
                throw new Exception(" character not found.");
            }
            return character;
        }

        public List<Character> GetCharactersInRange(int minLevel = 0, int maxLevel = 20)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Characters";
            var charactersInRange = new List<Character>();

            try
            {
                var directory = new DirectoryInfo(basePath);
                foreach (var file in directory.GetFiles($"*.json"))
                {
                    using (StreamReader fi = File.OpenText(file.FullName))
                    {
                        var potentialCharacterInRange = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                        if (potentialCharacterInRange.IsAlive && (potentialCharacterInRange.Level >= minLevel && potentialCharacterInRange.Level <= maxLevel))
                        {
                            charactersInRange.Add(potentialCharacterInRange);
                        }
                    }       
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"KaBOOM! The mice are at it again something went wrong!!{ex.Message}");
            }

            return charactersInRange;
        }
    }
}

using Dungeon_Dwellers.Adventures;
using Dungeon_Dwellers.Adventures.Interfaces;
using Dungeon_Dwellers.Entites.Interfaces;
using Dungeon_Dwellers.Entites.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Dwellers.Game
{
    public class GameService
    {
        private IadventureService adventureService;
        private ICharacterService characterService;

        private Character character;
        public GameService(IadventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }
        public bool StartGame(Adventure adventure = null)
        {
            try
            {
                if (adventure == null)
                {
                    adventure = adventureService.GetInitialAdventure();
                }

                Console.Clear();
                Console.WriteLine();

                //Create Title Banner
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if(i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }
                Console.WriteLine($"| { adventure.Title } |");
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{adventure.Description.ToUpper()}");

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;


                var charactersInRange = characterService.GetCharactersInRange(adventure.MinimumLevel, adventure.MaxLevel);

                if(charactersInRange.Count == 0)
                {
                    Console.WriteLine("Sorry you do not have any characters in range of the adventure you are trying to play.");
                    return false;
                }
                else
                {
                    Console.WriteLine("WHO DARES ENTER MY DUNGEON!!");
                    var characterCount = 0;
                    foreach (var character in charactersInRange)
                    {
                        Console.WriteLine($"#{characterCount} {character.Name} Level - {character.Level} {character.Class}");
                        characterCount++;
                    }
                }
                character = characterService.LoadCharacter(charactersInRange[Convert.ToInt32(Console.ReadLine())].Name);

             

            }
            catch (Exception ex)
            {
                Console.WriteLine($"KaBOOM! The mice are at it again something went wrong!!{ex.Message}");
            }
            return true;
        }
    }
}

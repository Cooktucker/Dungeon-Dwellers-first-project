using Dungeon_Dwellers.Adventures;
using Dungeon_Dwellers.Entites;
using Dungeon_Dwellers.Entites.Interfaces;
using Dungeon_Dwellers.Game;
using Newtonsoft.Json;
using System;
using System.IO;

namespace DungeonDwellers
{
    class program
    {
        private static AdventureService adventureService = new AdventureService();
        private static CharacterService characterService = new CharacterService();
        private static GameService gameService = new GameService(adventureService, characterService);
        static void Main(string[] args)
        {
            MakeTitle();
            MakeMenu();
        }

        private static void MakeTitle()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*   ______   __   __  ______   _______  _______  _______  __    _             *");
            Console.WriteLine("*  |      | |  | |  ||      | |       ||       ||       ||  |  | |            *");
            Console.WriteLine("*  |  _    ||  | |  ||  _    ||    ___||    ___||   _   ||   |_| |            *");
            Console.WriteLine("*  | | |   ||  |_|  || | |   ||   | __ |   |___ |  | |  ||       |            *");
            Console.WriteLine("*  | |_|   ||       || |_|   ||   ||  ||    ___||  |_|  ||  _    |            *");
            Console.WriteLine("*  |       ||       ||       ||   |_| ||   |___ |       || | |   |            *");
            Console.WriteLine("*  |______| |_______||______| |_______||_______||_______||_|  |__|            *");
            Console.WriteLine("*   ______   _     _  _______  ___      ___      _______  ______    _______   *");
            Console.WriteLine("*  |      | | | _ | ||       ||   |    |   |    |       ||    _ |  |       |  *");
            Console.WriteLine("*  |  _    || || || ||    ___||   |    |   |    |    ___||   | ||  |  _____|  *");
            Console.WriteLine("*  | | |   ||       ||   |___ |   |    |   |    |   |___ |   |_||_ | |_____   *");
            Console.WriteLine("*  | |_|   ||       ||    ___||   |___ |   |___ |    ___||    __  ||_____  |  *");
            Console.WriteLine("*  |       ||   _   ||   |___ |       ||       ||   |___ |   |  | | _____| |  *");
            Console.WriteLine("*  |______| |__| |__||_______||_______||_______||_______||___|  |_||_______|  *");
            Console.WriteLine("*******************************************************************************");

        }//title end method

        private static void MakeMenu()
        {
            MakeMenuOptions();
            var InputValid = false;
            while (!InputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        InputValid= true;
                        break;
                    case "C":
                        CreateCharacter();
                        InputValid = true;
                        break;
                    case "L":
                        LoadGame();
                        InputValid = true;
                        break;
                    default:
                        MakeMenuOptions();
                        Console.WriteLine("Please Choose A correct option!");
                        InputValid = false;
                        break;
                }               
            }
        }//menuoption end method

        private static void CreateCharacter()
        {
            Console.WriteLine("create charcheter");
            
        }//End charcacterCreate

       

         private static void LoadGame()
        {
            Console.WriteLine("Load a game");
        }

        private static void MakeMenuOptions()
        {
            Console.WriteLine("\n\n(S)tart game!");
            Console.WriteLine("(L)oad Game!");
            Console.WriteLine("(C)reate a character!");
        }
    }
}


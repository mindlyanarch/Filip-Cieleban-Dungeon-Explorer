using System;
using System.Collections.Generic;
using System.Media;
using System.Numerics;

namespace DungeonExplorer
{
    internal class Game
    {
        private Playable.Player player;

        private Room currentRoom;
        private EntranceRoom entranceRoom;
        private EmptyRoom room1;

        private Sword rustySword;
        private List<List<Room>> Map;
        public Game()
        {
            // Initialize the game with one room and one player

            entranceRoom = new();
            room1 = new();

            player = new("Hero", 100, entranceRoom);
            //temporary items for testing

            rustySword = new("Rusty Sword", "This has been here a long time...", 5);
            entranceRoom.Inventory.Add(rustySword);

            //Initialize map matrix
            // Map[0] 
            // Map[1]
            // Map[2] - Entrance Room [0] - Empty Room [1] 

            Map = new();
            Map.Add(new List<Room>());
            Map.Add(new List<Room>());
            Map.Add(new List<Room>());

            Map[2].Add(entranceRoom);
            Map[2].Add(room1);


        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here
                foreach (var item in Map[0])
                { Console.WriteLine(item); }

                Console.WriteLine("It's cold in here...");

                Console.WriteLine("Type 'look' to check where you are, or 'exit' to quit.");
                Console.WriteLine("Type 'inventory' to check your bag, or 'Pickup' to grab an item");
                string input = Console.ReadLine()?.ToLower();

                if (input == "look")
                {
                    player.Look();
                }
                else if (input == "pickup")
                {
                    player.PickUpItem();
                }
                else if (input == "inventory")
                {
                    player.CheckInventory();
                }
                else if (input == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That doesn't seem to be a valid command, try again:");
                }

            }
        }
    }
}
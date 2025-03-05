using System;
using System.Collections.Generic;
using System.Media;
using System.Numerics;

namespace DungeonExplorer
{
    internal class Game
    {
        private Playable.Player player;

        private EntranceRoom entranceRoom;
        private EmptyRoom room1;

        private Sword rustySword;
        public Dictionary<Room, int> Map;
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
            //Dictionary with (Room, [XY]) convention

           Map = new();

            Map.Add(entranceRoom,10);
            Map.Add(room1,20);


        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here

                Console.WriteLine("It's cold in here...");

                Console.WriteLine("Type 'look' to check where you are, or 'exit' to quit.");
                Console.WriteLine("Type 'inventory' to check your bag, or 'Pickup' to grab an item");
                string input = Console.ReadLine()?.ToLower();

                if (input == "look")
                {
                    player.Look(Map);
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
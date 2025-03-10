using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Numerics;

namespace DungeonExplorer
{
    internal class Game
    {

        //Declare objects:

        //player
        private Player player;

        //Rooms
        private EntranceRoom entranceRoom;
        private EmptyRoom room1;

        //Map
        public Dictionary<Room, int> Map;

        public Testing testing;

        public Game()
        {
            // Initialize Objects:

            //Player
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();

            

            //Rooms
            entranceRoom = new();
            room1 = new();

            player = new(input, 100, entranceRoom);
            //temporary items for testing

            //Sword rustySword = new("Rusty Sword", "This has been here a long time...", 5);
            //entranceRoom.Inventory.Add(rustySword);

            //Initialize map matrix
            //Dictionary with (Room, [XY]) convention

            Map = new();

            Map.Add(entranceRoom,10);
            Map.Add(room1,20);

            testing = new Testing();
        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                //Debug checks:
                

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
                else if (input == "debug")
                {
                    testing.DebugMenu(this);
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

        public Player GetPlayer()
        {
            return this.player;
        }
    }
}
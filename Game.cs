using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private Sword rustySword;

        public Game()
        {
            // Initialize the game with one room and one player
            player = new("Hero", 100);
            currentRoom = new EntranceRoom();


            //temporary items for testing

            rustySword = new("Rusty Sword", "This has been here a long time...", 5);
            currentRoom.Inventory.Add(rustySword);

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
                    player.Look(currentRoom);
                }
                else if (input == "pickup")
                {
                    player.PickUpItem(currentRoom);
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
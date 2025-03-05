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
            currentRoom = new("Entrance Hall", "Test");


            //temporary items for testing

            Sword rustySword = new("Rusty Sword", "This has been here a long time...", 5);
            currentRoom.inventory.Add(rustySword);
        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here
            

                Console.WriteLine("Type 'look' to check where you are, or 'exit' to quit.");
                string? input = Console.ReadLine()?.ToLower();

                if (input == "look")
                {
                    player.Look(currentRoom);
                }
                else if (input == "exit")
                {
                    break;
                }

            }
        }
    }
}
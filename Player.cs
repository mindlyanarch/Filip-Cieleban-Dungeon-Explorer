using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<GameItems> inventory = new List<GameItems>();

        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }
        public void PickUpItem(string item)
        {

        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }
        public void Look(Room currentRoom)
        {
            Console.WriteLine("This room is " + currentRoom.Name);
            Console.WriteLine(currentRoom.Description);
            if (currentRoom.inventory.Count == 0)
            {
                Console.WriteLine("There's nothing here");

            }
            else
            {
                Console.WriteLine("This room contains:");

                foreach (GameItems item in currentRoom.inventory)
                {
                    Console.Write(currentRoom.inventory.IndexOf(item) + 1 + ". ");
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
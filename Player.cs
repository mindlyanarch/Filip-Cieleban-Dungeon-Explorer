using System;
using System.Collections.Generic;
using System.Linq;

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

        public void CheckInventory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Your bag is empty");
                return;

            }
            else
            {
                Console.WriteLine("There are items in your bag:");

                foreach (GameItems item in inventory)
                {
                    Console.Write(inventory.IndexOf(item) + 1 + ". ");
                    Console.WriteLine(item.Name);
                }
            }
        }
        public void PickUpItem(Room currentRoom)
        {
            //example of guard clause
            //exits early to prevent null error

            if (currentRoom.inventory.Count == 0)
            {
                Console.WriteLine("There's nothing to pick up here...");
                return;

            }
            else
            {
                Console.WriteLine("There are items here:");

                foreach (GameItems item in currentRoom.inventory)
                {
                    Console.Write(currentRoom.inventory.IndexOf(item) + 1 + ". ");
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Which item do you wish to procure?");
                string input = Console.ReadLine().ToLower();

                if (!currentRoom.inventory.Any(GameItems => GameItems.Name.ToLower().Contains(input)))
                {
                    Console.WriteLine("Item not found, perhaps you mistyped?");

                }
                else
                {
                    var target = currentRoom.inventory.Find(GameItems => GameItems.Name.ToLower().Contains(input));
                    this.inventory.Add(target);
                    currentRoom.inventory.Remove(target);

                    Console.WriteLine("Picked up the {0}", target.Name);
                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static DungeonExplorer.Playable;

namespace DungeonExplorer
{
    internal class Playable
    {
        public class Player : Creatures.Creature
        {
         

            private List<GameItems> inventory = new List<GameItems>();

            public Player(string name, int health, Room location) : base(location)
            {
                currentRoom = location;

                Name = name;
                Description = "You've seen better days.";
                MAXHP = health;
                HP = health;
            }
            public string InventoryContents()
            {
                return string.Join(", ", inventory);
            }

            public void Look(Dictionary<Room, int> Map)
            {
                //display room fluff

                Console.WriteLine("This room is " + currentRoom.Name);
                Console.WriteLine(currentRoom.Description);

                //check if room has items

                if (currentRoom.Inventory.Count == 0)
                {
                    Console.WriteLine("There's nothing here");

                }
                else
                {
                    Console.WriteLine("This room contains:");

                    foreach (GameItems item in currentRoom.Inventory)
                    {
                        Console.Write(currentRoom.Inventory.IndexOf(item) + 1 + ". ");
                        Console.WriteLine(item.Name);
                    }
                }

                //check if room has adjacency

                 int Coords = Map[currentRoom];
                Dictionary<string, int> Cardinality = new();

                Cardinality.Add("North", 1);
                Cardinality.Add("East", 10);
                Cardinality.Add("South", -1);
                Cardinality.Add("West", -10);


                for (int i = 0; i < 4; i++)
                {

                    if (Map.Values.Contains(Coords + Cardinality.Values.ElementAt(i)))
                    {
                        Console.WriteLine("There is a room to your {0}", Cardinality.Keys.ElementAt(i));
                    }
                    else
                    {
                        Console.WriteLine("There is nothing to your {0}", Cardinality.Keys.ElementAt(i));
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

            public void PickUpItem()
            {
                //example of guard clause
                //exits early to prevent null error

                if (currentRoom.Inventory.Count == 0)
                {
                    Console.WriteLine("There's nothing to pick up here...");
                    return;

                }
                else
                {
                    Console.WriteLine("There are items here:");

                    foreach (GameItems item in currentRoom.Inventory)
                    {
                        Console.Write(currentRoom.Inventory.IndexOf(item) + 1 + ". ");
                        Console.WriteLine(item.Name);
                    }

                    Console.WriteLine("Which item do you wish to procure?");
                    string input = Console.ReadLine().ToLower();

                    if (!currentRoom.Inventory.Any(GameItems => GameItems.Name.ToLower().Contains(input)))
                    {
                        Console.WriteLine("Item not found, perhaps you mistyped?");

                    }
                    else
                    {
                        var target = currentRoom.Inventory.Find(GameItems => GameItems.Name.ToLower().Contains(input));
                        this.inventory.Add(target);
                        currentRoom.Inventory.Remove(target);

                        Console.WriteLine("Picked up the {0}", target.Name);
                    }

                }
            }

            public void Move()
            {

            }
        }
    }
}
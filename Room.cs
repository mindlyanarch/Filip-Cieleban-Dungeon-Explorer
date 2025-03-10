using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
   
        public abstract class Room
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public List<GameItems> Inventory = new();

        public Room()
        {
            Name = "The Void";
            Description = "You shouldn't be here.";

        }
        public void GetContents()
        {
            if (this.Inventory.Count == 0)
            {
                Console.WriteLine("There's nothing here");

            }
            else
            {
                Console.WriteLine("This room contains:");

                foreach (GameItems item in this.Inventory)
                {
                    Console.Write(this.Inventory.IndexOf(item) + 1 + ". ");
                    Console.WriteLine(item.Name);
                }
            }
        }
    }

    public class EmptyRoom : Room
    {
        public EmptyRoom()
        {
            Name = "An empty Room";
            Description = "One of many, there doesn't seem to be anything notable here.";

        }


    }
    public class EntranceRoom : Room
    {
        public EntranceRoom()
        {
            
            Name = "Entrance Hall";
            Description = "Behind you lies a massive stone gate. There is no return.";

        }


    }

}
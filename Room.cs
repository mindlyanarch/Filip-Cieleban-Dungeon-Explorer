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
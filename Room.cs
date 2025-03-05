using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Room
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public List<GameItems> inventory = new List<GameItems>();

        public Room(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Creatures
    {
        public abstract class Creature
        {
            private int ID { get; set; }
            public string Name { get; private set; }
            public string Description { get; private set; }
            private int MAXHP { get; set; }
            public int HP { get; private set; }
            
            public Room currentRoom { get; set; }

            public Creature(Room location)
            {
                Name = "Creature";
                Description = "This shouldn't exist.";
                this.currentRoom = location;
            }
        }
    }
}

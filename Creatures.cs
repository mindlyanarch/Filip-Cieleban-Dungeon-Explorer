using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Creatures
    {
        public abstract class Creature
        {
            protected int ID { get; set; }
            protected string Name { get; set; }
            protected string Description { get; set; }
            protected int MAXHP { get; set; }
            protected int HP { get; set; }

            protected Room currentRoom { get; set; }

            public Creature(Room location)
            {
                Name = "Creature";
                Description = "This shouldn't exist.";
                this.currentRoom = location;
            }

            public Room GetRoom() { return this.currentRoom; }
        }

        


    }
}

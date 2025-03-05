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
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int MAXHP { get; set; }
            public int HP { get; set; }

            public Creature()
            {
                Name = "Creature";
                Description = "This shouldn't exist.";

            }
        }
    }
}

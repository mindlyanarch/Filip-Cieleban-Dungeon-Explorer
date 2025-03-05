using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class GameItems
    {
        public string Name { get; set; }
        public string Description { get; set; }

    public GameItems()
        { 
           
        }
    }

    public class Sword : GameItems
    {
        public int Damage { get; set; }
        public bool Equippable = true;

        public Sword(string name, string description, int damage)
        {
            Name = name;
            Description = description;

            Damage = damage;

        }
    }
}

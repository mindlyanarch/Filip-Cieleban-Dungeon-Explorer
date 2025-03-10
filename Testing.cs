using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Testing
    {
        public void DebugMenu(Game game)
        {

            Console.WriteLine("1. Spawn Item");
            string input = Console.ReadLine()?.ToLower();

            switch (input)
            {
                case "1":
                    {
                        SpawnItem(game); 
                            break; }

                default:
                    break;
            }
        }
        private void SpawnItem(Game game)
        {
            Console.WriteLine("Which item?");
            Console.WriteLine("1.Rusty Sword");

            string input = Console.ReadLine()?.ToLower();

            switch (input)
            {
                case "1":
                    {
                        Sword rustySword = new Sword("Rusty Sword", "This has been here a long time...", 5);
                        Player playerTarget = game.GetPlayer();
                        Room destination = playerTarget.GetRoom();

                        destination.Inventory.Add(rustySword);


                        break;
                    }
                default:
                    { 
                        break; }

            }
        }
    }


}

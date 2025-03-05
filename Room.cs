namespace DungeonExplorer
{
    public class Room
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        

        public Room(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            
        }
    }
}
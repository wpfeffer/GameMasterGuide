namespace GameMasterGuide.Dungeon
{
    public class Room
    {
        public int area { get; set; }
        public int col { get; set; }
        public Contents contents { get; set; }
        public Doors doors { get; set; }
        public int east { get; set; }
        public int height { get; set; }
        public int id { get; set; }
        public int north { get; set; }
        public int row { get; set; }
        public string shape { get; set; }
        public string size { get; set; }
        public int south { get; set; }
        public int west { get; set; }
        public int width { get; set; }
        public Block[] blocks { get; set; }
        public int composite { get; set; }
        public float offset { get; set; }
        public int polygon { get; set; }
    }
}
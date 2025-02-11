namespace GameMasterGuide.Dungeon
{
    public class Rootobject
    {
        public Cell_Bit cell_bit { get; set; }
        public int[][] cells { get; set; }
        public Corridor_Features corridor_features { get; set; }
        public Details details { get; set; }
        public Egress[] egress { get; set; }
        public Room[] rooms { get; set; }
        public Settings settings { get; set; }
        public Stair[] stairs { get; set; }
        public Wandering_Monsters wandering_monsters { get; set; }
    }
}
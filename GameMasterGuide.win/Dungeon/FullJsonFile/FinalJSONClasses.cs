
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

public class Cell_Bit
{
    public int aperture { get; set; }
    public int arch { get; set; }
    public int block { get; set; }
    public int corridor { get; set; }
    public int door { get; set; }
    public long label { get; set; }
    public int locked { get; set; }
    public int nothing { get; set; }
    public int perimeter { get; set; }
    public int portcullis { get; set; }
    public int room { get; set; }
    public int room_id { get; set; }
    public int secret { get; set; }
    public int stair_down { get; set; }
    public int stair_up { get; set; }
    public int trapped { get; set; }
}

public class Corridor_Features
{
    public A a { get; set; }
    public C c { get; set; }
    public E e { get; set; }
    public I i { get; set; }
    public M m { get; set; }
    public N n { get; set; }
    public R r { get; set; }
    public S s { get; set; }
    public U u { get; set; }
    public V v { get; set; }
    public W w { get; set; }
    public X x { get; set; }
    public Z z { get; set; }
}

public class A
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark
{
    public int col { get; set; }
    public int row { get; set; }
}

public class C
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark1[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark1
{
    public int col { get; set; }
    public int row { get; set; }
}

public class E
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark2[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark2
{
    public int col { get; set; }
    public int row { get; set; }
}

public class I
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark3[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark3
{
    public int col { get; set; }
    public int row { get; set; }
}

public class M
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark4[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark4
{
    public int col { get; set; }
    public int row { get; set; }
}

public class N
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark5[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark5
{
    public int col { get; set; }
    public int row { get; set; }
}

public class R
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark6[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark6
{
    public int col { get; set; }
    public int row { get; set; }
}

public class S
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark7[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark7
{
    public int col { get; set; }
    public int row { get; set; }
}

public class U
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark8[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark8
{
    public int col { get; set; }
    public int row { get; set; }
}

public class V
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark9[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark9
{
    public int col { get; set; }
    public int row { get; set; }
}

public class W
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark10[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark10
{
    public int col { get; set; }
    public int row { get; set; }
}

public class X
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark11[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark11
{
    public int col { get; set; }
    public int row { get; set; }
}

public class Z
{
    public string detail { get; set; }
    public string key { get; set; }
    public Mark12[] marks { get; set; }
    public string summary { get; set; }
}

public class Mark12
{
    public int col { get; set; }
    public int row { get; set; }
}

public class Details
{
    public string floor { get; set; }
    public string history { get; set; }
    public string illumination { get; set; }
    public string size { get; set; }
    public object special { get; set; }
    public string temperature { get; set; }
    public string walls { get; set; }
}

public class Settings
{
    public string add_stairs { get; set; }
    public int bleed { get; set; }
    public int cell_size { get; set; }
    public string corridor_layout { get; set; }
    public string door_set { get; set; }
    public string dungeon_layout { get; set; }
    public string dungeon_size { get; set; }
    public string grid { get; set; }
    public string image_size { get; set; }
    public string infest { get; set; }
    public int last_room_id { get; set; }
    public int level { get; set; }
    public string map_cols { get; set; }
    public string map_rows { get; set; }
    public string map_style { get; set; }
    public int max_col { get; set; }
    public int max_row { get; set; }
    public string motif { get; set; }
    public int n_cols { get; set; }
    public int n_i { get; set; }
    public int n_j { get; set; }
    public int n_pc { get; set; }
    public int n_rooms { get; set; }
    public int n_rows { get; set; }
    public string name { get; set; }
    public string peripheral_egress { get; set; }
    public string remove_deadends { get; set; }
    public string room_layout { get; set; }
    public string room_polymorph { get; set; }
    public string room_size { get; set; }
    public int seed { get; set; }
}

public class Wandering_Monsters
{
    public string _1 { get; set; }
    public string _2 { get; set; }
    public string _3 { get; set; }
    public string _4 { get; set; }
    public string _5 { get; set; }
    public string _6 { get; set; }
}

public class Egress
{
    public int col { get; set; }
    public int depth { get; set; }
    public string dir { get; set; }
    public int row { get; set; }
    public string type { get; set; }
    public int room_id { get; set; }
}

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

public class Contents
{
    public string summary { get; set; }
    public Detail detail { get; set; }
    public string inhabited { get; set; }
}

public class Detail
{
    public string[] monster { get; set; }
    public string room_features { get; set; }
    public string[] hidden_treasure { get; set; }
    public string[] trap { get; set; }
}

public class Doors
{
    public East[] east { get; set; }
    public North[] north { get; set; }
    public South[] south { get; set; }
    public West[] west { get; set; }
}

public class East
{
    public int col { get; set; }
    public string desc { get; set; }
    public int out_id { get; set; }
    public int row { get; set; }
    public string type { get; set; }
}

public class North
{
    public int col { get; set; }
    public string desc { get; set; }
    public int out_id { get; set; }
    public int row { get; set; }
    public string type { get; set; }
}

public class South
{
    public int col { get; set; }
    public string desc { get; set; }
    public int out_id { get; set; }
    public int row { get; set; }
    public string type { get; set; }
}

public class West
{
    public int col { get; set; }
    public string desc { get; set; }
    public int out_id { get; set; }
    public int row { get; set; }
    public string type { get; set; }
}

public class Block
{
    public int area { get; set; }
    public int col { get; set; }
    public int east { get; set; }
    public int height { get; set; }
    public int id { get; set; }
    public int north { get; set; }
    public float offset { get; set; }
    public int row { get; set; }
    public string size { get; set; }
    public int south { get; set; }
    public int west { get; set; }
    public int width { get; set; }
}

public class Stair
{
    public int col { get; set; }
    public string dir { get; set; }
    public string key { get; set; }
    public int row { get; set; }
}

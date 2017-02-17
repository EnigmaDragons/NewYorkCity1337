using NewYorkCity1337.Engine;
using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.Terrain
{
    public class Grass : Tile
    {
        public Grass(TileLocation location, params IWorldObject[] gameObjs) : base(location, "grass1", gameObjs) {}
    }
}

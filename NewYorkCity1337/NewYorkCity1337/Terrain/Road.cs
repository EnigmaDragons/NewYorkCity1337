using NewYorkCity1337.Engine;
using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.Terrain
{
    public class Road : Tile
    {
        public Road(TileLocation location, params IWorldObject[] gameObjs) : base(location, "road-1", gameObjs) {}
    }
}

using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.TileEngine
{
    public class CurrentMap
    {
        private static Map map;

        public void SetMap(Map map)
        {
            CurrentMap.map = map;
        } 

        public Map Get()
        {
            return map;
        }
    }
}

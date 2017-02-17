using System.Linq;
using Microsoft.Xna.Framework;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Tiles;
using NewYorkCity1337.UI;

namespace NewYorkCity1337.View
{
    public class MapView : IGameView
    {
        private readonly Map map;

        public MapView()
        {
            map = new Map(Enumerable.Range(0, 16).SelectMany(x => Enumerable.Range(0, 16).Select(y => new Tile(new TileLocation(x, y), "grass1"))));
        }

        public void LoadContent()
        {
            map.LoadContent();
        }

        public void UnloadContent()
        {
           map.UnloadContent();
        }

        public void Update(GameTime deltaTime)
        {
           map.Update(deltaTime);
        }

        public void Draw()
        {
            map.Draw();
        }
    }
}

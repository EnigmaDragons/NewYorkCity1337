using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.WorldObjects
{
    public class Road : IWorldObject
    {
        private Texture2D road;

        public void LoadContent()
        {
            road = new LoadedTexture("road-1").Get();
        }

        public void UnloadContent()
        {
            road.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw(TileLocation location)
        {
            new DrawOnTile(road, location).Go();
        }
    }
}

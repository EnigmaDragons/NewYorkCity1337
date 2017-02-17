using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.Tiles
{
    public class Map : IGameObject
    {
        private List<Tile> tiles = new List<Tile>();

        public Map(params Tile[] tiles)
        {
            this.tiles.AddRange(tiles);
        }

        public void LoadContent()
        {
            tiles.ForEach(x => x.LoadContent());
        }

        public void UnloadContent()
        {
            tiles.ForEach(x => x.UnloadContent());
        }

        public void Update(GameTime deltaTime)
        {
            tiles.ForEach(x => x.Update(deltaTime));
        }

        public void Draw(SpriteBatch sprites)
        {
            tiles.ForEach(x => x.Draw(sprites));
        }
    }
}
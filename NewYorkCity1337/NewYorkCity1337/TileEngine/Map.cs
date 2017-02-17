using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.Tiles
{
    public class Map : IGameObject
    {
        private List<Tile> tiles = new List<Tile>();

        public Map(IEnumerable<Tile> tiles)
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

        public void Draw()
        {
            tiles.ForEach(x => x.Draw());
        }

        public Tile Get(TileLocation loc)
        {
            return tiles.First(x => x.Location.Equals(loc));
        }

        public void MoveTo(IWorldObject gameObj, TileLocation current, TileLocation destination)
        {
            Get(current).Move(gameObj, Get(destination));
        }

        public void Enter(IWorldObject gameObj, TileLocation location)
        {
            Get(location).Enter(gameObj);
        }
    }
}
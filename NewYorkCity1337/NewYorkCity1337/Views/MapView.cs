using System;
using System.Linq;
using Microsoft.Xna.Framework;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Terrain;
using NewYorkCity1337.Tiles;
using NewYorkCity1337.TileEngine;
using NewYorkCity1337.NewFolder1;

namespace NewYorkCity1337.View
{
    public class MapView : IGameView
    {
        private readonly Map map;

        public MapView()
        {
            var road = new Random(Guid.NewGuid().GetHashCode()).Next(0, 16);
            map = new Map(Enumerable.Range(0, 16).SelectMany(x => Enumerable.Range(0, 16).Select(y => x == road ? (Tile)new Road(new TileLocation(x, y)) : (Tile)new Grass(new TileLocation(x, y)))));
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

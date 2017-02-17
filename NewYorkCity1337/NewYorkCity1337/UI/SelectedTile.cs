using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Graphics;
using NewYorkCity1337.TileEngine;
using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.Input
{
    public class SelectedTile : IGameObject
    {
        private Texture2D selectedBox;
        private TileLocation currentLocation = new TileLocation(0, 0);

        public void LoadContent()
        {
            selectedBox = new RectangleTexture(new TileSize().Get(), new TileSize().Get(), Color.FromNonPremultiplied(80, 20, 20, 30)).Create();
        }

        public void UnloadContent()
        {
            selectedBox.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
            var state = Mouse.GetState();
            var tile = new TileLocation(new Vector2(state.Y, state.X));
            if (new CurrentMap().Get().Exist(tile))
                currentLocation = tile;
        }

        public void Draw()
        {
            new DrawOnTile(selectedBox, currentLocation).Go();
        }

        public TileLocation GetCurrentSelectedTileLocation()
        {
            return currentLocation;
        } 
    }
}

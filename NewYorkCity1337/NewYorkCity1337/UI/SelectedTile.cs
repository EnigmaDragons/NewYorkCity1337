using Graphics;
using Input;
using Math;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
            selectedBox = new RectangleTexture(new TileSize().Get(), new TileSize().Get(), Color.FromNonPremultiplied(100, 80, 0, 40)).Create();
        }

        public void UnloadContent()
        {
            selectedBox.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
            IfMouseIsOnScreen.Execute(mouse =>
            {
                var tile = new TileLocation(new Vector2(mouse.Y, mouse.X));
                if (new CurrentMap().Get().Exist(tile))
                    currentLocation = tile;
            });
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

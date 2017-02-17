using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Graphics;
using NewYorkCity1337.Tiles;

namespace Graphics
{
    public class DrawOnTile
    {
        private readonly Texture2D texture;
        private readonly TileLocation location;

        public DrawOnTile(Texture2D texture, TileLocation location)
        {
            this.texture = texture;
            this.location = location;
        }

        public void Go()
        {
            var size = new TileSize().Get();
            new SpritesBatchInstance().Draw(texture, new Rectangle(location.Row * size, location.Column * size, size, size));
        }
    }
}

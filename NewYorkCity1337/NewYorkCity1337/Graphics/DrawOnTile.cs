using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;
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
            new SpritesBatchInstance().Draw(texture, new Vector2(location.Row, location.Column) * 32);
        }
    }
}

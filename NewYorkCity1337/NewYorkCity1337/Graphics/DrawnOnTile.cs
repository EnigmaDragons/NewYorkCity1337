using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;

namespace Graphics
{
    public class DrawnOnTile
    {
        private readonly Texture2D texture;
        private readonly Vector2 location;

        public DrawnOnTile(Texture2D texture, Vector2 location)
        {
            this.texture = texture;
            this.location = location;
        }

        public void Go()
        {
            new SpritesBatchInstance().Draw(texture, location * 32);
        }
    }
}

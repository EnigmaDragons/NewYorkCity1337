using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;

namespace Graphics
{
    public class DrawOnScreen
    {
        private readonly Texture2D texture;
        private readonly Vector2 location;

        public DrawOnScreen(Texture2D texture, Vector2 screenLocation)
        {
            this.texture = texture;
            this.location = screenLocation;
        }

        public void Go()
        {
            new SpritesBatchInstance().Draw(texture, location);
        }
    }
}

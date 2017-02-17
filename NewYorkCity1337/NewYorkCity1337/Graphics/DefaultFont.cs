using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.Graphics
{
    public static class DefaultFont
    {
        public static SpriteFont Font { get; set; }

        static DefaultFont()
        {
            Font = new GameInstance().Load<SpriteFont>("Arial");
        }
    }
}

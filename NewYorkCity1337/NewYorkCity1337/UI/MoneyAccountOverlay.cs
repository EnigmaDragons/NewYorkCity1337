using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Graphics;

namespace NewYorkCity1337.UI
{
    public class MoneyAccountOverlay : IGameObject
    {
        private SpriteFont _font;
        private Texture2D _panelShadow;
        private Texture2D _panelBorder;
        private Texture2D _panel;

        public void LoadContent()
        {
            _font = DefaultFont.Font;
            _panelShadow = new RectangleTexture(83, 21, Color.FromNonPremultiplied(0, 0, 0, 80)).Create();
            _panelBorder = new RectangleTexture(82, 20, Color.Black).Create();
            _panel = new RectangleTexture(80, 18, Color.Gray).Create();
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw()
        {
        }
    }
}

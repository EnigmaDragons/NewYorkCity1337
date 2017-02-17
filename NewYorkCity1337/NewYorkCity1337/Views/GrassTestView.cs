using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;
using RunehackValley.MonoGame;

namespace NewYorkCity1337.Views
{
    public class GrassTestView : IGameView
    {
        private Texture2D _grass;

        public void LoadContent()
        {
            _grass = new LoadedTexture("grass1").Get();
        }

        public void UnloadContent()
        {
            _grass?.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw()
        {
            new ViewBackgroundColor(Color.Black).Draw();
            for (int x = 0; x < 16; x++)
                for (var y = 0; y < 16; y++)
                    new SpritesBatchInstance().Draw(_grass, new Vector2(x * 32, y * 32));
        }
    }
}

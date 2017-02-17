using Microsoft.Xna.Framework;
﻿using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.Views
{
    public class GrassTestView : IGameView
    {
        private LoadedTextures _textures;

        public void LoadContent()
        {
            _textures = new LoadedTextures("grass1", "building1", "building2");
            _textures.LoadContent();
        }

        public void UnloadContent()
        {
            _textures.UnloadContent();
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw()
        {
            var sprites = new SpritesBatchInstance();
            new ViewBackgroundColor(Color.Black).Draw();
            for (int x = 0; x < 16; x++)
                for (var y = 0; y < 16; y++)
                    sprites.Draw(_textures["grass1"], new Vector2(x * 32, y * 32));
            sprites.Draw(_textures["building1"], new Vector2(3 * 32, 5 * 32));
            sprites.Draw(_textures["building2"], new Vector2(8 * 32, 2 * 32));
        }
    }
}

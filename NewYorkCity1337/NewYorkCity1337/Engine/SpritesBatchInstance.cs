﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Graphics;

namespace NewYorkCity1337.Engine
{
    public class SpritesBatchInstance
    {
        private static SpriteBatch spritesInstance;

        public void SetSpritesBatch(SpriteBatch sprites)
        {
            spritesInstance = sprites;
        }

        public void Draw(Texture2D texture, Vector2 pixelPosition)
        {
            spritesInstance.Draw(texture, pixelPosition);
        }

        public void DrawText(string text, Vector2 pixelPosition, Color color)
        {
            spritesInstance.DrawString(DefaultFont.Font, text, pixelPosition, color);
        }
    }
}

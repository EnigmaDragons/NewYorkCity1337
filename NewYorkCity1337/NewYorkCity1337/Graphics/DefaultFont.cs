﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace NewYorkCity1337.Graphics
{
    public static class DefaultFont
    {
        public static SpriteFont Font { get; set; }

        public static void Load(ContentManager content)
        {
            Font = content.Load<SpriteFont>("Arial");
        }
    }
}

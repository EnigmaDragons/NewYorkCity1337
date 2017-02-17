using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.Graphics
{
    public class DrawRectOnScreen
    {
        private readonly Texture2D texture;
        private readonly Vector2 location;
        private readonly int width;
        private readonly int height;

        public DrawRectOnScreen(Texture2D texture, Vector2 screenLocation, int width, int height)
        {
            this.texture = texture;
            this.location = screenLocation;
            this.width = width;
            this.height = height;
        }

        public void Go()
        {
            new SpritesBatchInstance().Draw(texture, new Rectangle((int)location.X, (int)location.Y, width, height));
        }
    }
}

using Microsoft.Xna.Framework.Graphics;

namespace NewYorkCity1337.Engine
{
    public class GraphicsDeviceInstance
    {
        public GraphicsDevice Get()
        {
            return new GameInstance().Graphics;
        }
    }
}

using Microsoft.Xna.Framework.Graphics;

namespace NewYorkCity1337.Engine
{
    public interface IGame
    {
        T Load<T>(string resourceName);
        GraphicsDevice Graphics { get; }
    }
}

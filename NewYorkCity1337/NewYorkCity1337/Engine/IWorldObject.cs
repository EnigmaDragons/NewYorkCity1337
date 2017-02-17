using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NewYorkCity1337.Engine
{
    public interface IWorldObject
    {
        void LoadContent();
        void UnloadContent();
        void Update(GameTime deltaTime);
        void Draw(SpriteBatch sprites, Vector2 location);
    }
}

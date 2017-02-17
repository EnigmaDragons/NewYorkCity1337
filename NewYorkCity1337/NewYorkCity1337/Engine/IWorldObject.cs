using Microsoft.Xna.Framework;

namespace NewYorkCity1337.Engine
{
    public interface IWorldObject
    {
        void LoadContent();
        void UnloadContent();
        void Update(GameTime deltaTime);
        void Draw(Vector2 location);
    }
}

using Microsoft.Xna.Framework;

namespace NewYorkCity1337.Engine
{
    public interface IGameObject
    {
        void LoadContent();
        void UnloadContent();
        void Update(GameTime deltaTime);
        void Draw();
    }
}

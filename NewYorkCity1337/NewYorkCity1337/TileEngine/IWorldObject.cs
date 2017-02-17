using Microsoft.Xna.Framework;
using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.Engine
{
    public interface IWorldObject
    {
        void LoadContent();
        void UnloadContent();
        void Update(GameTime deltaTime);
        void Draw(TileLocation location);
    }
}

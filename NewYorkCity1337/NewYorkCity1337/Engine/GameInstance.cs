using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace NewYorkCity1337.Engine
{
    public class GameInstance : IGame
    {
        private static Game gameInstance;

        public void SetGame(Game game)
        {
            gameInstance = game;
        }

        public T Load<T>(string resourceName)
        {
            return gameInstance.Content.Load<T>(resourceName);
        }

        public GraphicsDevice Graphics => gameInstance.GraphicsDevice;
    }
}

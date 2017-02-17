using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Graphics;
using RunehackValley.MonoGame;

namespace NewYorkCity1337.Tiles
{
    public class Tile : IGameObject
    {
        private readonly List<IWorldObject> gameObjs = new List<IWorldObject>();
        private readonly Vector2 location;
        private readonly string textureName;

        private Texture2D background; 
        
        public Tile(Vector2 location, string textureName, params IWorldObject[] gameObjs)
        {
            this.location = location;
            this.gameObjs.AddRange(gameObjs);
            this.textureName = textureName;
        }

        public void LoadContent()
        {
            background = new LoadedTexture(textureName).Get();
            gameObjs.ForEach(x => x.LoadContent());
        }

        public void UnloadContent()
        {
            background.Dispose();
            gameObjs.ForEach(x => x.UnloadContent());
        }

        public void Update(GameTime deltaTime)
        {
            gameObjs.ForEach(x => x.Update(deltaTime));
        }

        public void Draw()
        {
            new DrawOnTile(background, location).Go();
            gameObjs.ForEach(x => x.Draw(location));
        }
    }
}
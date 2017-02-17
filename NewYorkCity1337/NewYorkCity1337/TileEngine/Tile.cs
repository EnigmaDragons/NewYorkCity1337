using System.Collections.Generic;
using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.Tiles
{
    public class Tile : IGameObject
    {
        private readonly IWorldObject[] objs;
        private readonly List<IWorldObject> gameObjs = new List<IWorldObject>();
        public TileLocation Location { get; }
        private readonly string textureName;

        private Texture2D background; 
        
        public Tile(TileLocation location, string textureName, params IWorldObject[] gameObjs)
        {
            this.objs = gameObjs;
            this.Location = location;
            this.textureName = textureName;
        }

        public void LoadContent()
        {
            this.gameObjs.AddRange(objs);
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
            new DrawOnTile(background, Location).Go();
            gameObjs.ForEach(x => x.Draw(Location));
        }

        public void Enter(IWorldObject gameObj)
        {
            gameObjs.Add(gameObj);
        }

        public void Exit(IWorldObject gameObj)
        {
            gameObjs.Remove(gameObj);
        }

        public void Move(IWorldObject gameObj, Tile destination)
        {
            Exit(gameObj);  
            destination.Enter(gameObj);
        } 
    }
}
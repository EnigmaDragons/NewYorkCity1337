using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.Buildings
{
    public class BasicBuilding : Building
    {
        private readonly string _spriteName;

        private Texture2D _sprite;

        public string DisplayName { get; }
        public Texture2D DisplayImage => _sprite;

        public BasicBuilding(string displayName, string spriteName)
        {
            DisplayName = displayName;
            _spriteName = spriteName;
        }

        public void LoadContent()
        {
            _sprite = new LoadedTexture(_spriteName).Get();
        }

        public void UnloadContent()
        {
            _sprite?.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw(TileLocation location)
        {
            new DrawOnTile(_sprite, location).Go();
        }
    }
}

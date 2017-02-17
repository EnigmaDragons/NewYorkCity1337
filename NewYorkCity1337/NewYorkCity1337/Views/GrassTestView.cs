using Microsoft.Xna.Framework;
﻿using Graphics;
using NewYorkCity1337.Engine;
using NewYorkCity1337.UI;

namespace NewYorkCity1337.Views
{
    public class GrassTestView : IGameView
    {
        private LoadedTextures _textures;
        private BuildingSelectionOverlay _overlay;

        public void LoadContent()
        {
            _overlay = new BuildingSelectionOverlay();
            _overlay.LoadContent();
            _textures = new LoadedTextures("grass1", "building1", "building2");
            _textures.LoadContent();
        }

        public void UnloadContent()
        {
            _textures.UnloadContent();
            _overlay.UnloadContent();
        }

        public void Update(GameTime deltaTime)
        {
            _overlay.Update(deltaTime);
        }

        public void Draw()
        {
            var sprites = new SpritesBatchInstance();
            new ViewBackgroundColor(Color.Black).Draw();
            for (int x = 0; x < 16; x++)
                for (var y = 0; y < 16; y++)
                    sprites.Draw(_textures["grass1"], new Vector2(x * 32, y * 32));
            sprites.Draw(_textures["building1"], new Vector2(3 * 32, 5 * 32));
            sprites.Draw(_textures["building2"], new Vector2(8 * 32, 2 * 32));
            _overlay.Draw();
        }
    }
}

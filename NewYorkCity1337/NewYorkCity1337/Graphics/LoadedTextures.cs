using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Graphics
{
    public class LoadedTextures
    {
        private readonly string[] _textureNames;
        private readonly Dictionary<string, Texture2D> _textures = new Dictionary<string, Texture2D>();

        public LoadedTextures(params string[] textureNames)
        {
            _textureNames = textureNames;
        }

        public Texture2D this[string name] => _textures[name];

        public void LoadContent()
        {
            foreach (var name in _textureNames)
                _textures.Add(name, new LoadedTexture(name).Get());
        }

        public void UnloadContent()
        {
            foreach (var texture in _textures)
                texture.Value.Dispose();
            _textures.Clear();
        }
    }
}

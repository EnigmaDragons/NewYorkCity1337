using System;
using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Business;
using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.Buildings
{
    public class BasicBuilding : Building
    {
        private TimeSpan _timeSinceLastPayment = new TimeSpan(0, 0, 0);
        private readonly string _spriteName;
        private readonly int _income;

        private Texture2D _sprite;
        private MoneyAccount _moneyAccount;

        public int Price { get; }
        public string DisplayName { get; }
        public Texture2D DisplayImage => _sprite;

        public BasicBuilding(string displayName, string spriteName, int price, int income)
        {
            DisplayName = displayName;
            _spriteName = spriteName;
            Price = price;
            _income = income;
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
            _timeSinceLastPayment += deltaTime.ElapsedGameTime;
            if (_moneyAccount == null)
                return;

            if (_timeSinceLastPayment >= TimeSpan.FromSeconds(5))
            {
                _moneyAccount?.Gain(_income);
                _timeSinceLastPayment -= TimeSpan.FromSeconds(5);
            }
        }

        public void Draw(TileLocation location)
        {
            new DrawOnTile(_sprite, location).Go();
        }

        public void AssignOwner(MoneyAccount ownerAccount)
        {
            _moneyAccount = ownerAccount;
        }
    }
}

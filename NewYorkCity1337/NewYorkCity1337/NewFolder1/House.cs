using System;
using Microsoft.Xna.Framework;
using NewYorkCity1337.Tiles;
using NewYorkCity1337.TileEngine;

namespace NewYorkCity1337.NewFolder1
{
    public class House : IBuilding
    {
        private TimeSpan TimeSinceLastPayment = new TimeSpan(0, 0, 0);
        private Cash cash;
        //private Image image;
        //public Image Image { get { throw new NotImplementedException(); } }
        private string name = "House"; 
        public string Name { get { return name; } }
        private int price = 100;
        public int Price { get { return price; } }

        public House(Cash cashToIncrease)
        {
            cash = cashToIncrease;
        }

        public void LoadContent()
        {
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime deltaTime)
        {
            TimeSinceLastPayment += deltaTime.ElapsedGameTime;
            if (TimeSinceLastPayment >= TimeSpan.FromSeconds(5))
            {
                cash.Gain(25);
                TimeSinceLastPayment -= TimeSpan.FromSeconds(5);
            }
        }

        public void Draw(TileLocation location)
        {
        }
    }
}

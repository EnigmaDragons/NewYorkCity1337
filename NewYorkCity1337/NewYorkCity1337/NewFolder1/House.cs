using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.NewFolder1
{
    public class House : IBuilding
    {
        private TimeSpan TimeSinceLastPayment = new TimeSpan(0, 0, 0);
        private Cash cash;
        private Vector2 location;
        public Vector2 Location { get { return location; } }
        //private Image image;
        //public Image Image { get { throw new NotImplementedException(); } }
        private string name = "House"; 
        public string Name { get { return name; } }
        private int price = 100;
        public int Price { get { return price; } }

        public House(Vector2 location, Cash cashToIncrease)
        {
            this.location = location;
            cash = cashToIncrease;
        }

        public void Draw(SpriteBatch sprites)
        {
            throw new NotImplementedException();
        }

        public void LoadContent()
        {
            throw new NotImplementedException();
        }

        public void UnloadContent()
        {
            throw new NotImplementedException();
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
    }
}

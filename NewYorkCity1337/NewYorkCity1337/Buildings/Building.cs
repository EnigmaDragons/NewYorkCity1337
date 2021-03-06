﻿using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Business;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.Buildings
{
    public interface Building : IWorldObject
    {
        string DisplayName { get; }
        Texture2D DisplayImage { get; }
        int Price { get; }
        void AssignOwner(MoneyAccount ownerAccount);
        Building Clone();
    }
}

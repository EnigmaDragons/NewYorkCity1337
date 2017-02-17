using Microsoft.Xna.Framework;
using NewYorkCity1337.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NewYorkCity1337.NewFolder1
{
    public interface IBuilding : IGameObject
    {
        Vector2 Location { get; }
        //Image Image { get; }
        string Name { get; }
        int Price { get; }
        //void StartProduction();
    }
}

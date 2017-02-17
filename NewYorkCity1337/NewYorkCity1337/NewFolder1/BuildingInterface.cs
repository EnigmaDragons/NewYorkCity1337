using NewYorkCity1337.Engine;
using NewYorkCity1337.Tiles;

namespace NewYorkCity1337.NewFolder1
{
    public interface IBuilding : IWorldObject
    {
        //Image Image { get; }
        string Name { get; }
        int Price { get; }
        //void StartProduction();
    }
}

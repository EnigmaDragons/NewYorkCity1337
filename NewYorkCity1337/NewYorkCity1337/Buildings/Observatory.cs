
namespace NewYorkCity1337.Buildings
{
    public class Observatory : BasicBuilding
    {
        public Observatory() 
            : base(nameof(Observatory), "building1", 250, 250, System.TimeSpan.FromSeconds(15)) { }
    }
}

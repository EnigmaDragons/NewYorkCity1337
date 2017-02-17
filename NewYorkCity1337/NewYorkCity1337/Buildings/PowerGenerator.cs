using System;

namespace NewYorkCity1337.Buildings
{
    public class PowerGenerator : BasicBuilding
    {
        public PowerGenerator() 
            : base(nameof(PowerGenerator), "building3", 1000, 100, TimeSpan.FromSeconds(1)) { }
    }
}

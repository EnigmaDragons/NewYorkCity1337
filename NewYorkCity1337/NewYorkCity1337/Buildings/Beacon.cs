using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYorkCity1337.Buildings
{
    public class Beacon : BasicBuilding
    {
        public Beacon() 
            : base("Beacon", "building4", 75, 20, System.TimeSpan.FromSeconds(5)) { }
    }
}

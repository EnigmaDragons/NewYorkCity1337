using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYorkCity1337.Buildings
{
    public class Factory : BasicBuilding
    {
        public Factory() 
            : base("Factory", "building5", 500, 40, System.TimeSpan.FromSeconds(1)) { }
    }
}

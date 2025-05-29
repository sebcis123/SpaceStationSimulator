using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    abstract class RandomEvent
    {
        public abstract void Apply(List<StationModule> modules, StationResources resources);
    }
}

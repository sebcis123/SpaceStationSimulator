using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class PowerOutageEvent : RandomEvent
    {
        public override void Apply(List<StationModule> modules, StationResources resources)
        {
            Console.WriteLine("Power outage! No energy will be produced this turn.");
            resources.SetPowerBlocked(true);
        }
    }
}

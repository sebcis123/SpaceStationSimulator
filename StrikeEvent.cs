using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class StrikeEvent : RandomEvent
    {
        public override void Apply(List<StationModule> modules, StationResources resources)
        {
            Console.WriteLine("Crew is striking due to low morale! No crew assignments this turn.");
            SimulationContext.StrikeTriggered = true;
        }
    }
}

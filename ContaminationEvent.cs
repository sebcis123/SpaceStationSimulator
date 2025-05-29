using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class ContaminationEvent : RandomEvent
    {
        public override void Apply(List<StationModule> modules, StationResources resources)
        {
            Console.WriteLine("Contaminated food supply! -3 Food.");
            resources.Generate("Food", -3);
        }
    }
}

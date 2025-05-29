using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class HydroponicsModule : StationModule
    {
        public HydroponicsModule()
        {
            name = "Hydroponics Module";
        }

        public override void PerformAction(StationResources resources)
        {
            if (damaged)
            {
                Console.WriteLine($"{name} is damaged!");
                if (crew != null)
                {
                    Console.WriteLine($"{crew.Name} is repairing the module...");
                    Repair();
                }
            }
            else
            {
                Console.WriteLine($"{name} is growing food.");
                resources.Generate("Food", 1);
            }
        }
    }
}

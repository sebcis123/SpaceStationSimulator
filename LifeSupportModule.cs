using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class LifeSupportModule : StationModule
    {
        public LifeSupportModule()
        {
            name = "Life Support Module";
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
                Console.WriteLine($"{name} is generating oxygen.");
                resources.Generate("Oxygen", 1);
            }
        }
    }
}

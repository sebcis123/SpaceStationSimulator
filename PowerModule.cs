using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class PowerModule : StationModule
    {
        public PowerModule()
        {
            name = "Power Module";
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
            else if (resources.IsPowerBlocked())
            {
                Console.WriteLine($"{name} is operational, but energy cannot be generated due to power outage.");
            }
            else
            {
                Console.WriteLine($"{name} is generating energy.");
                resources.Generate("Energy", 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class SystemFailureEvent : RandomEvent
    {
        public override void Apply(List<StationModule> modules, StationResources resources)
        {
            Console.WriteLine("System malfunction detected!");

            var rand = new Random();
            int index = rand.Next(modules.Count);
            var target = modules[index];

            Console.WriteLine($"{target.GetName()} has malfunctioned!");
            target.Damage();
        }
    }
}

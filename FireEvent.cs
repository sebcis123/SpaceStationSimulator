using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class FireEvent : RandomEvent
    {
        public override void Apply(List<StationModule> modules, StationResources resources)
        {
            Console.WriteLine("Fire broke out in one of the modules!");

            var rand = new Random();
            int index = rand.Next(modules.Count);
            var target = modules[index];

            Console.WriteLine($"{target.GetName()} was damaged by fire!");
            target.Damage();
        }
    }
}

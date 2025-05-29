using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class MeteorShowerEvent : RandomEvent
    {
        public override void Apply(List<StationModule> modules, StationResources resources)
        {
            Console.WriteLine("Meteor shower! Two random modules are hit!");

            var rand = new Random();
            var shuffled = modules.OrderBy(m => rand.Next()).ToList();

            for (int i = 0; i < Math.Min(2, shuffled.Count); i++)
            {
                var module = shuffled[i];
                module.Damage();
                Console.WriteLine($"{module.GetName()} was damaged by a meteor!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class RandomEventFactory
    {
        public static RandomEvent CreateRandomEvent()
        {
            var rand = new Random();
            int roll = rand.Next(0, 7);

            return roll switch
            {
                0 => new FireEvent(),
                1 => new SystemFailureEvent(),
                2 => new PowerOutageEvent(),
                3 => new ContaminationEvent(),
                4 => new StrikeEvent(),
                5 => new MeteorShowerEvent(),
                6 => new NoEvent(),
                _ => new FireEvent()
            };
        }
    }
}

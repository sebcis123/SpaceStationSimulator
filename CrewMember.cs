using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class CrewMember
    {
        public string Name { get; }
        public Role Role { get; }

        public CrewMember(string name, Role role)
        {
            Name = name;
            Role = role;
        }

        public void Repair(StationModule module)
        {
            Console.WriteLine($"{Name} is attempting to repair {module.GetName()}.");

            // Możesz dodać szansę na naprawę albo specjalne efekty roli
            module.Repair();

            Console.WriteLine($"{module.GetName()} has been repaired!");
        }
    }
}

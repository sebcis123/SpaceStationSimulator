using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    interface IStationModule
    {
        void PerformAction(StationResources resources);
        void AssignCrewMember(CrewMember crew);
        void Damage();
        void Repair();
        bool IsDamaged();
        string GetName();
    }
}

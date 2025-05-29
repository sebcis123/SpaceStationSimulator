using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    abstract class StationModule : IStationModule
    {
        protected string name;
        protected bool damaged = false;
        protected CrewMember? crew;

        public void AssignCrewMember(CrewMember? crew)
        {
            this.crew = crew;
        }

        public void Damage()
        {
            damaged = true;
        }

        public void Repair()
        {
            damaged = false;
        }

        public bool IsDamaged()
        {
            return damaged;
        }

        public string GetName()
        {
            return name;
        }

        public abstract void PerformAction(StationResources resources);

        public bool HasCrewMember(CrewMember member)
        {
            return crew == member;
        }
    }
}

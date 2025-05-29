using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class StationResources
    {
        public int Oxygen { get; private set; } = 10;
        public int Energy { get; private set; } = 10;
        public int Food { get; private set; } = 10;
        public int Morale { get; private set; } = 10;

        private bool powerBlocked = false;

        public void SetPowerBlocked(bool value)
        {
            powerBlocked = value;
        }

        public bool IsPowerBlocked()
        {
            return powerBlocked;
        }

        public void Generate(string resource, int amount)
        {
            switch (resource)
            {
                case "Oxygen":
                    Oxygen += amount;
                    break;
                case "Energy":
                    Energy += amount;
                    break;
                case "Food":
                    Food += amount;
                    break;
                case "Morale":
                    Morale += amount;
                    break;
            }
        }

        public void ConsumeEachTurn()
        {
            Oxygen--;
            Energy--;
            Food--;
            Morale--;

            if (Oxygen < 0) Oxygen = 0;
            if (Energy < 0) Energy = 0;
            if (Food < 0) Food = 0;
            if (Morale < 0) Morale = 0;
        }

        public bool IsCritical()
        {
            return Oxygen == 0 || Energy == 0 || Food == 0 || Morale == 0;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"\n🔧 Status zasobów:");
            Console.WriteLine($"   Oxygen: {Oxygen}");
            Console.WriteLine($"   Energy: {Energy}");
            Console.WriteLine($"   Food:   {Food}");
            Console.WriteLine($"   Morale: {Morale}");
        }
    }
}

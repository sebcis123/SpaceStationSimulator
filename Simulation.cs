using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStationSim
{
    class Simulation
    {
        private List<StationModule> modules = new();
        private List<CrewMember> crew = new();
        private StationResources resources = new();

        private bool strikeActive = false;

        public void Run()
        {
            Initialize();

            bool gameOver = false;

            for (int turn = 1; turn <= 10; turn++)
            {
                Console.WriteLine($"\n--- TURA {turn} ---");

                SetStrike(SimulationContext.StrikeTriggered);
                SimulationContext.StrikeTriggered = false;

                resources.SetPowerBlocked(false);

                foreach (var module in modules)
                    module.AssignCrewMember(null); // odpinamy crew z poprzedniej tury

                Console.WriteLine("Przypisz załogantów do modułów:");
                for (int i = 0; i < crew.Count; i++)
                {
                    Console.WriteLine($"{i}: {crew[i].Name} ({crew[i].Role})");
                }

                if (IsStrikeActive())
                {
                    Console.WriteLine("STRIKE! You cannot assign crew members this turn.");
                }
                else
                {
                    for (int m = 0; m < modules.Count; m++)
                    {
                        var module = modules[m];
                        Console.WriteLine($"\nModuł {m}: {module.GetName()}");

                        Console.Write($"Wybierz numer załoganta do przypisania (lub ENTER, aby pominąć): ");
                        string? input = Console.ReadLine();

                        if (int.TryParse(input, out int crewIndex) && crewIndex >= 0 && crewIndex < crew.Count)
                        {
                            bool alreadyAssigned = modules.Any(m => m.HasCrewMember(crew[crewIndex]));
                            if (alreadyAssigned)
                            {
                                Console.WriteLine("Ten załogant jest już przypisany do innego modułu.");
                                continue;
                            }

                            module.AssignCrewMember(crew[crewIndex]);
                            Console.WriteLine($"Przypisano {crew[crewIndex].Name} do {module.GetName()}.");
                        }
                        else
                        {
                            Console.WriteLine("Pominięto przypisanie.");
                        }
                    }
                }

                Console.WriteLine(); // pusty wiersz po przypisaniu

                var ev = RandomEventFactory.CreateRandomEvent();
                Console.WriteLine("\nLosowe zdarzenie:");
                ev.Apply(modules, resources); // najpierw losujemy event

                Console.WriteLine(); // pusty wiersz po przypisaniu

                foreach (var module in modules)
                    module.PerformAction(resources); // potem moduły reagują na event

                resources.ConsumeEachTurn();

                if (resources.IsCritical())
                {
                    Console.WriteLine("Zasoby krytycznie niskie – stacja nie może funkcjonować. Przegrana.");
                    gameOver = true;
                    break;
                }

                resources.DisplayStatus();
            }

            if (!gameOver)
            {
                Console.WriteLine("Gratulacje! Przetrwałeś wszystkie 10 tur. Wygrana!");
            }
        }

        private void Initialize()
        {
            modules.Add(new LifeSupportModule());
            modules.Add(new PowerModule());
            modules.Add(new ResearchModule());
            modules.Add(new HydroponicsModule());

            crew.Add(new CrewMember("Alice", Role.Engineer));
            crew.Add(new CrewMember("Bob", Role.Scientist));

            modules[0].AssignCrewMember(crew[0]);
            modules[1].AssignCrewMember(crew[1]);
        }

        public void SetStrike(bool value)
        {
            strikeActive = value;
        }

        public bool IsStrikeActive()
        {
            return strikeActive;
        }
    }
}

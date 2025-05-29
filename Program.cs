namespace SpaceStationSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation(); // błąd jeśli nie widzi namespace
            simulation.Run();
        }
    }
}

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace HW3p2
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator()) {
                // // Problem 2
                // EntryPoint.Run(sim).Wait();

                // // Problem 3
                // Test.Run(sim).Wait();
                EntryProblem3.Run(sim).Wait();

                // Problem 4
                // Problem4Entry.Run(sim).Wait();
            }

        }
    }
}
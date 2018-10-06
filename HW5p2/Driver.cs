using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace HW5p2
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator()) {
                TestAllThreeBitFlips.Run(sim).Wait();
            }
        }
    }
}
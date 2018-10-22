using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace HW3p1
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator()) {
                TestSubtracter.Run(sim, 7, 2).Wait();
            }
        }
    }
}
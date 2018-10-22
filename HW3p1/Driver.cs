using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace HW3p1
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator()) {
                // TestSubtractor.Run(sim, 7, 2).Wait();
                TestXIfLessThan.Run(sim, 4).Wait();
            }
        }
    }
}
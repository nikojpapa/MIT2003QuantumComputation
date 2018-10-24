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
                // TestXIfLessThanOrEqual.Run(sim, 4).Wait();
                // TestPeriodicFunction.Run(sim, 3).Wait(-1);
                VerifyProblem5.Run(sim, 8, 2).Wait(-1);
            }
        }
    }
}
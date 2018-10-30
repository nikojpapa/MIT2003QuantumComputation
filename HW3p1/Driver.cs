using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
// using Utils;

namespace HW3p1
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator()) {
                // TestSubtractor.Run(sim, 7, 2).Wait();
                // TestQFTSubtractor.Run(sim, 7, 4).Wait(-1);
                // TestXIfLessThanOrEqual.Run(sim, 4).Wait();
                // TestPeriodicFunction.Run(sim, 4).Wait(-1);
                // VerifyProblem5.Run(sim, 8, 2, 4).Wait(-1);

                // _TestQFTAdder.Run(sim, 3).Wait(-1);
                // _TestMultiplier.Run(sim, 3).Wait(-1);
                // _TestSquareNumber.Run(sim, 3).Wait(-1);
                _TestOrderFindingQuantumPow.Run(sim, 2).Wait(-1);
                // _TestOrderFindingU.Run(sim).Wait(-1);
            }
        }
    }
}
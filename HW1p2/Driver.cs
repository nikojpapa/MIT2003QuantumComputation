using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace HW1p2
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator()) {
                // Random rnd= new Random();
                
                // double jx = rnd.NextDouble();
                // double jy = Math.Sqrt(rnd.NextDouble() * (1 - Math.Pow(jx, 2)));
                // double jz = Math.Sqrt(1 - Math.Pow(jx, 2) - Math.Pow(jy, 2));
                // PauliJ pauliJ = (PauliJ) (jx, jy, jz);

                // double alpha = rnd.NextDouble();
                // double beta = Math.Sqrt(1 - Math.Pow(alpha, 2));

                var res = TestPauliJ.Run(sim).Result;
            }
        }
    }
}
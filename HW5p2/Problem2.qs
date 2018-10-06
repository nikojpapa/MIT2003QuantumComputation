namespace HW5p2 {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;

    operation P2Solution(code: Qubit[]) : () {
        body {
            ApplyToEach(H, code);

            let pairity1 = Measure([PauliX; PauliX; PauliI], code);
            let pairity2 = Measure([PauliI; PauliX; PauliX], code);

            ApplyToEach(H, code);       

            if (pairity1 == One && pairity2 == One) {
                Z(code[1]);
            } elif (pairity1 == One) {
                Z(code[0]);
            } elif (pairity2 == One) {
                Z(code[2]);
            }
        }
    }

    function GenerateCoefficientSame(word: Double): ComplexPolar {
        return ComplexToComplexPolar(Complex(word, 0.0));
    }

    function GenerateCoefficientOpp(word: Double): ComplexPolar {
        return ComplexToComplexPolar(Complex(1.0 - word, 0.0));
    }

    operation EncodePhaseFlipCode(data: Qubit, auxillaryQubits: Qubit[]): () {  // word is either 0.0 or 1.0 corresponding to word |0> or |1>
        body {
            CNOT(data, auxillaryQubits[0]);
            CNOT(data, auxillaryQubits[1]);

            ApplyToEachA(H, [data] + auxillaryQubits);
        }

        adjoint auto;
    }

    operation TestP2Solution (errorize: (Qubit[] => ())) : ()
    {
        body
        {
            using (register = Qubit[3]) {
                let data = register[0];
                let auxillaryQubits = register[1..2];

                EncodePhaseFlipCode(data, auxillaryQubits);
                // AssertProbIntBE(2, 1.0 / 4.0, BigEndian(register), 0.000000000000001);

                errorize(register);

                ApplyToEach(H, register);

                P1Solution(register);

                ApplyToEach(H, register);

                (Adjoint EncodePhaseFlipCode)(data, auxillaryQubits);
                Assert([PauliZ], [data], Zero, "Didn't return to Zero");
            }
        }
    }

    operation TestAllThreePhaseFlips(): () {
        body {
            let Z0 = ApplyPauli([PauliZ; PauliI; PauliI], _);
            let Z1 = ApplyPauli([PauliI; PauliZ; PauliI], _);
            let Z2 = ApplyPauli([PauliI; PauliI; PauliZ], _);

            TestP2Solution(Z0);
            TestP2Solution(Z1);
            TestP2Solution(Z2);
        }
    }
}
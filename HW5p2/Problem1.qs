namespace HW5p2
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;

    operation P1Solution(code: Qubit[]) : () {
        body {
            using (workQubits = Qubit[2]) {
                CNOT(code[0], workQubits[0]);
                CNOT(code[1], workQubits[0]);

                CNOT(code[1], workQubits[1]);
                CNOT(code[2], workQubits[1]);

                let result1 = M(workQubits[0]);
                let result2 = M(workQubits[1]);

                if (result1 == Zero) {
                    if (result2 == Zero) {
                        // Message("{|000>, |111>}");
                    } else {
                        // Message("{|001>, |110>}");
                        X(code[2]);
                    }
                } else {
                    if (result2 == Zero) {
                        // Message("{|100>, |011>}");
                        X(code[0]);
                    } else {
                        // Message("{|010>, |101>}");
                        X(code[1]);
                    }
                }

                ResetAll(workQubits);
            }
        }
    }

    operation TestP1Solution (errorize: (Qubit[] => ())) : ()
    {
        body
        {
            let (encoder, decoder, synd) = BitFlipCode();

            using (register = Qubit[3]) {
                let data = register[0];
                let auxillaryQubits = register[1..2];

                Rx(PI() / 3.0, data);  // test state
                let code = encoder([data], auxillaryQubits);

                errorize(code);

                P1Solution(code);

                let (decodedData, decodedAuxillary) = decoder(code);
                (Adjoint Rx)(PI() / 3.0, data);
                Assert([PauliZ], [data], Zero, "Didn't return to |0〉");
            }
        }
    }

    operation TestAllThreeBitFlips(): () {
        body {
            let X0 = ApplyPauli([PauliX; PauliI; PauliI], _);
            let X1 = ApplyPauli([PauliI; PauliX; PauliI], _);
            let X2 = ApplyPauli([PauliI; PauliI; PauliX], _);

            TestP1Solution(X0);
            TestP1Solution(X1);
            TestP1Solution(X2);
        }
    }
}

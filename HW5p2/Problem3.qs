namespace HW5p2 {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;

    operation EncodeIntoBitFlipCode(
            data : Qubit, auxillaryQubits : Qubit[]
        ) : ()
    {
        body {
            ApplyToEachCA(CNOT(data, _), auxillaryQubits);
        }

        adjoint auto
        controlled auto
        controlled adjoint auto
    }

    operation P2BlockSolution(code: Qubit[]) : () {
        body {
            ApplyToEach(H, code);

            using(workQubits = Qubit[2]) {
                for (i in 0..1) {
                    for (j in 0..5) {
                        CNOT(code[j + i * 3], workQubits[i]);
                    }
                }

                let result1 = M(workQubits[0]);
                let result2 = M(workQubits[1]);

                if (result1 == Zero) {
                    if (result2 == Zero) {
                        Message("{|000>, |111>}");
                    } else {
                        Message("{|001>, |110>}");
                        ApplyToEach(X, code[6..8]);
                    }
                } else {
                    if (result2 == Zero) {
                        Message("{|100>, |011>}");
                        ApplyToEach(X, code[0..2]);
                    } else {
                        Message("{|010>, |101>}");
                        ApplyToEach(X, code[3..5]);
                    }
                }

                ResetAll(workQubits);
            }

            ApplyToEach(H, code);
        }
    }

    operation EncodeShorFlipCode(data: Qubit, auxillaryZQubits: Qubit[], auxillaryXQubits: Qubit[]): () {
        body {
            EncodePhaseFlipCode(data, auxillaryZQubits);

            EncodeIntoBitFlipCode(data, auxillaryXQubits[0..1]);
            EncodeIntoBitFlipCode(auxillaryZQubits[0], auxillaryXQubits[2..3]);
            EncodeIntoBitFlipCode(auxillaryZQubits[1], auxillaryXQubits[4..5]);
        }

        adjoint auto;
    }

    operation TestP3Solution (errorize: (Qubit[] => ())) : ()
    {
        body
        {
            using (register = Qubit[9]) {
                let data = register[0];
                let auxillaryZQubits = Subarray([3; 6], register);
                let auxillaryXQubits = Subarray([1;2;4;5;7;8], register);

                EncodeShorFlipCode(data, auxillaryZQubits, auxillaryXQubits);

                errorize(register);

                P1Solution([data] + auxillaryXQubits[0..1]);
                P1Solution([auxillaryZQubits[0]] + auxillaryXQubits[2..3]);
                P1Solution([auxillaryZQubits[1]] + auxillaryXQubits[4..5]);

                P2BlockSolution(register);

                (Adjoint EncodeShorFlipCode)(data, auxillaryZQubits, auxillaryXQubits);
                Assert([PauliZ], [data], Zero, "Didn't return to Zero");
            }
        }
    }

    operation ApplyMultiPauli(paulis: (Qubit[] => ())[], target: Qubit[]): () {
        body {
            for (i in 0..Length(paulis)-1) {
                (paulis[i])(target);
            }
        }
    }

    operation TestAllPauliErrors(): () {
        body {
            for (b in 0..8) {
                for (i in 0..3) {
                    for (j in 0..3) {
                        mutable paulis1 = new Int[9];
                        mutable paulis2 = new Int[9];
                        set paulis1[b] = i;
                        set paulis2[b] = j;
                        Message($"{paulis1}");
                        Message($"{paulis2}");
                        Message("");

                        let op1 = ApplyPauli(IntsToPaulis(paulis1), _);
                        let op2 = ApplyPauli(IntsToPaulis(paulis2), _);

                        TestP3Solution(ApplyMultiPauli([op1; op2], _));
                    }
                }
            }
        }
    }
}
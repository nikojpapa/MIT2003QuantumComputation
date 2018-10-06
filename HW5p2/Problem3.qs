namespace HW5p2 {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;

    // operation P3Solution(code: Qubit[]) : () {
    //     body {
    //         ApplyToEach(H, code);

    //         let pairity1 = Measure([PauliX; PauliX; PauliI], code);
    //         let pairity2 = Measure([PauliI; PauliX; PauliX], code);

    //         ApplyToEach(H, code);       

    //         if (pairity1 == One && pairity2 == One) {
    //             Z(code[1]);
    //         } elif (pairity1 == One) {
    //             Z(code[0]);
    //         } elif (pairity2 == One) {
    //             Z(code[2]);
    //         }
    //     }
    // }

    operation EncodeShorFlipCode(data: Qubit, auxillaryZQubits: Qubit[], auxillaryXQubits: Qubit[]): () {
        body {
            ApplyToEachA(CNOT(data, _), auxillaryZQubits);
            ApplyToEachA(H, [data] + auxillaryZQubits);

            ApplyToEachA(CNOT(data, _), auxillaryXQubits[0..1]);
            ApplyToEachA(CNOT(auxillaryZQubits[0], _), auxillaryXQubits[2..3]);
            ApplyToEachA(CNOT(auxillaryZQubits[1], _), auxillaryXQubits[4..5]);
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

                P2Solution([data] + auxillaryZQubits);

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
                        mutable paulis1 = new Int[8];
                        mutable paulis2 = new Int[8];
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
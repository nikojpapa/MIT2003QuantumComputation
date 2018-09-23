namespace HW3p2 {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Primitive;

    operation FredkinNot(control: Qubit, swap1: Qubit, swap2: Qubit): () {
        body {
            X(control);

            mutable controlReg = new Qubit[1];
            set controlReg[0] = control;
            (Controlled SWAP)(controlReg, (swap1, swap2));
        }
    }

    operation NControlledU(qubits: Qubit[], op: (Qubit => (): Controlled, Adjoint)) : () {
        body {
            let controlReg = Most(qubits);
            mutable targetReg = new Qubit[1];
            let target = Tail(qubits);
            set targetReg[0] = target;

            let numControlQubits = Length(controlReg);
            let halfNum = numControlQubits / 2;
            let topControl = controlReg[0..halfNum-1];
            let bottomControl = controlReg[halfNum..numControlQubits-1];

            using (workQ = Qubit[1]) {
                for (i in 0..halfNum-1) {
                    FredkinNot(topControl[i], bottomControl[i], workQ[0]);
                    if (halfNum == 1) {
                        (Controlled op)(bottomControl, target);
                    } else {
                        NControlledU(bottomControl + targetReg, op);
                    }
                    FredkinNot(topControl[i], bottomControl[i], workQ[0]);
                }

                ResetAll(workQ);
            }
        }
    }

    function NumIsOne(num: Int): Bool {
        return num == 1;
    }

    operation InitQubit(index: Int, binaryRep: Int[], target: Qubit): () {
        body {
            ApplyIf(X, NumIsOne(binaryRep[index]), target);        
        }
    }

    operation Problem4Entry(): () {
        body {
            let numQubits = 3;
            // let f = NControlledU(_, X);
            // AssertOperationsEqualInPlace(NControlledU(_, X), (Adjoint (Controlled X)), 3);

            let allBinaries = GenerateAllBinariesOfLength(numQubits);

            using (qubits = Qubit[numQubits]) {
                for (i in 0..Length(allBinaries)-1) {
                    let thisBinary = allBinaries[i];
                    Message($"thisBinary: {thisBinary}");
                    ApplyToEachIndex(InitQubit(_, thisBinary, _), qubits);
                    // for (j in 0..numQubits-1) {
                    //     let shouldBe = ResultFromBool(NumIsOne(thisBinary[j]));
                    //     Message($"{j}: {shouldBe}");
                    //     AssertQubit(shouldBe, qubits[j]);
                    // }

                    NControlledU(qubits, X);

                    mutable expectedResult = ResultFromBool(NumIsOne(Tail(thisBinary)));
                    if (ForAll(NumIsOne, Most(thisBinary))) {
                        set expectedResult = ResultFromBool(!BoolFromResult(expectedResult));
                    }

                    AssertQubit(expectedResult, Tail(qubits));

                    ResetAll(qubits);
                }
            }
        }
    }
}
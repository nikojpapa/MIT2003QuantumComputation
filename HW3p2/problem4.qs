namespace HW3p2 {
    
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Primitive;
    
    
    operation FredkinNot (controlReg : Qubit[], swap1 : Qubit, swap2 : Qubit) : Unit {
        
        body (...) {
            AssertIntEqual(Length(controlReg), 1, "Fredkin only takes one control qubit");
            X(controlReg[0]);
            Controlled SWAP(controlReg, (swap1, swap2));
            X(controlReg[0]);
        }
        
        adjoint invert;
    }
    
    
    operation NControlledU (qubits : Qubit[], op : (Qubit => Unit : Controlled, Adjoint)) : Unit {
        
        body (...) {
            let controlReg = Most(qubits);
            mutable targetReg = Subarray([Length(qubits) - 1], qubits);
            let target = targetReg[0];
            let numControlQubits = Length(controlReg);
            let halfNum = numControlQubits / 2;
            let topControl = controlReg[0 .. halfNum - 1];
            let bottomControl = controlReg[halfNum .. numControlQubits - 1];
            
            using (workQ = Qubit[1]) {
                
                for (i in 0 .. halfNum - 1) {
                    FredkinNot(Subarray([i], topControl), bottomControl[i], workQ[0]);
                    
                    if (halfNum == 1) {
                        Controlled op(bottomControl, target);
                    }
                    else {
                        NControlledU(bottomControl + targetReg, op);
                    }
                    
                    FredkinNot(Subarray([i], topControl), bottomControl[i], workQ[0]);
                }
                // Reset(workQ[0]);
            }
        }
        
        adjoint invert;
    }
    
    
    function NumIsOne (num : Int) : Bool {
        
        return num == 1;
    }
    
    
    operation InitQubit (index : Int, binaryRep : Int[], target : Qubit) : Unit {
        
        ApplyIf(X, NumIsOne(binaryRep[index]), target);
    }
    
    
    operation ControlledX (qubits : Qubit[]) : Unit {
        
        Controlled X(Most(qubits), Tail(qubits));
    }
    
    
    operation Problem4Entry () : Unit {
        
        let numQubits = 5;
        
        // AssertOperationsEqualInPlace(ControlledX, NControlledU(_, X), numQubits);
        let allBinaries = GenerateAllBinariesOfLength(numQubits);
        
        using (qubits = Qubit[numQubits]) {
            
            for (i in 0 .. Length(allBinaries) - 1) {
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
                    set expectedResult = ResultFromBool(not BoolFromResult(expectedResult));
                }
                
                AssertQubit(expectedResult, Tail(qubits));
                ResetAll(qubits);
            }
        }
    }
    
}



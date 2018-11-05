namespace HW3p2 {
    
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Primitive;
    
    
    function GenerateAllBinariesOfLength (length : Int) : Int[][] {
        
        mutable initialBinaries = new Int[][1];
        set initialBinaries[0] = new Int[length];
        return GenerateBinaries(initialBinaries, 0);
    }
    
    
    operation PrepareSuccess (binaryRep : Int[], qubits : Qubit[]) : Unit {
        
        AssertIntEqual(Length(binaryRep), Length(qubits), "Binary representation and qubit register must have equal length");
        
        for (i in 0 .. Length(binaryRep) - 1) {
            
            if (binaryRep[i] == 0) {
                X(qubits[i]);
            }
        }
    }
    
    
    operation TestPrepareSuccess () : Unit {
        
        mutable initialBinaries = new Int[][1];
        set initialBinaries[0] = new Int[2];
        let allBinaries = GenerateBinaries(initialBinaries, 0);
        
        using (workQubits = Qubit[2]) {
            
            // every possible solution state
            for (i in 0 .. Length(allBinaries) - 1) {
                let successBinary = allBinaries[i];
                
                // every possible work qubit state
                for (j in 0 .. Length(allBinaries) - 1) {
                    let workQubitBinary = allBinaries[j];
                    mutable keyCardBinary = new Int[Length(workQubitBinary)];
                    
                    // set work qubits
                    for (k in 0 .. Length(workQubitBinary) - 1) {
                        
                        if (workQubitBinary[k] == 1) {
                            X(workQubits[k]);
                        }
                        
                        set keyCardBinary[k] = (workQubitBinary[k] + (1 - successBinary[k])) % 2;
                    }
                    
                    PrepareSuccess(successBinary, workQubits);
                    
                    for (k in 0 .. Length(workQubits) - 1) {
                        mutable keyCardResult = Zero;
                        
                        if (keyCardBinary[k] == 1) {
                            set keyCardResult = One;
                        }
                        
                        // Message($"prepare success failure; Success: {successBinary}, workQubitBinary: {workQubitBinary}, keyCardBinary: {keyCardBinary}, qubit: {k}");
                        AssertQubit(keyCardResult, workQubits[k]);
                    }
                    
                    ResetAll(workQubits);
                }
            }
        }
    }
    
    
    operation Oracle (successBinary : Int[], workQubits : Qubit[], ancillaQubit : Qubit) : Unit {
        
        AssertIntEqual(Length(successBinary), Length(workQubits), "Success binary and work qubits must have equal length");
        AssertQubit(Zero, ancillaQubit);
        PrepareSuccess(successBinary, workQubits);
        X(ancillaQubit);
        H(ancillaQubit);
        Controlled Z(workQubits, ancillaQubit);
        PrepareSuccess(successBinary, workQubits);
    }
    
    
    operation TestOracle () : Unit {
        
        let allBinaries = GenerateAllBinariesOfLength(2);
        
        using (qubits = Qubit[3]) {
            let workQubits = qubits[0 .. 1];
            let ancillaQubit = qubits[2];
            
            for (i in 0 .. Length(allBinaries) - 1) {
                let successBinary = allBinaries[i];
                
                for (j in 0 .. Length(allBinaries) - 1) {
                    let workQubitBinary = allBinaries[j];
                    mutable isSolution = true;
                    
                    for (k in 0 .. Length(workQubitBinary) - 1) {
                        
                        if (workQubitBinary[k] == 1) {
                            X(workQubits[k]);
                        }
                        
                        if (isSolution && (successBinary[k] + workQubitBinary[k]) % 2 != 0) {
                            set isSolution = false;
                        }
                    }
                    
                    Oracle(successBinary, workQubits, qubits[2]);
                    H(ancillaQubit);
                    mutable expectedResult = One;
                    
                    if (isSolution) {
                        set expectedResult = Zero;
                    }
                    
                    AssertQubit(expectedResult, ancillaQubit);
                    ResetAll(workQubits);
                    Reset(ancillaQubit);
                }
            }
        }
    }
    
    
    // conditionally flip phase if state is anything but all |0>
    operation InversionAboutMean (workQubits : Qubit[]) : Unit {
        
        // in actuality, it flips only the |0> state, which introduces a global phase of -1, which can be ignored
        ApplyToEach(X, workQubits);
        Controlled Z(Most(workQubits), Tail(workQubits));
        ApplyToEach(X, workQubits);
    }
    
    
    operation TestInversionAboutMean () : Unit {
        
        let allBinaries = GenerateAllBinariesOfLength(2);
        
        for (i in 0 .. Length(allBinaries) - 1) {
            let workQubitBinary = allBinaries[i];
            mutable allZeros = true;
            
            using (workQubits = Qubit[Length(workQubitBinary)]) {
                
                for (j in 0 .. Length(workQubitBinary) - 1) {
                    
                    if (workQubitBinary[j] == 1) {
                        X(workQubits[j]);
                        set allZeros = false;
                    }
                }
                
                InversionAboutMean(workQubits);
                H(Tail(workQubits));
                
                if (allZeros) {
                    AssertPhase(PI(), Tail(workQubits), 1E-10);
                }
                elif (Tail(workQubitBinary) == 1) {
                    AssertPhase(PI() / 2.0, Tail(workQubits), 1E-10);
                }
                elif (Head(workQubitBinary) == 1) {
                    AssertPhase(0.0, Tail(workQubits), 1E-10);
                }
                
                ResetAll(workQubits);
            }
        }
    }
    
    
    operation GroverIteration (successBinary : Int[], workQubits : Qubit[], ancillaQubit : Qubit) : Unit {
        
        AssertIntEqual(Length(successBinary), Length(workQubits), "Success binary and work qubits must have equal length");
        AssertQubit(Zero, ancillaQubit);
        Oracle(successBinary, workQubits, ancillaQubit);
        ApplyToEach(H, workQubits);
        InversionAboutMean(workQubits);
        ApplyToEach(H, workQubits);
    }
    
    
    // grover iteration succeeds 100% of the time when there are 1/4 success states of length 2
    operation EntryProblem3 () : Unit {
        
        let numWorkQubits = 2;
        let numIterations = 1;
        mutable successBinary = new Int[2];
        set successBinary[0] = 0;
        set successBinary[1] = 0;
        
        using (qubits = Qubit[numWorkQubits + numIterations]) {
            let workQubits = qubits[0 .. numWorkQubits - 1];
            let ancillaQubits = qubits[numWorkQubits .. Length(qubits) - 1];
            let testNumWorkQubits = Length(workQubits);
            let testNumAncillaQubits = Length(ancillaQubits);
            Message($"num workQubits: {testNumWorkQubits}");
            Message($"num ancilla: {testNumAncillaQubits}");
            ApplyToEach(H, workQubits);
            
            for (i in 0 .. numIterations - 1) {
                Message($"iteration {i}");
                GroverIteration(successBinary, workQubits, ancillaQubits[i]);
            }
            
            for (i in 0 .. Length(workQubits) - 1) {
                mutable successResult = Zero;
                
                if (successBinary[i] == 1) {
                    set successResult = One;
                }
                
                Message($"qubit #{i}");
                AssertQubit(successResult, workQubits[i]);
            }
            
            ResetAll(qubits);
        }
    }
    
    
    operation Test () : Unit {
        
        TestPrepareSuccess();
        TestOracle();
        TestInversionAboutMean();
    }
    
}
// operation TestImp(workQubits: Qubit[]): () {
// body {
// using (toggle = Qubit[1]) {  // flips phase only if initial state was all |0>
// for (i in 0..Length(workQubits) - 1) {
// X(workQubits[i]);
// }

// (Controlled X)(workQubits, toggle[0]);
// AssertQubit(Zero, toggle[0]);

// (Controlled Z)(toggle, workQubits[0]);

// for (i in 0..Length(workQubits) - 1) {
// X(workQubits[i]);
// }

// ResetAll(toggle);
// }
// }
// }



namespace HW3p2 {
    
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    
    
    operation PowRn (y : Int, n : Int, qubits : BigEndian) : Unit {
        
        for (i in 0 .. Length(qubits!) - 1) {
            R1Frac(y, i, qubits![i]);
        }
    }
    
    
    operation Rn (n : Int, qubits : BigEndian) : Unit {
        
        for (i in 0 .. Length(qubits!) - 1) {
            R1Frac(1, i, qubits![i]);
        }
    }
    
    
    operation PerformAddition (binaryOperandA : Int[], operandB : Int) : Int[] {
        
        let numInputQubits = Length(binaryOperandA);
        mutable initialStateCoefficients = new ComplexPolar[numInputQubits];
        
        // for (i in 0..Length(initialStateCoefficients)-2) {
        //     set initialStateCoefficients[i] = ComplexPolar(0.0, 0.0);
        // }
        // set initialStateCoefficients[numStates - 1] = ComplexPolar(1.0, 0.0);
        // Message($"{initialStateCoefficients}");
        mutable resultBinary = new Int[numInputQubits];
        
        using (qubits = Qubit[numInputQubits]) {
            mutable bigEndian = BigEndian(qubits);
            
            for (i in 0 .. numInputQubits - 1) {
                
                if (binaryOperandA[i] == 1) {
                    X(bigEndian![i]);
                }
            }
            
            // AssertProbIntBE(1, 1.0, bigEndian, 0.000001);
            QFT(bigEndian);
            PowRn(operandB, numInputQubits, bigEndian);
            
            // for (i in 0..operandB-1) {
            //     Rn(numInputQubits, bigEndian);
            // }
            Adjoint QFT(bigEndian);
            
            for (i in 0 .. numInputQubits - 1) {
                mutable intResult = 0;
                let result = M(bigEndian![i]);
                let resultIsOne = IsResultOne(result);
                
                if (resultIsOne) {
                    set intResult = 1;
                }
                
                set resultBinary[i] = intResult;
            }
            
            ResetAll(qubits);
        }
        
        return resultBinary;
    }
    
    
    function GenerateBinaries (allBinaries : Int[][], depth : Int) : Int[][] {
        
        let numBinaries = Length(allBinaries);
        let lastBinary = allBinaries[numBinaries - 1];
        let binaryLength = Length(lastBinary);
        let newBinaryPosition = numBinaries;
        
        if (depth > binaryLength - 1) {
            return allBinaries;
        }
        
        mutable newBinary = new Int[binaryLength];
        
        for (i in 0 .. binaryLength - 1) {
            set newBinary[i] = lastBinary[i];
        }
        
        let binariesFromZero = GenerateBinaries(allBinaries, depth + 1);
        set newBinary[depth] = 1;
        mutable newAllBinaries2 = new Int[][Length(binariesFromZero) + 1];
        
        for (i in 0 .. Length(binariesFromZero) - 1) {
            set newAllBinaries2[i] = binariesFromZero[i];
        }
        
        set newAllBinaries2[Length(binariesFromZero)] = newBinary;
        let binariesFromOne = GenerateBinaries(newAllBinaries2, depth + 1);
        return binariesFromOne;
    }
    
    
    operation EntryPoint () : Unit {
        
        let numTestQubits = 2;
        let maxOperandB = 2;
        mutable initialBinaries = new Int[][1];
        set initialBinaries[0] = new Int[numTestQubits];
        let allBinaries = GenerateBinaries(initialBinaries, 0);
        Message($"{allBinaries}");
        
        for (i in 0 .. Length(allBinaries) - 1) {
            let binaryOperandA = allBinaries[i];
            
            for (j in 0 .. maxOperandB) {
                let result = PerformAddition(binaryOperandA, j);
                mutable display = "";
                
                for (k in 0 .. Length(result) - 1) {
                    set display = display + ToStringI(result[k]);
                }
                
                Message($"{binaryOperandA} + {j} => {display}");
            }
        }
    }
    
}



namespace HW3p1 {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Primitive;
    open Utils;

    operation QFTAdder(start: Qubit[], amount: Qubit[]): () {
        body {
            AssertIntEqual(Length(start), Length(amount), "Must be equal length");
            let bigEndian = BigEndian(start);

            QFT(bigEndian);

            for (i in 0..Length(amount) - 1) {
                let startSubArray = start[Length(start) - 1 - i..Length(start) - 1];
                SwapReverseRegister(startSubArray);
                ApplyToEachIndexCA((Controlled R1Frac)([amount[i]], (1, _, _)), startSubArray);
                SwapReverseRegister(startSubArray);
                // for (j in i..Length(start) - i) {
                //     (Controlled R1Frac)([amount[i]], (1, i, start[Length(start) - 1 - i])))
                // }
                // ApplyToEachIndexCA((Controlled R1Frac)([amount[i]], (1, i, start[Length(start) - 1 - i])); 
            }
            // ApplyToEachIndexCA(R1Frac(amount, _, _), start);
            (Adjoint QFT)(bigEndian);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
    // operation _AddComputationalBasis(start: Qubit[], amount: Qubit[]): () {
    //     body {
    //         let startInt = MeasureIntegerBE(BigEndian(start));
    //         let amountInt = QubitsToInt(amount);
    //         let ans = IntToBinary(startInt + amountInt);

    //         Message($"{startInt} + {amountInt} = {ans}");

    //         SetQubits(start, ans);

    //         Message(ToStringI(QubitsToInt(start)));
    //     }
    // }
    // operation _TestQFTAdderLevel2(q: Qubit[], binaryLength: Int): () {
    //     body {
    //         AssertOperationsEqualInPlaceCompBasis(_AddComputationalBasis(_ ,q), QFTAdder(_, q), binaryLength);
    //     }
    // }
    operation _TestQFTAdderImpl(q1: Qubit[], q2: Qubit[]): () {
        body {
            let q1Val = QubitsToInt(q1);
            let q2Val = QubitsToInt(q2);

            QFTAdder(q1, q2);

            let calcAns = QubitsToInt(q1);
            let trueAns = q1Val + q2Val;
            AssertIntEqual(calcAns, trueAns, $"{q1Val} + {q2Val} != {calcAns}");
            Message($"{q1Val} + {q2Val} == {calcAns}");
        }
    }
    operation _TestQFTAdder(binaryLength: Int): () {
        body {
            RunOnAllTwoBinariesOfLength(binaryLength, _TestQFTAdderImpl);
        }
    }

    // operation OrderFindingU(k: Int, xInt: Int, target: Qubit[]): () {  // U|k> = |x * k>
    //     body {
    //         AssertAllZero(target);
    //         for (i in 0..k - 1) {
    //             QFTAdder(target, x);
    //         }
    //     }

    //     adjoint auto;
    //     controlled auto;
    //     controlled adjoint auto;
    // }

    // operation _MultiplyIntsComputationalBasis(k: Int, x: Int, xReg: Qubit[]): () {
    //     body {
    //         let product = k * x;
    //         let productBinary = IntToBinary(product);
    //         let pLength = Length(productBinary);
    //         let xLength = Length(xReg);
    //         SetQubits(xReg[xLength - pLength..xLength - 1], productBinary);
    //     }

    //     adjoint auto;
    //     controlled auto;
    //     controlled adjoint auto;
    // }
    
    // operation _TestOrderFindingU(): () {
    //     body {
    //         using(qubits = Qubit[12]) {
    //             let test1Reg = qubits[0..5];
    //             let test2Reg = qubits[5..10];
                
    //             for (k in 0..4) {
    //                 for (x in 0..4) {
    //                     OrderFindingU(k, x, test1Reg);
    //                     _MultiplyIntsComputationalBasis(k, x, test2Reg);

    //                     let uAns = MeasureIntegerBE(BigEndian(test1Reg));
    //                     let realAns = MeasureIntegerBE(BigEndian(test2Reg));
    //                     AssertIntEqual(uAns, realAns, $"{uAns} != {realAns}");
    //                     Message($"{uAns} == {realAns}");
    //                 }
    //             }
    //         } 
    //     }
    // }
}
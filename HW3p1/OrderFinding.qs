namespace HW3p1 {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Primitive;
    open Utils;

    operation QFTAdder(start: Qubit[], amount: Qubit[]): () {
        body {
            let bigEndian = BigEndian(start);

            QFT(bigEndian);

            for (i in Length(amount) - 1..-1..0) {
                let add = 2 ^ (Length(amount) - 1 - i);
                ApplyToEachIndexCA((Controlled R1Frac)([amount[i]], (add, _, _)), start);
            }

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
    operation _TestQFTAdderImpl(q1: Qubit[], q2: Qubit[], modulus: Int): () {
        body {
            let q1Val = QubitsToInt(q1);
            let q2Val = QubitsToInt(q2);

            QFTAdder(q1, q2);

            let calcAns = QubitsToInt(q1);
            let trueAns = (q1Val + q2Val) % modulus;
            AssertIntEqual(calcAns, trueAns, $"{q1Val} + {q2Val} != {calcAns}");
            Message($"{q1Val} + {q2Val} == {calcAns}");
        }
    }
    operation _TestQFTAdder(binaryLength: Int): () {
        body {
            RunOnAllTwoBinariesOfLength(binaryLength, _TestQFTAdderImpl(_, _, 2 ^ binaryLength));
        }
    }

    operation Multiplier(multiplicand: Qubit[], multiplier: Qubit[], target: Qubit[]): () {  // target must be able to contain product
        body {
            (Controlled QFTAdder)([multiplier[Length(multiplier) - 1]], (target, multiplicand));
            for (i in Length(multiplier) - 2..-1..0) { 
                using (leftShifts = Qubit[Length(multiplier) - 1 - i]) {
                    (Controlled QFTAdder)([multiplier[i]], (target, multiplicand + leftShifts));
                }
            }
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation _TestMultiplierImpl(q1: Qubit[], q2: Qubit[]): () {
        body {
            let q1Val = QubitsToInt(q1);
            let q2Val = QubitsToInt(q2);
            let maxProduct = 2 ^ Length(q1) * 2 ^ Length(q2);
            let maxProductLength = BitSize(maxProduct);

            using (target = Qubit[maxProductLength]) {
                Multiplier(q1, q2, target);

                let calcAns = QubitsToInt(target);
                let trueAns = q1Val * q2Val;
                AssertIntEqual(calcAns, trueAns, $"{q1Val} * {q2Val} != {calcAns}");
                Message($"{q1Val} * {q2Val} == {calcAns}");

                ResetAll(target);
            }
        }
    }
    operation _TestMultiplier(binaryLength: Int): () {
        body {
            RunOnAllTwoBinariesOfLength(binaryLength, _TestMultiplierImpl);
        }
    }

    operation _QuantumPowImpl(baseQ: Qubit[], ancillas1: Qubit[], ancillas2: Qubit[], control: Qubit, currentProduct: Qubit[], depth: Int): () {
        body {
            if (depth == 0) {
                QFTAdder(ancillas1, baseQ);
            } else {
                QFTAdder(ancillas2, baseQ);
                Multiplier(ancillas2, baseQ, ancillas1);
                (Adjoint QFTAdder)(ancillas2, baseQ);
            }
            (Controlled Multiplier)([control], (ancillas1, currentProduct, ancillas2));
            X(control);
            (Controlled QFTAdder)([control], (ancillas2, currentProduct));
            X(control);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation QuantumPow(powQ: Qubit[], baseQ: Qubit[], target: Qubit[], depth: Int, currentProduct: Qubit[]): () {  // U|k> = |x * k>
        body {
            AssertAllZero(target);
            if (depth == Length(powQ)) {
                CopyQubits(currentProduct, target);
            } else {
                let targetLength = Length(target);
                using(ancillas = Qubit[targetLength * 2]) {
                    let ancillas1 = ancillas[0..targetLength - 1];
                    let ancillas2 = ancillas[targetLength..Length(ancillas) - 1];
                    let control = powQ[Length(powQ) - 1 - depth];

                    _QuantumPowImpl(baseQ, ancillas1, ancillas2, control, currentProduct, depth);

                    QuantumPow(powQ, ancillas1, target, depth + 1, ancillas2);

                    (Adjoint _QuantumPowImpl)(baseQ, ancillas1, ancillas2, control, currentProduct, depth);
                    
                }
            }
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation _TestOrderFindingQuantumPowImpl(q1: Qubit[], q2: Qubit[], N: Int): () {
        body {
            let q1Val = QubitsToInt(q1);
            let q2Val = QubitsToInt(q2);

            using (qubits = Qubit[BitSize(N) + 1]) {
                let target = Most(qubits);
                let startProduct = Tail(qubits);
                X(startProduct);
                QuantumPow(q1, q2, target, 0, [startProduct]);

                let calcAns = QubitsToInt(target);
                let trueAns = q2Val ^ q1Val % 2 ^ Length(target);
                AssertIntEqual(calcAns, trueAns, $"{q2Val} ^ {q1Val} == {trueAns} != {calcAns}");
                Message($"{q2Val} ^ {q1Val} == {calcAns}");

                ResetAll(qubits);
            }
        }
    }
    operation _TestOrderFindingQuantumPow(binaryLength: Int, N: Int): () {
        body {
            RunOnAllTwoBinariesOfLength(binaryLength, _TestOrderFindingQuantumPowImpl(_, _, N));
        }
    }

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
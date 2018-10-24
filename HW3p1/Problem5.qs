namespace HW3p1
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Primitive;
    open Utils;

    // operation _SubtractBit(t1: Qubit, t2: Qubit, borrowIn: Qubit, borrowOut: Qubit): () {
    //     body {
    //         Assert([PauliZ], [borrowOut], Zero, "Borrow out is not in |0> state");

    //         X(t1);
    //         Toffoli(t1, t2, borrowOut);
    //         Toffoli(t1, borrowIn, borrowOut);
    //         Toffoli(t2, borrowIn, borrowOut);
    //         X(t1);
    //         // let m4 = M(borrowOut);
    //         // Message($"borrowOut: {m4}");

    //         ApplyToEachCA(CNOT(_, t1), [t2; borrowIn]);
    //     }

    //     adjoint auto;
    //     controlled auto;
    //     controlled adjoint auto;
    // }
    // operation Subtractor(start: Qubit[], amount: Qubit[], borrows: Qubit[]): () {
    //     body {
    //         AssertBoolEqual(Length(start) >= Length(amount), true, $"unequal operand lengths");
    //         AssertIntEqual(Length(start) + 1, Length(borrows), $"not right amount of borrows");

    //         using(padding = Qubit[1]) {
    //             for (j in Length(start) - 1..-1..0) {
    //                 let sop = _SubtractBit(start[j], _, borrows[j+1], borrows[j]);
    //                 if (j >= Length(start) - Length(amount)) {
    //                     sop(amount[j - Length(start) + Length(amount)]);
    //                 } else {
    //                     sop(padding[0]);
    //                 }
    //                 // let m1 = M(start[j]);
    //                 // let m2 = M(amountBit);
    //                 // let m3 = M(borrows[j+1]);
    //                 // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
    //             }
    //         }

    //     }
        
    //     adjoint auto;
    //     controlled auto;
    //     controlled adjoint auto;
    // }

    operation QFTSubtractor(start: Qubit[], amount: Int): () {
        body {
            mutable bigEndian = BigEndian(start);

            QFT(bigEndian);
            ApplyToEachIndexCA(R1Frac(-amount, _, _), start);
            (Adjoint QFT)(bigEndian);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
    operation _TestQFTSubtractorImpl(start: Qubit[], maxR: Int): () {
        body {
            let startInt = QubitsToInt(start);
            for (r in 0..maxR) {
                QFTSubtractor(start, r);

                let ans = QubitsToInt(BigEndian(start));
                let realAns = Modulus(startInt - r, 2 ^ Length(start));
                AssertIntEqual(ans, realAns, $"{startInt} - {r} == {ans} != {realAns}");
                Message($"{startInt} - {r} == {realAns}");

                (Adjoint QFTSubtractor)(start, r);
            }
        }
    }
    operation _TestQFTSubtractor(length: Int, maxR: Int): () {
        body {
            RunOnAllBinariesOfLength(length, _TestQFTSubtractorImpl(_, maxR));
        }
    }
    // operation TestSubtractor(length: Int, rPow: Int): () {
    //     body {
    //         let binaries = GenerateAllBinariesOfLength(length);
    //         let rInt = 2 ^ rPow;
    //         let rLength = BitSize(rInt);
    //         let rLastIndex = rLength - 1;
    //         let regLastIndex = rLastIndex + length;
    //         let borrowsLastIndex = regLastIndex + length + 1;

    //         using(qubits = Qubit[borrowsLastIndex + 1]) {
    //             for (i in 0..Length(binaries) - 1) {
    //                 Message($"start: {i}:");
    //                 let binary = binaries[i];
    //                 let r = qubits[0..rLastIndex];
    //                 let register = qubits[rLastIndex + 1..regLastIndex];
    //                 let borrows = qubits[regLastIndex + 1..borrowsLastIndex];
    //                 SetQubits(register, binary);
    //                 X(Head(r));

    //                 if (QubitsToInt(register) >= rInt) {
    //                     Subtractor(register, r, borrows);

    //                     let trueAnswer = i - rInt;
    //                     let answer = QubitsToInt(register);
    //                     AssertIntEqual(trueAnswer, answer, $"Not equal. true: {trueAnswer}, calculated: {answer}");
    //                 }
    //                 Message("");

    //                 ResetAll(qubits);
    //             }
    //         }
    //     }
    // }

    // operation XIfLessThanOrEqual(a: Qubit[], b: Qubit[], target: Qubit): () {
    //     body {
    //         using(qubits = Qubit[Length(a) + 2]) {
    //             let borrows = Most(qubits);
    //             let zeroTest = Tail(qubits);
    //             Subtractor(a, b, borrows);

    //             ApplyToEachCA(X, a);
    //             (Controlled X)(a, zeroTest);
    //             ApplyToEachCA(X, a);

    //             let indicator = Head(borrows);
    //             QubitOr(indicator, zeroTest, target);

    //             ApplyToEachCA(X, a);
    //             (Controlled X)(a, zeroTest);
    //             ApplyToEachCA(X, a);

    //             (Adjoint Subtractor)(a, b, borrows);
    //         }
    //     }

    //     adjoint auto;
    //     controlled auto;
    //     controlled adjoint auto;
    // }

    // operation TestXIfLessThanOrEqual(length: Int): () {
    //     body {
    //         let binaries = GenerateAllBinariesOfLength(length);

    //         using (qubits = Qubit[length * 2 + 1]) {
    //             for (i in 0..Length(binaries) - 1) {
    //                 for (j in 0..Length(binaries) - 1) {
    //                     let binaryA = binaries[i];
    //                     let binaryB = binaries[j];
    //                     let a = qubits[0..length-1];
    //                     let b = qubits[length..length * 2 - 1];
    //                     let target = Tail(qubits);
                        
    //                     SetQubits(a, binaryA);
    //                     SetQubits(b, binaryB);

    //                     XIfLessThanOrEqual(a, b, target);

    //                     let mt = M(target);
    //                     let isLessThanOrEqual = i <= j;
    //                     Message($"{i} <= {j}: {isLessThanOrEqual}; result: {mt}");
    //                     AssertResultEqual(M(target), ResultFromBool(isLessThanOrEqual), "Incorrect");

    //                     ResetAll(qubits);
    //                 }
    //             }
    //         }
    //     }
    // }

    // operation SubtractIfPossible(a: Qubit[], b: Qubit[], borrows: Qubit[], ancilla: Qubit): () {
    //     body {
    //         Subtractor(a, b, borrows);

    //         let indicator = Head(borrows);
    //         CNOT(indicator, ancilla);

    //         (Controlled (Adjoint Subtractor))([ancilla], (a, b, borrows));
    //     }

    //     adjoint auto;
    //     controlled auto;
    //     controlled adjoint auto;
    // }

    // operation PeriodicFunction(x: Qubit[], period: Qubit[], target: Qubit, maxDivisions: Int, depth: Int): () {
    //     body {
    //         if (depth > maxDivisions) {
    //             ApplyToEachCA(X, x);
    //             (Controlled X)(x, target);
    //             ApplyToEachCA(X, x);
    //         } else {
    //             using(qubits = Qubit[Length(x) + 2]) {
    //                 let borrows = Most(qubits);
    //                 let ancilla = Tail(qubits);

    //                 SubtractIfPossible(x, period, borrows, ancilla);

    //                 PeriodicFunction(x, period, target, maxDivisions, depth + 1);

    //                 (Adjoint SubtractIfPossible)(x, period, borrows, ancilla);
    //             }
    //         }
    //     }

    //     adjoint auto;
    //     controlled auto;
    //     controlled adjoint auto;
    // }

    // operation _TestPeriodicFunctionImpl(a: Qubit[], b: Qubit[]): () {
    //     body {
    //         let aVal = QubitsToInt(a);
    //         let bVal = QubitsToInt(b);
    //         if (aVal > 0 && bVal > 0) {
    //             let maxDivisions = aVal / bVal;

    //             using(qubits = Qubit[1]) {
    //                 let target = qubits[0];
    //                 PeriodicFunction(a, b, target, maxDivisions, 0);

    //                 let result = M(target);
    //                 let divides = aVal >= bVal && aVal % bVal == 0;
    //                 let resultFromBool = ResultFromBool(divides);
    //                 Message($"{bVal} | {aVal}: {divides}({resultFromBool}); result: {result}");
    //                 AssertResultEqual(result, resultFromBool, "Incorrect");

    //                 Reset(target);
    //             }
    //         }
    //     }
    // }

    // operation TestPeriodicFunction(length: Int): () {
    //     body {
    //         RunOnAllTwoBinariesOfLength(length, _TestPeriodicFunctionImpl);
    //     }
    // }

    // operation VerifyProblem5 (t: Int, r: Int) : ()
    // {
    //     body
    //     {
    //         mutable attempts = 0;
    //         mutable success = 0;
    //         using(qubits = Qubit[t + 4]) {
    //             for (i in 0..10) {
    //                 Message($"{i}");
    //                 let rReg = qubits[t..t + 2];
    //                 X(Head(rReg));
    //                 let firstReg = qubits[0..t-1];
    //                 let secondReg = Tail(qubits);

    //                 ApplyToEach(H, firstReg);
    //                 Message($"Periodic");
    //                 PeriodicFunction(firstReg, rReg, secondReg, 4, 0);
    //                 Message($"Inverse QFT");
    //                 (Adjoint QFT)(BigEndian(firstReg));
    //                 Message($"Measure");
    //                 let l = MeasureIntegerBE(BigEndian(firstReg));
    //                 Message($"Continued Fractions");
    //                 let (s, foundR) = ContinuedFractionConvergent(Fraction(l, 2 ^ t), 10);
                    
    //                 let thisSuccess = foundR == r;
    //                 set attempts = attempts + 1;
    //                 if (thisSuccess) {
    //                     set success = success + 1;
    //                 }
    //                 Message(ToStringI(foundR));
    //                 ResetAll(qubits);
    //             }
    //         }
    //         Message($"Success Rate: {success * 1.0 / attempts}");
    //     }
    // }
}

namespace HW3p1
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Utils;

    operation Toffoli(a: Qubit, b: Qubit, c: Qubit): () {
        body {
            (Controlled X)([a; b], c);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    // operation SubtractOne(target: Qubit[], add: Qubit[], borrowIn: Qubit): () {
    //     body {

    //         using(borrowOut = Qubit[1]) {
    //             Toffoli(Tail(target), borrowIn, borrowOut[0]);
                
    //             X(Tail(target));
    //             CNOT(borrowIn, Tail(target));
    //         }
    //     }
    // }

    operation SubtractBit(t1: Qubit, t2: Qubit, borrowIn: Qubit, borrowOut: Qubit): () {
        body {
            Assert([PauliZ], [borrowOut], Zero, "Carry out is not in |0> state");

            X(t1);
            Toffoli(t1, t2, borrowOut);
            Toffoli(t1, borrowIn, borrowOut);
            Toffoli(t2, borrowIn, borrowOut);
            X(t1);
            // let m4 = M(borrowOut);
            // Message($"borrowOut: {m4}");

            ApplyToEachCA(CNOT(_, t1), [t2; borrowIn]);
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation Subtractor(start: Qubit[], amount: Qubit[], borrows: Qubit[]): () {
        body {
            AssertBoolEqual(Length(start) >= Length(amount), true, $"unequal operand lengths");
            AssertIntEqual(Length(start) + 1, Length(borrows), $"not right amount of borrows");

            using(padding = Qubit[1]) {
                for (j in Length(start) - 1..-1..0) {
                    if (j >= Length(start) - Length(amount)) {  // cannot use set to determine amount bit
                        SubtractBit(start[j], amount[j - Length(start) + Length(amount)], borrows[j+1], borrows[j]);
                    } else {
                        SubtractBit(start[j], padding[0], borrows[j+1], borrows[j]);
                    }
                    // let m1 = M(start[j]);
                    // let m2 = M(amountBit);
                    // let m3 = M(borrows[j+1]);
                    // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
                }
            }

        }
        
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }
    operation TestSubtractor(length: Int, rPow: Int): () {
        body {
            let rInt = 2 ^ rPow;
            let rLength = BitSize(rInt);
            let rLastIndex = rLength - 1;
            let regLastIndex = rLastIndex + length;
            let borrowsLastIndex = regLastIndex + length + 1;

            using(qubits = Qubit[borrowsLastIndex + 1]) {
                let binaries = GenerateAllBinariesOfLength(7);
                for (i in 0..Length(binaries) - 1) {
                    Message($"start: {i}:");
                    let binary = binaries[i];
                    let r = qubits[0..rLastIndex];
                    let register = qubits[rLastIndex + 1..regLastIndex];
                    let borrows = qubits[regLastIndex + 1..borrowsLastIndex];
                    SetQubits(register, binary);
                    X(Head(r));

                    if (QubitsToInt(register) >= rInt) {
                        Subtractor(register, r, borrows);

                        let trueAnswer = i - rInt;
                        let answer = QubitsToInt(register);
                        AssertIntEqual(trueAnswer, answer, $"Not equal. true: {trueAnswer}, calculated: {answer}");
                    }
                    Message("");

                    ResetAll(qubits);
                }
            }
        }
    }

    // operation PeriodicFunction(x: Int, period: Int, target: Qubit): Int {
    //     body {
    //         if (x % period) == 0 {
    //             X(target);
    //         }
    //     }
    // }

    // operation VerifyProblem5 (t: Int, r: Int) : ()
    // {
    //     body
    //     {
    //         using(qubits: Qubit[t + 1]) {
    //             let firstReg = Most(qubits);
    //             let secondReg = Tail(qubits);

    //             ApplyToEach(H, firstReg);
    //             ApplyToEach(PeriodicFunction(_, ))
    //         }
    //     }
    // }
}

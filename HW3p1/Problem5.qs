namespace HW3p1
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Utils;

    operation Toffoli(a: Qubit, b: Qubit, c: Qubit): () {
        body {
            (Controlled X)([a; b], c);
        }

        // controlled auto;
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

    operation Subtractor(t1: Qubit, t2: Qubit, borrowIn: Qubit, borrowOut: Qubit): () {
        body {
            Assert([PauliZ], [borrowOut], Zero, "Carry out is not in |0> state");

            X(t1);
            Toffoli(t1, t2, borrowOut);
            Toffoli(t1, borrowIn, borrowOut);
            Toffoli(t2, borrowIn, borrowOut);
            X(t1);
            let m4 = M(borrowOut);
            Message($"bO: {m4}");

            ApplyToEach(CNOT(_, t1), [t2; borrowIn]);
        }
    }
    operation TestSubtracter(): () {
        body {
            let rPow = 2;
            let rInt = 2 ^ rPow;

            using(qubits = Qubit[22]) {
                let binaries = GenerateAllBinariesOfLength(7);
                for (i in 0..Length(binaries)-1) {
                    Message($"start: {i}:");
                    let binary = binaries[i];
                    let r = qubits[0..6];
                    let register = qubits[7..13];
                    let carries = qubits[14..21];
                    SetQubits(register, binary);
                    X(r[BitSize(rInt) + 1]);


                    if (QubitsToInt(register) >= rInt) {
                        for (j in Length(binary)-1..-1..0) {
                            let m1 = M(register[j]);
                            let m2 = M(r[j]);
                            let m3 = M(carries[j]);
                            Message($"reg: {m1}, r: {m2}, bI: {m3}");
                            Subtractor(register[j], r[j], carries[j+1], carries[j]);
                        }

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

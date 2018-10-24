namespace HW3p1
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Primitive;
    open Utils;

    operation _SubtractBit(t1: Qubit, t2: Qubit, borrowIn: Qubit, borrowOut: Qubit): () {
        body {
            Assert([PauliZ], [borrowOut], Zero, "Borrow out is not in |0> state");

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
                        _SubtractBit(start[j], amount[j - Length(start) + Length(amount)], borrows[j+1], borrows[j]);
                    } else {
                        _SubtractBit(start[j], padding[0], borrows[j+1], borrows[j]);
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
            let binaries = GenerateAllBinariesOfLength(length);
            let rInt = 2 ^ rPow;
            let rLength = BitSize(rInt);
            let rLastIndex = rLength - 1;
            let regLastIndex = rLastIndex + length;
            let borrowsLastIndex = regLastIndex + length + 1;

            using(qubits = Qubit[borrowsLastIndex + 1]) {
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

    operation XIfLessThanOrEqual(a: Qubit[], b: Qubit[], target: Qubit): () {
        body {
            using(qubits = Qubit[Length(a) + 2]) {
                let borrows = Most(qubits);
                let zeroTest = Tail(qubits);
                Subtractor(a, b, borrows);

                ApplyToEachCA(X, a);
                (Controlled X)(a, zeroTest);
                ApplyToEachCA(X, a);

                let indicator = Head(borrows);
                QubitOr(indicator, zeroTest, target);

                ApplyToEachCA(X, a);
                (Controlled X)(a, zeroTest);
                ApplyToEachCA(X, a);

                (Adjoint Subtractor)(a, b, borrows);
            }
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation TestXIfLessThanOrEqual(length: Int): () {
        body {
            let binaries = GenerateAllBinariesOfLength(length);

            using (qubits = Qubit[length * 2 + 1]) {
                for (i in 0..Length(binaries) - 1) {
                    for (j in 0..Length(binaries) - 1) {
                        let binaryA = binaries[i];
                        let binaryB = binaries[j];
                        let a = qubits[0..length-1];
                        let b = qubits[length..length * 2 - 1];
                        let target = Tail(qubits);
                        
                        SetQubits(a, binaryA);
                        SetQubits(b, binaryB);

                        XIfLessThanOrEqual(a, b, target);

                        let mt = M(target);
                        let isLessThanOrEqual = i <= j;
                        Message($"{i} <= {j}: {isLessThanOrEqual}; result: {mt}");
                        AssertResultEqual(M(target), ResultFromBool(isLessThanOrEqual), "Incorrect");

                        ResetAll(qubits);
                    }
                }
            }
        }
    }

    operation SubtractIfPossible(a: Qubit[], b: Qubit[], borrows: Qubit[], toggle: Qubit): () {
        body {
            Subtractor(a, b, borrows);

            let indicator = Head(borrows);
            CNOT(indicator, toggle);

            (Controlled (Adjoint Subtractor))([toggle], (a, b, borrows));
        }

        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation PeriodicFunction(x: Qubit[], period: Qubit[], target: Qubit, maxDivisions: Int): () {
        body {
            let numBorrows = (Length(x) + 2);
            let lastIndex = numBorrows * maxDivisions - 1;
            using(qubits = Qubit[lastIndex + 1]) {
                for (i in 0..maxDivisions - 1) {
                    // Message($"{i * numBorrows} - {(i + 1) * numBorrows - 1}");
                    let theseQubits = qubits[i * numBorrows..(i + 1) * numBorrows - 1];
                    let borrows = Most(theseQubits);
                    let toggle = Tail(theseQubits);

                    SubtractIfPossible(x, period, borrows, toggle);

                    if (i == maxDivisions - 1) {
                        ApplyToEach(X, x);
                        (Controlled X)(x, target);
                        ApplyToEach(X, x);
                    }
                }

                for (i in 0..maxDivisions - 1) {
                    // Message($"{lastIndex - (i + 1) * numBorrows + 1} - {lastIndex - i * numBorrows}");
                    let theseQubits = qubits[lastIndex - (i + 1) * numBorrows + 1..lastIndex - i * numBorrows];
                    let borrows = Most(theseQubits);
                    let toggle = Tail(theseQubits);

                    (Adjoint SubtractIfPossible)(x, period, borrows, toggle);
                }

                PrintRegister(qubits);
            }
        }
    }

    operation _TestPeriodicFunctionImpl(a: Qubit[], b: Qubit[]): () {
        body {
            let aVal = QubitsToInt(a);
            let bVal = QubitsToInt(b);
            if (aVal > 0 && bVal > 0 && aVal >= bVal) {
                let maxDivisions = aVal / bVal;

                using(qubits = Qubit[1]) {
                    let target = qubits[0];
                    PeriodicFunction(a, b, target, maxDivisions);

                    let result = M(target);
                    let divides = aVal % bVal == 0;
                    let resultFromBool = ResultFromBool(divides);
                    Message($"{bVal} | {aVal}: {divides}({resultFromBool}); result: {result}");
                    AssertResultEqual(result, resultFromBool, "Incorrect");

                    Reset(target);
                }
            }
        }
    }

    operation TestPeriodicFunction(length: Int): () {
        body {
            RunOnAllTwoBinariesOfLength(length, _TestPeriodicFunctionImpl);
        }
    }

    operation VerifyProblem5 (t: Int, r: Int) : ()
    {
        body
        {
            mutable attempts = 0;
            mutable success = 0;
            using(qubits = Qubit[t + 4]) {
                for (i in 0..10) {
                    Message($"{i}");
                    let rReg = qubits[t..t + 2];
                    X(Head(rReg));
                    let firstReg = qubits[0..t-1];
                    let secondReg = Tail(qubits);

                    ApplyToEach(H, firstReg);
                    Message($"Periodic");
                    PeriodicFunction(firstReg, rReg, secondReg, 4);
                    Message($"Inverse QFT");
                    (Adjoint QFT)(BigEndian(firstReg));
                    Message($"Measure");
                    let l = MeasureIntegerBE(BigEndian(firstReg));
                    Message($"Continued Fractions");
                    let (s, foundR) = ContinuedFractionConvergent(Fraction(l, 2 ^ t), 10);
                    
                    let thisSuccess = foundR == r;
                    set attempts = attempts + 1;
                    if (thisSuccess) {
                        set success = success + 1;
                    }
                    Message(ToStringI(foundR));
                    ResetAll(qubits);
                }
            }
            Message($"Success Rate: {success * 1.0 / attempts}");
        }
    }
}

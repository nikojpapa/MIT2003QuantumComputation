namespace HW5p2 {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;

    operation MinorityVote(code: Qubit[], bitPairity1: Result, bitPairity2: Result): () {
        body {
            if (bitPairity1 == One && bitPairity2 == One) {
                ApplyPauli([PauliX; PauliI; PauliX], code);
            } elif (bitPairity1 == One) {
                ApplyPauli([PauliI; PauliX; PauliX], code);
            } elif (bitPairity2 == One) {
                ApplyPauli([PauliX; PauliX; PauliI], code);
            }
        }
    }

    operation P2Solution(code: Qubit[]) : () {
        body {
            let bitPairity1 = Measure([PauliZ; PauliZ; PauliI], code);
            let bitPairity2 = Measure([PauliI; PauliZ; PauliZ], code);

            MinorityVote(code, bitPairity1, bitPairity2);

            ApplyToEach(H, code);

            let pairity1 = Measure([PauliZ; PauliZ; PauliI], code);
            let pairity2 = Measure([PauliI; PauliZ; PauliZ], code);

            ApplyToEach(H, code);

            MinorityVote(code, bitPairity1, bitPairity2);            

            if (pairity1 == One && pairity2 == One) {
                Z(code[1]);
            } elif (pairity1 == One) {
                Z(code[0]);
            } elif (pairity2 == One) {
                Z(code[2]);
            }
        }
    }

    function GenerateCoefficientSame(word: Double): ComplexPolar {
        return ComplexToComplexPolar(Complex(word, 0.0));
    }

    function GenerateCoefficientOpp(word: Double): ComplexPolar {
        return ComplexToComplexPolar(Complex(1.0 - word, 0.0));
    }

    operation EncodePhaseFlipCode(word: Double, register: Qubit[]): () {  // word is either 0.0 or 1.0 corresponding to word |0> or |1>
        body {
            PrepareArbitraryState(
                [
                    GenerateCoefficientOpp(word);
                    GenerateCoefficientSame(word);
                    GenerateCoefficientSame(word);
                    GenerateCoefficientOpp(word);
                    GenerateCoefficientSame(word);
                    GenerateCoefficientOpp(word);
                    GenerateCoefficientOpp(word);
                    GenerateCoefficientSame(word)
                ],
                BigEndian(register)
            );
        }

        adjoint auto;
    }

    operation TestP2Solution (word: Int, errorize: (Qubit[] => ())) : ()
    {
        body
        {
            let wordD = ToDouble(word);

            using (register = Qubit[3]) {
                EncodePhaseFlipCode(wordD, register);
                AssertProbIntBE(0, 1.0 / 4.0, BigEndian(register), 0.000000000000001);

                errorize(register);

                P2Solution(register);

                (Adjoint EncodePhaseFlipCode)(wordD, register);
                Assert([PauliZ], [register[0]], ResultFromBool(word == 1), $"Didn't return to {word}");
            }
        }
    }

    operation TestAllThreePhaseFlips(): () {
        body {
            let Z0 = ApplyPauli([PauliZ; PauliI; PauliI], _);
            let Z1 = ApplyPauli([PauliI; PauliZ; PauliI], _);
            let Z2 = ApplyPauli([PauliI; PauliI; PauliZ], _);

            for (i in 0..1) {
                TestP2Solution(i, Z0);
                TestP2Solution(i, Z1);
                TestP2Solution(i, Z2);
            }
        }
    }
}
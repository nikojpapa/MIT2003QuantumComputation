namespace HW3p2
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;

    operation Rn (n: Int, target: Qubit) : ()
    {
        body
        {
            for (k in 0..n-1) {
                RFrac(PauliI, k, n, target);
            }
        }
    }

    operation EntryPoint(): () {
        body{
            // mutable binaryOperandA = new Int[3];
            // for (i in 0..2) {
            //     set binaryOperandA[i] = 0;
            // }
            let operandA = 0;
            let operandB = 0;

            let result = PerformAddition(operandA, operandB);
            mutable display = "";
            for (i in 0..Length(result) - 1) {
                set display = display + ToStringI(result[i]);
            }
            Message(display);

        }
    }

    operation PerformAddition(operandA: Int, operandB: Int): Int[] {
        body {
            let numStates = operandA + 1;
            mutable initialStateCoefficients = new ComplexPolar[numStates];
            set initialStateCoefficients[0] = ComplexPolar(1.0, 0.0);
            for (i in 1..Length(initialStateCoefficients)-1) {
                set initialStateCoefficients[i] = ComplexPolar(0.0, 0.0);
            }
            Message($"{initialStateCoefficients}");

            mutable resultBinary = new Int[numStates];

            using (qubits = Qubit[numStates]) {
                let bigEndian = BigEndian(qubits);
                PrepareArbitraryState(initialStateCoefficients, bigEndian);
                QFT(bigEndian);
                for (i in 0..operandB) {
                    Rn(numStates, bigEndian[i]);
                }
                (Adjoint QFT)(bigEndian);

                for (i in 0..numStates-1) {
                    mutable intResult = 0;
                    let result = M(bigEndian[i]);
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
    }
}

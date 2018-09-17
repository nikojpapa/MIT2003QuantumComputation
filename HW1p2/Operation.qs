namespace HW1p2
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Testing;

    newtype PauliJ = (Complex, Complex, Complex);
    operation AssertJ(pauliJ: PauliJ): () {
        body {
            let (jx, jy, jz) = pauliJ;
            let jx2 = AbsSquaredComplex(jx);
            let jy2 = AbsSquaredComplex(jy);
            let jz2 = AbsSquaredComplex(jz);
            AssertAlmostEqual(jx2 + jy2 + jz2, 1.0);
        }
    }

    newtype StateAmps = (Complex, Complex);
    operation AssertStateAmps(stateAmps: StateAmps): () {
        body {
            let (alpha, beta) = stateAmps;
            let a2 = AbsSquaredComplex(alpha);
            let b2 = AbsSquaredComplex(beta);
            let magnitude = a2 + b2;

            // let validState = magnitude == 1.0;
            AssertAlmostEqual(magnitude, 1.0);
            // Message($"{1.0 == 1.0}");
            // Message($"{magnitude == magnitude}");
            // Message($"{magnitude == 1}");
            // if (!validState) {
            //     Message($"a: {alpha}");
            //     Message($"b: {beta}");
            //     Message($"a2: {a2}");
            //     Message($"b2: {b2}");
            //     Message($"mag: {magnitude}");
            //     fail $"Invalid state";
            // }
        }
    }

    function AddComplex(complex1: Complex, complex2: Complex): Complex {
        let (real1, imaginary1) = complex1;
        let (real2, imaginary2) = complex2;
        return Complex(real1 + real2, imaginary1 + imaginary2);
    }

    function ComplexEquivalence(complex1: Complex, complex2: Complex): Bool {
        let (real1, imaginary1) = complex1;
        let (real2, imaginary2) = complex2;
        return real1 == real2 && imaginary1 == imaginary2;
    }

    function MultiplyComplex(complex1: Complex, complex2: Complex): Complex {
        let (real1, imaginary1) = complex1;
        let (real2, imaginary2) = complex2;
        return Complex(real1 * real2 - imaginary1 * imaginary2, real1 * imaginary2 + real2 * imaginary1);
    }

    operation NextDouble(): Double {
        body {
            return ToDouble(RandomInt(100000)) / 100000.0;
        }
    }

    operation SquareComplex(complex1: Complex): Complex {
        body {
            // return Complex(AbsSquaredComplex(complex1), 0.0);
            let (real, imaginary) = complex1;
            return Complex(PowD(real, 2.0) - PowD(imaginary, 2.0), 2.0 * real * imaginary);
        } 
    }

    function SubtractComplex(complex1: Complex, complex2: Complex): Complex {
        let (real1, imaginary1) = complex1;
        let (real2, imaginary2) = complex2;
        return Complex(real1 - real2, imaginary1 - imaginary2);
    }

    operation PerformPauliJ (pauliJ: PauliJ, stateAmps: StateAmps) : BigEndian
    {
        body
        {
            AssertJ(pauliJ);
            AssertStateAmps(stateAmps);

            let (jx, jy, jz) = pauliJ;
            let (oldAlpha, oldBeta) = stateAmps;
            // let (realOldA, imaginaryOldA) = oldAlpha;
            // let (realOldB, imaginaryOldB) = oldBeta;
            let (realJy, imaginaryJy) = jy;

            let betaJx = MultiplyComplex(oldBeta, jx);
            let iJy = Complex(-imaginaryJy, realJy);
            let iJyBeta = MultiplyComplex(oldBeta, iJy);
            let jzAlpha = MultiplyComplex(oldAlpha, jz);
            let betaJxMinusIJyBeta = SubtractComplex(betaJx, iJyBeta);
            let newAlpha = AddComplex(betaJxMinusIJyBeta, jzAlpha);
            Message($"{newAlpha}");

            let alphaJx = MultiplyComplex(oldAlpha, jx);
            let iJyAlpha = MultiplyComplex(oldAlpha, iJy);
            let jzBeta = MultiplyComplex(oldBeta, jz);
            let alphaJxPlusIJyAlpha = AddComplex(alphaJx, iJyAlpha);
            let newBeta = SubtractComplex(alphaJxPlusIJyAlpha, jzBeta);
            Message($"{newBeta}");

            let oldBetaSquared = SquareComplex(oldBeta);
            let oldAlphaSquared = SquareComplex(oldAlpha);
            let jx2 = SquareComplex(jx);
            let jy2 = SquareComplex(jy);
            let jz2 = SquareComplex(jz);
            let jx2Plusjy2 = AddComplex(jx2, jy2);
            let alphaBeta = MultiplyComplex(oldAlpha, oldBeta);
            let jxJz = MultiplyComplex(jx, jz);
            let alphaBetaJxJz = MultiplyComplex(alphaBeta, jxJz);
            let twoAlphaBetaJxJz = MultiplyComplex(alphaBetaJxJz, Complex(2.0, 0.0));
            let jz2Alpha2 = MultiplyComplex(jz2, oldAlphaSquared);
            let beta2TimesJx2PlusJy2 = MultiplyComplex(oldBetaSquared, jx2Plusjy2);
            let expectedAlpha = AddComplex(AddComplex(beta2TimesJx2PlusJy2, twoAlphaBetaJxJz), jz2Alpha2);
            Message($"{expectedAlpha}");

            let expectedBeta = Complex(1.0 - AbsComplex(expectedAlpha), 0.0);
            // let jx2MinusJy2 = SubtractComplex(jx2, jy2);
            // let jz2Beta2 = MultiplyComplex(jz2, oldBetaSquared);
            // let alpha2Timesjx2Minusjy2 = MultiplyComplex(oldAlphaSquared, jx2MinusJy2);
            // let expectedBeta = AddComplex(SubtractComplex(alpha2Timesjx2Minusjy2, twoAlphaBetaJxJz), jz2Beta2);
            Message($"{expectedBeta}");

            mutable newCoefficients = new ComplexPolar[2];
            set newCoefficients[0] = ComplexToComplexPolar(newAlpha);
            set newCoefficients[1] = ComplexToComplexPolar(newBeta);

            mutable result = BigEndian(new Qubit[1]);
            using(qubits = Qubit[1]) {

                mutable transformed = BigEndian(qubits);
                PrepareArbitraryState(newCoefficients, transformed);

                // AssertProbIntBE(0, AbsComplex(expectedAlpha), transformed, 0.00001);
                // AssertProbIntBE(1, AbsComplex(expectedBeta), transformed, 0.00001);

                AssertProbIntBE(1, 1.0, transformed, 0.00001);
                Message("+ eigenvalue is correct");

                set result = transformed;

                ResetAll(qubits);
            }

            return result;
        }
    }

    operation TestPauliJ (): () {
        body {
            let sqrtHalf = Sqrt(1.0 / 2.0);
            let sqrtThird = Sqrt(1.0 / 3.0);
            
            // let jx = Complex(sqrtThird, 0.0);
            // let jy = Complex(sqrtThird, 0.0);
            // let jz = Complex(sqrtThird, 0.0);
            let jxReal = NextDouble();
            let jyReal = Sqrt(NextDouble() * (1.0 - PowD(jxReal, 2.0)));
            let jzReal = Sqrt(1.0 - PowD(jxReal, 2.0) - PowD(jyReal, 2.0));
            let jx = Complex(jxReal, 0.0);
            let jy = Complex(jyReal, 0.0);
            let jz = Complex(jzReal, 0.0);
            AssertJ(PauliJ(jx, jy, jz));

            let alphaD = sqrtHalf;
            let betaD = sqrtHalf;
            // let alphaD = NextDouble();
            // let betaD = Sqrt(1.0 - PowD(alphaD, 2.0));
            let alpha = Complex(alphaD, 0.0);
            let beta = Complex(betaD, 0.0);

            let eigenPlusScalar = Sqrt((1.0 + jzReal) / 2.0);
            let eigenPlusAlpha = Complex(eigenPlusScalar, 0.0);
            let eigenPlusBeta = Complex(
                eigenPlusScalar * (jxReal * (1.0 - jzReal) / (PowD(jxReal, 2.0) + PowD(jyReal, 2.0))),
                eigenPlusScalar * (jyReal * (1.0 - jzReal) / (PowD(jxReal, 2.0) + PowD(jyReal, 2.0)))
            );

            let transformed = PerformPauliJ(PauliJ(jx, jy, jz), StateAmps(eigenPlusAlpha, eigenPlusBeta));

            // AssertProbIntBE(1, 1.0, transformed, 0.00001);
            // Message("+ eigenvalue is correct");
        }
    }
}

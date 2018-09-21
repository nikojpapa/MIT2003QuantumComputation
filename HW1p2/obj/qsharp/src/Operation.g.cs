#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("HW1p2", "PauliJ", "(Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Extensions.Math.Complex)", "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 241L, 9L, 5L)]
[assembly: UdtDeclaration("HW1p2", "StateAmps", "(Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Extensions.Math.Complex)", "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 605L, 20L, 5L)]
[assembly: OperationDeclaration("HW1p2", "AssertJ (pauliJ : HW1p2.PauliJ) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 330L, 10L, 43L)]
[assembly: OperationDeclaration("HW1p2", "AssertStateAmps (stateAmps : HW1p2.StateAmps) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 702L, 21L, 57L)]
[assembly: OperationDeclaration("HW1p2", "NextDouble () : Double", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 2274L, 62L, 36L)]
[assembly: OperationDeclaration("HW1p2", "SquareComplex (complex1 : Microsoft.Quantum.Extensions.Math.Complex) : Microsoft.Quantum.Extensions.Math.Complex", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 2429L, 68L, 57L)]
[assembly: OperationDeclaration("HW1p2", "PerformPauliJ (pauliJ : HW1p2.PauliJ, stateAmps : HW1p2.StateAmps) : Microsoft.Quantum.Canon.BigEndian", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 3002L, 83L, 5L)]
[assembly: OperationDeclaration("HW1p2", "TestPauliJ () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 6350L, 157L, 33L)]
[assembly: FunctionDeclaration("HW1p2", "AddComplex (complex1 : Microsoft.Quantum.Extensions.Math.Complex, complex2 : Microsoft.Quantum.Extensions.Math.Complex) : Microsoft.Quantum.Extensions.Math.Complex", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 1491L, 44L, 14L)]
[assembly: FunctionDeclaration("HW1p2", "ComplexEquivalence (complex1 : Microsoft.Quantum.Extensions.Math.Complex, complex2 : Microsoft.Quantum.Extensions.Math.Complex) : Bool", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 1729L, 50L, 14L)]
[assembly: FunctionDeclaration("HW1p2", "MultiplyComplex (complex1 : Microsoft.Quantum.Extensions.Math.Complex, complex2 : Microsoft.Quantum.Extensions.Math.Complex) : Microsoft.Quantum.Extensions.Math.Complex", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 1967L, 56L, 14L)]
[assembly: FunctionDeclaration("HW1p2", "SubtractComplex (complex1 : Microsoft.Quantum.Extensions.Math.Complex, complex2 : Microsoft.Quantum.Extensions.Math.Complex) : Microsoft.Quantum.Extensions.Math.Complex", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs", 2688L, 76L, 14L)]
#line hidden
namespace HW1p2
{
    public class PauliJ : QTuple<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)>, IApplyData
    {
        public PauliJ() : base(default((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)))
        {
        }

        public PauliJ((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) : base(data)
        {
        }

        public PauliJ(QTuple<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)> b) : base(b.Data)
        {
        }

        public Microsoft.Quantum.Extensions.Math.Complex Item1 => Data.Item1;
        public Microsoft.Quantum.Extensions.Math.Complex Item2 => Data.Item2;
        public Microsoft.Quantum.Extensions.Math.Complex Item3 => Data.Item3;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Microsoft.Quantum.Extensions.Math.Complex item1, out Microsoft.Quantum.Extensions.Math.Complex item2, out Microsoft.Quantum.Extensions.Math.Complex item3)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
            item3 = Data.Item3;
        }
    }

    public class AssertJ : Operation<PauliJ, QVoid>, ICallable
    {
        public AssertJ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AssertJ";
        String ICallable.FullName => "HW1p2.AssertJ";
        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double> MicrosoftQuantumCanonAbsSquaredComplex
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), QVoid> MicrosoftQuantumCanonAssertAlmostEqual
        {
            get;
            set;
        }

        public override Func<PauliJ, QVoid> Body => (__in) =>
        {
            var pauliJ = __in;
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (jx,jy,jz) = pauliJ;
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jx2 = MicrosoftQuantumCanonAbsSquaredComplex.Apply(jx);
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jy2 = MicrosoftQuantumCanonAbsSquaredComplex.Apply(jy);
#line 15 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jz2 = MicrosoftQuantumCanonAbsSquaredComplex.Apply(jz);
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            MicrosoftQuantumCanonAssertAlmostEqual.Apply((((jx2 + jy2) + jz2), 1D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAbsSquaredComplex = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double>>(typeof(Microsoft.Quantum.Canon.AbsSquaredComplex));
            this.MicrosoftQuantumCanonAssertAlmostEqual = this.Factory.Get<ICallable<(Double,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertAlmostEqual));
        }

        public override IApplyData __dataIn(PauliJ data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, PauliJ pauliJ)
        {
            return __m__.Run<AssertJ, PauliJ, QVoid>(pauliJ);
        }
    }

    public class StateAmps : QTuple<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)>, IApplyData
    {
        public StateAmps() : base(default((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)))
        {
        }

        public StateAmps((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) : base(data)
        {
        }

        public StateAmps(QTuple<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)> b) : base(b.Data)
        {
        }

        public Microsoft.Quantum.Extensions.Math.Complex Item1 => Data.Item1;
        public Microsoft.Quantum.Extensions.Math.Complex Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Microsoft.Quantum.Extensions.Math.Complex item1, out Microsoft.Quantum.Extensions.Math.Complex item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public class AssertStateAmps : Operation<StateAmps, QVoid>, ICallable
    {
        public AssertStateAmps(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AssertStateAmps";
        String ICallable.FullName => "HW1p2.AssertStateAmps";
        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double> MicrosoftQuantumCanonAbsSquaredComplex
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), QVoid> MicrosoftQuantumCanonAssertAlmostEqual
        {
            get;
            set;
        }

        public override Func<StateAmps, QVoid> Body => (__in) =>
        {
            var stateAmps = __in;
#line 23 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (alpha,beta) = stateAmps;
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var a2 = MicrosoftQuantumCanonAbsSquaredComplex.Apply(alpha);
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var b2 = MicrosoftQuantumCanonAbsSquaredComplex.Apply(beta);
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var magnitude = (a2 + b2);
            // let validState = magnitude == 1.0;
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            MicrosoftQuantumCanonAssertAlmostEqual.Apply((magnitude, 1D));
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
            ;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAbsSquaredComplex = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double>>(typeof(Microsoft.Quantum.Canon.AbsSquaredComplex));
            this.MicrosoftQuantumCanonAssertAlmostEqual = this.Factory.Get<ICallable<(Double,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertAlmostEqual));
        }

        public override IApplyData __dataIn(StateAmps data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, StateAmps stateAmps)
        {
            return __m__.Run<AssertStateAmps, StateAmps, QVoid>(stateAmps);
        }
    }

    public class AddComplex : Operation<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>, ICallable
    {
        public AddComplex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)>, IApplyData
        {
            public In((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AddComplex";
        String ICallable.FullName => "HW1p2.AddComplex";
        public override Func<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex> Body => (__in) =>
        {
            var (complex1,complex2) = __in;
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real1,imaginary1) = complex1;
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real2,imaginary2) = complex2;
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            return new Microsoft.Quantum.Extensions.Math.Complex(((real1 + real2), (imaginary1 + imaginary2)));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) => new In(data);
        public override IApplyData __dataOut(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Extensions.Math.Complex> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex complex1, Microsoft.Quantum.Extensions.Math.Complex complex2)
        {
            return __m__.Run<AddComplex, (Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>((complex1, complex2));
        }
    }

    public class ComplexEquivalence : Operation<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Boolean>, ICallable
    {
        public ComplexEquivalence(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)>, IApplyData
        {
            public In((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ComplexEquivalence";
        String ICallable.FullName => "HW1p2.ComplexEquivalence";
        public override Func<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Boolean> Body => (__in) =>
        {
            var (complex1,complex2) = __in;
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real1,imaginary1) = complex1;
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real2,imaginary2) = complex2;
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            return ((real1 == real2) && (imaginary1 == imaginary2));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex complex1, Microsoft.Quantum.Extensions.Math.Complex complex2)
        {
            return __m__.Run<ComplexEquivalence, (Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Boolean>((complex1, complex2));
        }
    }

    public class MultiplyComplex : Operation<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>, ICallable
    {
        public MultiplyComplex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)>, IApplyData
        {
            public In((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MultiplyComplex";
        String ICallable.FullName => "HW1p2.MultiplyComplex";
        public override Func<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex> Body => (__in) =>
        {
            var (complex1,complex2) = __in;
#line 57 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real1,imaginary1) = complex1;
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real2,imaginary2) = complex2;
#line 59 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            return new Microsoft.Quantum.Extensions.Math.Complex((((real1 * real2) - (imaginary1 * imaginary2)), ((real1 * imaginary2) + (real2 * imaginary1))));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) => new In(data);
        public override IApplyData __dataOut(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Extensions.Math.Complex> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex complex1, Microsoft.Quantum.Extensions.Math.Complex complex2)
        {
            return __m__.Run<MultiplyComplex, (Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>((complex1, complex2));
        }
    }

    public class NextDouble : Operation<QVoid, Double>, ICallable
    {
        public NextDouble(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "NextDouble";
        String ICallable.FullName => "HW1p2.NextDouble";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonRandomInt
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<QVoid, Double> Body => (__in) =>
        {
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            return (MicrosoftQuantumExtensionsConvertToDouble.Apply(MicrosoftQuantumCanonRandomInt.Apply(100000L)) / 100000D);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomInt));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__)
        {
            return __m__.Run<NextDouble, QVoid, Double>(QVoid.Instance);
        }
    }

    public class SquareComplex : Operation<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Extensions.Math.Complex>, ICallable
    {
        public SquareComplex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SquareComplex";
        String ICallable.FullName => "HW1p2.SquareComplex";
        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Extensions.Math.Complex> Body => (__in) =>
        {
            var complex1 = __in;
            // return Complex(AbsSquaredComplex(complex1), 0.0);
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real,imaginary) = complex1;
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            return new Microsoft.Quantum.Extensions.Math.Complex(((MicrosoftQuantumExtensionsMathPowD.Apply((real, 2D)) - MicrosoftQuantumExtensionsMathPowD.Apply((imaginary, 2D))), ((2D * real) * imaginary)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public override IApplyData __dataOut(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Extensions.Math.Complex> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex complex1)
        {
            return __m__.Run<SquareComplex, Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Extensions.Math.Complex>(complex1);
        }
    }

    public class SubtractComplex : Operation<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>, ICallable
    {
        public SubtractComplex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex)>, IApplyData
        {
            public In((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SubtractComplex";
        String ICallable.FullName => "HW1p2.SubtractComplex";
        public override Func<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex> Body => (__in) =>
        {
            var (complex1,complex2) = __in;
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real1,imaginary1) = complex1;
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (real2,imaginary2) = complex2;
#line 79 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            return new Microsoft.Quantum.Extensions.Math.Complex(((real1 - real2), (imaginary1 - imaginary2)));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex) data) => new In(data);
        public override IApplyData __dataOut(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Extensions.Math.Complex> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex complex1, Microsoft.Quantum.Extensions.Math.Complex complex2)
        {
            return __m__.Run<SubtractComplex, (Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>((complex1, complex2));
        }
    }

    public class PerformPauliJ : Operation<(PauliJ,StateAmps), Microsoft.Quantum.Canon.BigEndian>, ICallable
    {
        public PerformPauliJ(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(PauliJ,StateAmps)>, IApplyData
        {
            public In((PauliJ,StateAmps) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PerformPauliJ";
        String ICallable.FullName => "HW1p2.PerformPauliJ";
        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double> MicrosoftQuantumCanonAbsComplex
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex> AddComplex
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<PauliJ, QVoid> AssertJ
        {
            get;
            set;
        }

        protected ICallable<(Int64,Double,Microsoft.Quantum.Canon.BigEndian,Double), QVoid> MicrosoftQuantumCanonAssertProbIntBE
        {
            get;
            set;
        }

        protected ICallable<StateAmps, QVoid> AssertStateAmps
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Canon.ComplexPolar> MicrosoftQuantumCanonComplexToComplexPolar
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex> MultiplyComplex
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonPrepareArbitraryState
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Extensions.Math.Complex> SquareComplex
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex> SubtractComplex
        {
            get;
            set;
        }

        public override Func<(PauliJ,StateAmps), Microsoft.Quantum.Canon.BigEndian> Body => (__in) =>
        {
            var (pauliJ,stateAmps) = __in;
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            AssertJ.Apply(pauliJ);
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            AssertStateAmps.Apply(stateAmps);
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (jx,jy,jz) = pauliJ;
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (oldAlpha,oldBeta) = stateAmps;
            // let (realOldA, imaginaryOldA) = oldAlpha;
            // let (realOldB, imaginaryOldB) = oldBeta;
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var (realJy,imaginaryJy) = jy;
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var betaJx = MultiplyComplex.Apply((oldBeta, jx));
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var iJy = new Microsoft.Quantum.Extensions.Math.Complex((-(imaginaryJy), realJy));
#line 97 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var iJyBeta = MultiplyComplex.Apply((oldBeta, iJy));
#line 98 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jzAlpha = MultiplyComplex.Apply((oldAlpha, jz));
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var betaJxMinusIJyBeta = SubtractComplex.Apply((betaJx, iJyBeta));
#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var newAlpha = AddComplex.Apply((betaJxMinusIJyBeta, jzAlpha));
#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            Message.Apply($"{newAlpha}");
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var alphaJx = MultiplyComplex.Apply((oldAlpha, jx));
#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var iJyAlpha = MultiplyComplex.Apply((oldAlpha, iJy));
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jzBeta = MultiplyComplex.Apply((oldBeta, jz));
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var alphaJxPlusIJyAlpha = AddComplex.Apply((alphaJx, iJyAlpha));
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var newBeta = SubtractComplex.Apply((alphaJxPlusIJyAlpha, jzBeta));
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            Message.Apply($"{newBeta}");
#line 110 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var oldBetaSquared = SquareComplex.Apply(oldBeta);
#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var oldAlphaSquared = SquareComplex.Apply(oldAlpha);
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jx2 = SquareComplex.Apply(jx);
#line 113 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jy2 = SquareComplex.Apply(jy);
#line 114 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jz2 = SquareComplex.Apply(jz);
#line 115 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jx2Plusjy2 = AddComplex.Apply((jx2, jy2));
#line 116 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var alphaBeta = MultiplyComplex.Apply((oldAlpha, oldBeta));
#line 117 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jxJz = MultiplyComplex.Apply((jx, jz));
#line 118 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var alphaBetaJxJz = MultiplyComplex.Apply((alphaBeta, jxJz));
#line 119 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var twoAlphaBetaJxJz = MultiplyComplex.Apply((alphaBetaJxJz, new Microsoft.Quantum.Extensions.Math.Complex((2D, 0D))));
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jz2Alpha2 = MultiplyComplex.Apply((jz2, oldAlphaSquared));
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var beta2TimesJx2PlusJy2 = MultiplyComplex.Apply((oldBetaSquared, jx2Plusjy2));
#line 122 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var expectedAlpha = AddComplex.Apply((AddComplex.Apply((beta2TimesJx2PlusJy2, twoAlphaBetaJxJz)), jz2Alpha2));
#line 123 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            Message.Apply($"{expectedAlpha}");
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var expectedBeta = new Microsoft.Quantum.Extensions.Math.Complex(((1D - MicrosoftQuantumCanonAbsComplex.Apply(expectedAlpha)), 0D));
            // let jx2MinusJy2 = SubtractComplex(jx2, jy2);
            // let jz2Beta2 = MultiplyComplex(jz2, oldBetaSquared);
            // let alpha2Timesjx2Minusjy2 = MultiplyComplex(oldAlphaSquared, jx2MinusJy2);
            // let expectedBeta = AddComplex(SubtractComplex(alpha2Timesjx2Minusjy2, twoAlphaBetaJxJz), jz2Beta2);
#line 130 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            Message.Apply($"{expectedBeta}");
#line 132 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var newCoefficients = new QArray<Microsoft.Quantum.Canon.ComplexPolar>(2L);
#line 133 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            newCoefficients[0L] = MicrosoftQuantumCanonComplexToComplexPolar.Apply(newAlpha);
#line 134 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            newCoefficients[1L] = MicrosoftQuantumCanonComplexToComplexPolar.Apply(newBeta);
#line 136 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var result = new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>(1L));
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var qubits = Allocate.Apply(1L);
#line 139 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var transformed = new Microsoft.Quantum.Canon.BigEndian(qubits);
#line 140 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            MicrosoftQuantumCanonPrepareArbitraryState.Apply((newCoefficients, transformed));
#line 142 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            MicrosoftQuantumCanonAssertProbIntBE.Apply((0L, MicrosoftQuantumCanonAbsComplex.Apply(expectedAlpha), transformed, 1E-05D));
#line 143 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            MicrosoftQuantumCanonAssertProbIntBE.Apply((1L, MicrosoftQuantumCanonAbsComplex.Apply(expectedBeta), transformed, 1E-05D));
            // AssertProbIntBE(1, 1.0, transformed, 0.00001);
            // Message("+ eigenvalue is correct");
#line 148 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            result = transformed;
#line 150 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 153 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAbsComplex = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double>>(typeof(Microsoft.Quantum.Canon.AbsComplex));
            this.AddComplex = this.Factory.Get<ICallable<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>>(typeof(HW1p2.AddComplex));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertJ = this.Factory.Get<ICallable<PauliJ, QVoid>>(typeof(HW1p2.AssertJ));
            this.MicrosoftQuantumCanonAssertProbIntBE = this.Factory.Get<ICallable<(Int64,Double,Microsoft.Quantum.Canon.BigEndian,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertProbIntBE));
            this.AssertStateAmps = this.Factory.Get<ICallable<StateAmps, QVoid>>(typeof(HW1p2.AssertStateAmps));
            this.MicrosoftQuantumCanonComplexToComplexPolar = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Canon.ComplexPolar>>(typeof(Microsoft.Quantum.Canon.ComplexToComplexPolar));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.MultiplyComplex = this.Factory.Get<ICallable<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>>(typeof(HW1p2.MultiplyComplex));
            this.MicrosoftQuantumCanonPrepareArbitraryState = this.Factory.Get<IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.PrepareArbitraryState));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.SquareComplex = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Extensions.Math.Complex>>(typeof(HW1p2.SquareComplex));
            this.SubtractComplex = this.Factory.Get<ICallable<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>>(typeof(HW1p2.SubtractComplex));
        }

        public override IApplyData __dataIn((PauliJ,StateAmps) data) => new In(data);
        public override IApplyData __dataOut(Microsoft.Quantum.Canon.BigEndian data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Canon.BigEndian> Run(IOperationFactory __m__, PauliJ pauliJ, StateAmps stateAmps)
        {
            return __m__.Run<PerformPauliJ, (PauliJ,StateAmps), Microsoft.Quantum.Canon.BigEndian>((pauliJ, stateAmps));
        }
    }

    public class TestPauliJ : Operation<QVoid, QVoid>, ICallable
    {
        public TestPauliJ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestPauliJ";
        String ICallable.FullName => "HW1p2.TestPauliJ";
        protected ICallable<PauliJ, QVoid> AssertJ
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex> MultiplyComplex
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> NextDouble
        {
            get;
            set;
        }

        protected ICallable<(PauliJ,StateAmps), Microsoft.Quantum.Canon.BigEndian> PerformPauliJ
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 159 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var sqrtHalf = MicrosoftQuantumExtensionsMathSqrt.Apply((1D / 2D));
#line 160 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var sqrtThird = MicrosoftQuantumExtensionsMathSqrt.Apply((1D / 3D));
            // let jx = Complex(sqrtThird, 0.0);
            // let jy = Complex(sqrtThird, 0.0);
            // let jz = Complex(sqrtThird, 0.0);
#line 165 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jxReal = NextDouble.Apply(QVoid.Instance);
#line 166 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jyReal = MicrosoftQuantumExtensionsMathSqrt.Apply((NextDouble.Apply(QVoid.Instance) * (1D - MicrosoftQuantumExtensionsMathPowD.Apply((jxReal, 2D)))));
#line 167 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jzReal = MicrosoftQuantumExtensionsMathSqrt.Apply(((1D - MicrosoftQuantumExtensionsMathPowD.Apply((jxReal, 2D))) - MicrosoftQuantumExtensionsMathPowD.Apply((jyReal, 2D))));
#line 168 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jx = new Microsoft.Quantum.Extensions.Math.Complex((jxReal, 0D));
#line 169 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jy = new Microsoft.Quantum.Extensions.Math.Complex((jyReal, 0D));
#line 170 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var jz = new Microsoft.Quantum.Extensions.Math.Complex((jzReal, 0D));
#line 171 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            AssertJ.Apply(new PauliJ((jx, jy, jz)));
#line 173 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var alphaD = sqrtHalf;
#line 174 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var betaD = sqrtHalf;
            // let alphaD = NextDouble();
            // let betaD = Sqrt(1.0 - PowD(alphaD, 2.0));
#line 177 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var alpha = new Microsoft.Quantum.Extensions.Math.Complex((alphaD, 0D));
#line 178 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var beta = new Microsoft.Quantum.Extensions.Math.Complex((betaD, 0D));
#line 180 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var eigenPlusScalar = MicrosoftQuantumExtensionsMathSqrt.Apply(((1D + jzReal) / 2D));
#line 181 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var eigenPlusAlpha = new Microsoft.Quantum.Extensions.Math.Complex((eigenPlusScalar, 0D));
#line 182 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var eigenPlusBeta = MultiplyComplex.Apply((eigenPlusAlpha, new Microsoft.Quantum.Extensions.Math.Complex((((jxReal * (1D - jzReal)) / (MicrosoftQuantumExtensionsMathPowD.Apply((jxReal, 2D)) + MicrosoftQuantumExtensionsMathPowD.Apply((jyReal, 2D)))), ((jyReal * (1D - jzReal)) / (MicrosoftQuantumExtensionsMathPowD.Apply((jxReal, 2D)) + MicrosoftQuantumExtensionsMathPowD.Apply((jyReal, 2D))))))));
#line 187 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW1p2/Operation.qs"
            var transformed = PerformPauliJ.Apply((new PauliJ((jx, jy, jz)), new StateAmps((eigenPlusAlpha, eigenPlusBeta))));
            // AssertProbIntBE(1, 1.0, transformed, 0.00001);
            // Message("+ eigenvalue is correct");
            ;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertJ = this.Factory.Get<ICallable<PauliJ, QVoid>>(typeof(HW1p2.AssertJ));
            this.MultiplyComplex = this.Factory.Get<ICallable<(Microsoft.Quantum.Extensions.Math.Complex,Microsoft.Quantum.Extensions.Math.Complex), Microsoft.Quantum.Extensions.Math.Complex>>(typeof(HW1p2.MultiplyComplex));
            this.NextDouble = this.Factory.Get<ICallable<QVoid, Double>>(typeof(HW1p2.NextDouble));
            this.PerformPauliJ = this.Factory.Get<ICallable<(PauliJ,StateAmps), Microsoft.Quantum.Canon.BigEndian>>(typeof(HW1p2.PerformPauliJ));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestPauliJ, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
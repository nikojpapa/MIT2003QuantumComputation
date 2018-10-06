#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW5p2", "P2Solution (code : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 227L, 7L, 46L)]
[assembly: OperationDeclaration("HW5p2", "EncodePhaseFlipCode (data : Qubit, auxillaryQubits : Qubit[]) : ()", new string[] { "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 1051L, 34L, 78L)]
[assembly: OperationDeclaration("HW5p2", "TestP2Solution (errorize : (Qubit[] => ())) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 1381L, 46L, 5L)]
[assembly: OperationDeclaration("HW5p2", "TestAllThreePhaseFlips () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 2073L, 70L, 44L)]
[assembly: FunctionDeclaration("HW5p2", "GenerateCoefficientSame (word : Double) : Microsoft.Quantum.Canon.ComplexPolar", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 718L, 26L, 14L)]
[assembly: FunctionDeclaration("HW5p2", "GenerateCoefficientOpp (word : Double) : Microsoft.Quantum.Canon.ComplexPolar", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 850L, 30L, 14L)]
#line hidden
namespace HW5p2
{
    public class P2Solution : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public P2Solution(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "P2Solution";
        String ICallable.FullName => "HW5p2.P2Solution";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var code = __in;
#line 9 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), code));
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var pairity1 = Measure.Apply((new QArray<Pauli>(Pauli.PauliX, Pauli.PauliX, Pauli.PauliI), code));
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var pairity2 = Measure.Apply((new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliX), code));
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), code));
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            if (((pairity1 == Result.One) && (pairity2 == Result.One)))
            {
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                MicrosoftQuantumPrimitiveZ.Apply(code[1L]);
            }
            else if ((pairity1 == Result.One))
            {
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                MicrosoftQuantumPrimitiveZ.Apply(code[0L]);
            }
            else if ((pairity2 == Result.One))
            {
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                MicrosoftQuantumPrimitiveZ.Apply(code[2L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> code)
        {
            return __m__.Run<P2Solution, QArray<Qubit>, QVoid>(code);
        }
    }

    public class GenerateCoefficientSame : Operation<Double, Microsoft.Quantum.Canon.ComplexPolar>, ICallable
    {
        public GenerateCoefficientSame(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateCoefficientSame";
        String ICallable.FullName => "HW5p2.GenerateCoefficientSame";
        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Canon.ComplexPolar> MicrosoftQuantumCanonComplexToComplexPolar
        {
            get;
            set;
        }

        public override Func<Double, Microsoft.Quantum.Canon.ComplexPolar> Body => (__in) =>
        {
            var word = __in;
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            return MicrosoftQuantumCanonComplexToComplexPolar.Apply(new Microsoft.Quantum.Extensions.Math.Complex((word, 0D)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonComplexToComplexPolar = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Canon.ComplexPolar>>(typeof(Microsoft.Quantum.Canon.ComplexToComplexPolar));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Microsoft.Quantum.Canon.ComplexPolar data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Canon.ComplexPolar> Run(IOperationFactory __m__, Double word)
        {
            return __m__.Run<GenerateCoefficientSame, Double, Microsoft.Quantum.Canon.ComplexPolar>(word);
        }
    }

    public class GenerateCoefficientOpp : Operation<Double, Microsoft.Quantum.Canon.ComplexPolar>, ICallable
    {
        public GenerateCoefficientOpp(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateCoefficientOpp";
        String ICallable.FullName => "HW5p2.GenerateCoefficientOpp";
        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Canon.ComplexPolar> MicrosoftQuantumCanonComplexToComplexPolar
        {
            get;
            set;
        }

        public override Func<Double, Microsoft.Quantum.Canon.ComplexPolar> Body => (__in) =>
        {
            var word = __in;
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            return MicrosoftQuantumCanonComplexToComplexPolar.Apply(new Microsoft.Quantum.Extensions.Math.Complex(((1D - word), 0D)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonComplexToComplexPolar = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Microsoft.Quantum.Canon.ComplexPolar>>(typeof(Microsoft.Quantum.Canon.ComplexToComplexPolar));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Microsoft.Quantum.Canon.ComplexPolar data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Canon.ComplexPolar> Run(IOperationFactory __m__, Double word)
        {
            return __m__.Run<GenerateCoefficientOpp, Double, Microsoft.Quantum.Canon.ComplexPolar>(word);
        }
    }

    public class EncodePhaseFlipCode : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public EncodePhaseFlipCode(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "EncodePhaseFlipCode";
        String ICallable.FullName => "HW5p2.EncodePhaseFlipCode";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (data,auxillaryQubits) = __in;
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((data, auxillaryQubits[0L]));
#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((data, auxillaryQubits[1L]));
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((((IAdjointable)MicrosoftQuantumPrimitiveH), (new QArray<Qubit>()
            {data} + auxillaryQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (data,auxillaryQubits) = __in;
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((((IAdjointable)MicrosoftQuantumPrimitiveH), (new QArray<Qubit>()
            {data} + auxillaryQubits)));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((data, auxillaryQubits[1L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((data, auxillaryQubits[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit data, QArray<Qubit> auxillaryQubits)
        {
            return __m__.Run<EncodePhaseFlipCode, (Qubit,QArray<Qubit>), QVoid>((data, auxillaryQubits));
        }
    }

    public class TestP2Solution : Operation<ICallable, QVoid>, ICallable
    {
        public TestP2Solution(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestP2Solution";
        String ICallable.FullName => "HW5p2.TestP2Solution";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> EncodePhaseFlipCode
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> P1Solution
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<ICallable, QVoid> Body => (__in) =>
        {
            var errorize = __in;
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var register = Allocate.Apply(3L);
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var data = register[0L];
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var auxillaryQubits = register?.Slice(new Range(1L, 2L));
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            EncodePhaseFlipCode.Apply((data, auxillaryQubits));
            // AssertProbIntBE(2, 1.0 / 4.0, BigEndian(register), 0.000000000000001);
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            errorize.Apply(register);
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), register));
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            P1Solution.Apply(register);
#line 62 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), register));
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            EncodePhaseFlipCode.Adjoint.Apply((data, auxillaryQubits));
#line 65 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            Assert.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {data}, Result.Zero, "Didn't return to Zero"));
#line hidden
            Release.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.EncodePhaseFlipCode = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(HW5p2.EncodePhaseFlipCode));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.P1Solution = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW5p2.P1Solution));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable errorize)
        {
            return __m__.Run<TestP2Solution, ICallable, QVoid>(errorize);
        }
    }

    public class TestAllThreePhaseFlips : Operation<QVoid, QVoid>, ICallable
    {
        public TestAllThreePhaseFlips(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestAllThreePhaseFlips";
        String ICallable.FullName => "HW5p2.TestAllThreePhaseFlips";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TestP2Solution
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var Z0 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg1) => (new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliI, Pauli.PauliI), _arg1)));
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var Z1 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg2) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliI), _arg2)));
#line 74 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var Z2 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg3) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliZ), _arg3)));
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            TestP2Solution.Apply(((ICallable)Z0));
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            TestP2Solution.Apply(((ICallable)Z1));
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            TestP2Solution.Apply(((ICallable)Z2));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.TestP2Solution = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(HW5p2.TestP2Solution));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestAllThreePhaseFlips, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW5p2", "MinorityVote (code : Qubit[], bitPairity1 : Result, bitPairity2 : Result) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 270L, 7L, 89L)]
[assembly: OperationDeclaration("HW5p2", "P2Solution (code : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 687L, 19L, 46L)]
[assembly: OperationDeclaration("HW5p2", "EncodePhaseFlipCode (word : Double, register : Qubit[]) : ()", new string[] { "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 1771L, 53L, 72L)]
[assembly: OperationDeclaration("HW5p2", "TestP2Solution (word : Int, errorize : (Qubit[] => ())) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 2494L, 74L, 5L)]
[assembly: OperationDeclaration("HW5p2", "TestAllThreePhaseFlips () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 3062L, 93L, 44L)]
[assembly: FunctionDeclaration("HW5p2", "GenerateCoefficientSame (word : Double) : Microsoft.Quantum.Canon.ComplexPolar", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 1444L, 45L, 14L)]
[assembly: FunctionDeclaration("HW5p2", "GenerateCoefficientOpp (word : Double) : Microsoft.Quantum.Canon.ComplexPolar", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs", 1576L, 49L, 14L)]
#line hidden
namespace HW5p2
{
    public class MinorityVote : Operation<(QArray<Qubit>,Result,Result), QVoid>, ICallable
    {
        public MinorityVote(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Result,Result)>, IApplyData
        {
            public In((QArray<Qubit>,Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "MinorityVote";
        String ICallable.FullName => "HW5p2.MinorityVote";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Result,Result), QVoid> Body => (__in) =>
        {
            var (code,bitPairity1,bitPairity2) = __in;
#line 9 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            if (((bitPairity1 == Result.One) && (bitPairity2 == Result.One)))
            {
#line 10 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                MicrosoftQuantumCanonApplyPauli.Apply((new QArray<Pauli>(Pauli.PauliX, Pauli.PauliI, Pauli.PauliX), code));
            }
            else if ((bitPairity1 == Result.One))
            {
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                MicrosoftQuantumCanonApplyPauli.Apply((new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliX), code));
            }
            else if ((bitPairity2 == Result.One))
            {
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                MicrosoftQuantumCanonApplyPauli.Apply((new QArray<Pauli>(Pauli.PauliX, Pauli.PauliX, Pauli.PauliI), code));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Result,Result) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> code, Result bitPairity1, Result bitPairity2)
        {
            return __m__.Run<MinorityVote, (QArray<Qubit>,Result,Result), QVoid>((code, bitPairity1, bitPairity2));
        }
    }

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

        protected ICallable<(QArray<Qubit>,Result,Result), QVoid> MinorityVote
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
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var bitPairity1 = Measure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliI), code));
#line 22 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var bitPairity2 = Measure.Apply((new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ), code));
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MinorityVote.Apply((code, bitPairity1, bitPairity2));
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), code));
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var pairity1 = Measure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliI), code));
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var pairity2 = Measure.Apply((new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ), code));
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), code));
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MinorityVote.Apply((code, bitPairity1, bitPairity2));
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            if (((pairity1 == Result.One) && (pairity2 == Result.One)))
            {
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                MicrosoftQuantumPrimitiveZ.Apply(code[1L]);
            }
            else if ((pairity1 == Result.One))
            {
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                MicrosoftQuantumPrimitiveZ.Apply(code[0L]);
            }
            else if ((pairity2 == Result.One))
            {
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
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
            this.MinorityVote = this.Factory.Get<ICallable<(QArray<Qubit>,Result,Result), QVoid>>(typeof(HW5p2.MinorityVote));
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
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
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
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
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

    public class EncodePhaseFlipCode : Adjointable<(Double,QArray<Qubit>)>, ICallable
    {
        public EncodePhaseFlipCode(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,QArray<Qubit>)>, IApplyData
        {
            public In((Double,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "EncodePhaseFlipCode";
        String ICallable.FullName => "HW5p2.EncodePhaseFlipCode";
        protected ICallable<Double, Microsoft.Quantum.Canon.ComplexPolar> GenerateCoefficientOpp
        {
            get;
            set;
        }

        protected ICallable<Double, Microsoft.Quantum.Canon.ComplexPolar> GenerateCoefficientSame
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonPrepareArbitraryState
        {
            get;
            set;
        }

        public override Func<(Double,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (word,register) = __in;
#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonPrepareArbitraryState.Apply((new QArray<Microsoft.Quantum.Canon.ComplexPolar>(GenerateCoefficientOpp.Apply(word), GenerateCoefficientSame.Apply(word), GenerateCoefficientSame.Apply(word), GenerateCoefficientOpp.Apply(word), GenerateCoefficientSame.Apply(word), GenerateCoefficientOpp.Apply(word), GenerateCoefficientOpp.Apply(word), GenerateCoefficientSame.Apply(word)), new Microsoft.Quantum.Canon.BigEndian(register)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (word,register) = __in;
            MicrosoftQuantumCanonPrepareArbitraryState.Adjoint.Apply((new QArray<Microsoft.Quantum.Canon.ComplexPolar>(GenerateCoefficientOpp.Apply(word), GenerateCoefficientSame.Apply(word), GenerateCoefficientSame.Apply(word), GenerateCoefficientOpp.Apply(word), GenerateCoefficientSame.Apply(word), GenerateCoefficientOpp.Apply(word), GenerateCoefficientOpp.Apply(word), GenerateCoefficientSame.Apply(word)), new Microsoft.Quantum.Canon.BigEndian(register)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GenerateCoefficientOpp = this.Factory.Get<ICallable<Double, Microsoft.Quantum.Canon.ComplexPolar>>(typeof(HW5p2.GenerateCoefficientOpp));
            this.GenerateCoefficientSame = this.Factory.Get<ICallable<Double, Microsoft.Quantum.Canon.ComplexPolar>>(typeof(HW5p2.GenerateCoefficientSame));
            this.MicrosoftQuantumCanonPrepareArbitraryState = this.Factory.Get<IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.PrepareArbitraryState));
        }

        public override IApplyData __dataIn((Double,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double word, QArray<Qubit> register)
        {
            return __m__.Run<EncodePhaseFlipCode, (Double,QArray<Qubit>), QVoid>((word, register));
        }
    }

    public class TestP2Solution : Operation<(Int64,ICallable), QVoid>, ICallable
    {
        public TestP2Solution(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "TestP2Solution";
        String ICallable.FullName => "HW5p2.TestP2Solution";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
        {
            get;
            set;
        }

        protected ICallable<(Int64,Double,Microsoft.Quantum.Canon.BigEndian,Double), QVoid> MicrosoftQuantumCanonAssertProbIntBE
        {
            get;
            set;
        }

        protected IAdjointable<(Double,QArray<Qubit>)> EncodePhaseFlipCode
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> P2Solution
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Boolean, Result> MicrosoftQuantumCanonResultFromBool
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), QVoid> Body => (__in) =>
        {
            var (word,errorize) = __in;
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var wordD = MicrosoftQuantumExtensionsConvertToDouble.Apply(word);
#line 79 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var register = Allocate.Apply(3L);
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            EncodePhaseFlipCode.Apply((wordD, register));
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            MicrosoftQuantumCanonAssertProbIntBE.Apply((0L, (1D / 4D), new Microsoft.Quantum.Canon.BigEndian(register), 1E-15D));
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            errorize.Apply(register);
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            P2Solution.Apply(register);
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            EncodePhaseFlipCode.Adjoint.Apply((wordD, register));
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            Assert.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {register[0L]}, MicrosoftQuantumCanonResultFromBool.Apply((word == 1L)), $"Didn't return to {word}"));
#line hidden
            Release.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.MicrosoftQuantumCanonAssertProbIntBE = this.Factory.Get<ICallable<(Int64,Double,Microsoft.Quantum.Canon.BigEndian,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertProbIntBE));
            this.EncodePhaseFlipCode = this.Factory.Get<IAdjointable<(Double,QArray<Qubit>)>>(typeof(HW5p2.EncodePhaseFlipCode));
            this.P2Solution = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW5p2.P2Solution));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumCanonResultFromBool = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Canon.ResultFromBool));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 word, ICallable errorize)
        {
            return __m__.Run<TestP2Solution, (Int64,ICallable), QVoid>((word, errorize));
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

        protected ICallable<(Int64,ICallable), QVoid> TestP2Solution
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var Z0 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg1) => (new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliI, Pauli.PauliI), _arg1)));
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var Z1 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg2) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliI), _arg2)));
#line 97 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            var Z2 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg3) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliZ), _arg3)));
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
            foreach (var i in new Range(0L, 1L))
            {
#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                TestP2Solution.Apply((i, ((ICallable)Z0)));
#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                TestP2Solution.Apply((i, ((ICallable)Z1)));
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem2.qs"
                TestP2Solution.Apply((i, ((ICallable)Z2)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.TestP2Solution = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(HW5p2.TestP2Solution));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestAllThreePhaseFlips, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
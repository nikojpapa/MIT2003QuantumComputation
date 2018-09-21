#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p2", "Rn (n : Int, target : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs", 240L, 9L, 5L)]
[assembly: OperationDeclaration("HW3p2", "EntryPoint () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs", 413L, 18L, 32L)]
[assembly: OperationDeclaration("HW3p2", "PerformAddition (operandA : Int, operandB : Int) : Int[]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs", 991L, 37L, 68L)]
#line hidden
namespace HW3p2
{
    public class Rn : Operation<(Int64,Qubit), QVoid>, ICallable
    {
        public Rn(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Qubit)>, IApplyData
        {
            public In((Int64,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Rn";
        String ICallable.FullName => "HW3p2.Rn";
        protected IUnitary<(Pauli,Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveRFrac
        {
            get;
            set;
        }

        public override Func<(Int64,Qubit), QVoid> Body => (__in) =>
        {
            var (n,target) = __in;
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var k in new Range(0L, (n - 1L)))
            {
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                MicrosoftQuantumPrimitiveRFrac.Apply((Pauli.PauliI, k, n, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveRFrac = this.Factory.Get<IUnitary<(Pauli,Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.RFrac));
        }

        public override IApplyData __dataIn((Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 n, Qubit target)
        {
            return __m__.Run<Rn, (Int64,Qubit), QVoid>((n, target));
        }
    }

    public class EntryPoint : Operation<QVoid, QVoid>, ICallable
    {
        public EntryPoint(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "EntryPoint";
        String ICallable.FullName => "HW3p2.EntryPoint";
        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Int64>> PerformAddition
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
            // mutable binaryOperandA = new Int[3];
            // for (i in 0..2) {
            //     set binaryOperandA[i] = 0;
            // }
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var operandA = 0L;
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var operandB = 1L;
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var result = PerformAddition.Apply((operandA, operandB));
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var display = "";
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (result.Count - 1L)))
            {
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                display = (display + MicrosoftQuantumExtensionsConvertToStringI.Apply(result[i]));
            }

#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            Message.Apply(display);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.PerformAddition = this.Factory.Get<ICallable<(Int64,Int64), QArray<Int64>>>(typeof(HW3p2.PerformAddition));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<EntryPoint, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class PerformAddition : Operation<(Int64,Int64), QArray<Int64>>, ICallable
    {
        public PerformAddition(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PerformAddition";
        String ICallable.FullName => "HW3p2.PerformAddition";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonIsResultOne
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonPrepareArbitraryState
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonQFT
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

        protected ICallable<(Int64,Qubit), QVoid> Rn
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Int64>> Body => (__in) =>
        {
            var (operandA,operandB) = __in;
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var numStates = (operandA + 1L);
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var initialStateCoefficients = new QArray<Microsoft.Quantum.Canon.ComplexPolar>(numStates);
#line 41 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            initialStateCoefficients[0L] = new Microsoft.Quantum.Canon.ComplexPolar((1D, 0D));
#line 42 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(1L, (initialStateCoefficients.Count - 1L)))
            {
#line 43 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                initialStateCoefficients[i] = new Microsoft.Quantum.Canon.ComplexPolar((0D, 0D));
            }

#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            Message.Apply($"{initialStateCoefficients}");
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var resultBinary = new QArray<Int64>(numStates);
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var qubits = Allocate.Apply(numStates);
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(qubits);
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            MicrosoftQuantumCanonPrepareArbitraryState.Apply((initialStateCoefficients, bigEndian));
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, operandB))
            {
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                Rn.Apply((numStates, bigEndian[i]));
            }

#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (numStates - 1L)))
            {
#line 59 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                var intResult = 0L;
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                var result = M.Apply(bigEndian[i]);
#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                var resultIsOne = MicrosoftQuantumCanonIsResultOne.Apply(result);
#line 62 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                if (resultIsOne)
                {
#line 63 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                    intResult = 1L;
                }

#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                resultBinary[i] = intResult;
            }

#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            return resultBinary;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonIsResultOne = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.IsResultOne));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.MicrosoftQuantumCanonPrepareArbitraryState = this.Factory.Get<IUnitary<(QArray<Microsoft.Quantum.Canon.ComplexPolar>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.PrepareArbitraryState));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Rn = this.Factory.Get<ICallable<(Int64,Qubit), QVoid>>(typeof(HW3p2.Rn));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 operandA, Int64 operandB)
        {
            return __m__.Run<PerformAddition, (Int64,Int64), QArray<Int64>>((operandA, operandB));
        }
    }
}
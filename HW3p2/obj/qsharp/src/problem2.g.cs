#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p2", "PowRn (y : Int, k : Int, qubits : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs", 255L, 9L, 5L)]
[assembly: OperationDeclaration("HW3p2", "Rn (n : Int, qubits : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs", 541L, 21L, 5L)]
[assembly: OperationDeclaration("HW3p2", "PerformAddition (binaryOperandA : Int[], operandB : Int) : Int[]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs", 769L, 30L, 76L)]
[assembly: OperationDeclaration("HW3p2", "EntryPoint () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs", 3463L, 105L, 32L)]
[assembly: FunctionDeclaration("HW3p2", "GenerateBinaries (allBinaries : Int[][], depth : Int) : Int[][]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs", 2426L, 76L, 14L)]
#line hidden
namespace HW3p2
{
    public class PowRn : Operation<(Int64,Int64,Microsoft.Quantum.Canon.BigEndian), QVoid>, ICallable
    {
        public PowRn(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Microsoft.Quantum.Canon.BigEndian)>, IApplyData
        {
            public In((Int64,Int64,Microsoft.Quantum.Canon.BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "PowRn";
        String ICallable.FullName => "HW3p2.PowRn";
        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Microsoft.Quantum.Canon.BigEndian), QVoid> Body => (__in) =>
        {
            var (y,k,qubits) = __in;
            // Message($"y: {y}");
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (qubits.Count - 1L)))
            {
                // Message($"i: {i}");
#line 15 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                MicrosoftQuantumPrimitiveR1Frac.Apply(((2L * y), k, qubits[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn((Int64,Int64,Microsoft.Quantum.Canon.BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 y, Int64 k, Microsoft.Quantum.Canon.BigEndian qubits)
        {
            return __m__.Run<PowRn, (Int64,Int64,Microsoft.Quantum.Canon.BigEndian), QVoid>((y, k, qubits));
        }
    }

    public class Rn : Operation<(Int64,Microsoft.Quantum.Canon.BigEndian), QVoid>, ICallable
    {
        public Rn(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Microsoft.Quantum.Canon.BigEndian)>, IApplyData
        {
            public In((Int64,Microsoft.Quantum.Canon.BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Rn";
        String ICallable.FullName => "HW3p2.Rn";
        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<(Int64,Microsoft.Quantum.Canon.BigEndian), QVoid> Body => (__in) =>
        {
            var (n,qubits) = __in;
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (qubits.Count - 1L)))
            {
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                MicrosoftQuantumPrimitiveR1Frac.Apply((1L, i, qubits[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn((Int64,Microsoft.Quantum.Canon.BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 n, Microsoft.Quantum.Canon.BigEndian qubits)
        {
            return __m__.Run<Rn, (Int64,Microsoft.Quantum.Canon.BigEndian), QVoid>((n, qubits));
        }
    }

    public class PerformAddition : Operation<(QArray<Int64>,Int64), QArray<Int64>>, ICallable
    {
        public PerformAddition(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64) data) : base(data)
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

        protected ICallable<(Int64,Microsoft.Quantum.Canon.BigEndian), QVoid> Rn
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64), QArray<Int64>> Body => (__in) =>
        {
            var (binaryOperandA,operandB) = __in;
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var numInputQubits = binaryOperandA.Count;
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var initialStateCoefficients = new QArray<Microsoft.Quantum.Canon.ComplexPolar>(numInputQubits);
            // for (i in 0..Length(initialStateCoefficients)-2) {
            //     set initialStateCoefficients[i] = ComplexPolar(0.0, 0.0);
            // }
            // set initialStateCoefficients[numStates - 1] = ComplexPolar(1.0, 0.0);
            // Message($"{initialStateCoefficients}");
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var resultBinary = new QArray<Int64>(numInputQubits);
#line 42 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var qubits = Allocate.Apply(numInputQubits);
#line 43 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(qubits);
#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (numInputQubits - 1L)))
            {
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                if ((binaryOperandA[i] == 1L))
                {
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                    MicrosoftQuantumPrimitiveX.Apply(bigEndian[i]);
                }
            }

            // AssertProbIntBE(1, 1.0, bigEndian, 0.000001);
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
            // PowRn(operandB, numInputQubits, bigEndian);
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (operandB - 1L)))
            {
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                Rn.Apply((numInputQubits, bigEndian));
            }

#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (numInputQubits - 1L)))
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
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Rn = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.BigEndian), QVoid>>(typeof(HW3p2.Rn));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<Int64> binaryOperandA, Int64 operandB)
        {
            return __m__.Run<PerformAddition, (QArray<Int64>,Int64), QArray<Int64>>((binaryOperandA, operandB));
        }
    }

    public class GenerateBinaries : Operation<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>, ICallable
    {
        public GenerateBinaries(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,Int64)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GenerateBinaries";
        String ICallable.FullName => "HW3p2.GenerateBinaries";
        public override Func<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>> Body => (__in) =>
        {
            var (allBinaries,depth) = __in;
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var numBinaries = allBinaries.Count;
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var lastBinary = allBinaries[(numBinaries - 1L)];
#line 79 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var binaryLength = lastBinary.Count;
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var newBinaryPosition = numBinaries;
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            if ((depth > (binaryLength - 1L)))
            {
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                return allBinaries;
            }

#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var newBinary = new QArray<Int64>(binaryLength);
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (binaryLength - 1L)))
            {
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                newBinary[i] = lastBinary[i];
            }

#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var binariesFromZero = ((ICallable)this).Apply<QArray<QArray<Int64>>>((allBinaries, (depth + 1L)));
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            newBinary[depth] = 1L;
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var newAllBinaries2 = new QArray<QArray<Int64>>((binariesFromZero.Count + 1L));
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (binariesFromZero.Count - 1L)))
            {
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                newAllBinaries2[i] = binariesFromZero[i];
            }

#line 98 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            newAllBinaries2[binariesFromZero.Count] = newBinary;
#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var binariesFromOne = ((ICallable)this).Apply<QArray<QArray<Int64>>>((newAllBinaries2, (depth + 1L)));
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            return binariesFromOne;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, QArray<QArray<Int64>> allBinaries, Int64 depth)
        {
            return __m__.Run<GenerateBinaries, (QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>((allBinaries, depth));
        }
    }

    public class EntryPoint : Operation<QVoid, QVoid>, ICallable
    {
        public EntryPoint(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "EntryPoint";
        String ICallable.FullName => "HW3p2.EntryPoint";
        protected ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>> GenerateBinaries
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,Int64), QArray<Int64>> PerformAddition
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
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var numTestQubits = 3L;
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var maxOperandB = 3L;
#line 110 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var initialBinaries = new QArray<QArray<Int64>>(1L);
#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            initialBinaries[0L] = new QArray<Int64>(numTestQubits);
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            var allBinaries = GenerateBinaries.Apply((initialBinaries, 0L));
#line 113 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            Message.Apply($"{allBinaries}");
#line 115 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
            foreach (var i in new Range(0L, (allBinaries.Count - 1L)))
            {
#line 116 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                var binaryOperandA = allBinaries[i];
#line 117 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                foreach (var j in new Range(0L, maxOperandB))
                {
#line 118 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                    var result = PerformAddition.Apply((binaryOperandA, j));
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                    var display = "";
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                    foreach (var k in new Range(0L, (result.Count - 1L)))
                    {
#line 122 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                        display = (display + MicrosoftQuantumExtensionsConvertToStringI.Apply(result[k]));
                    }

#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem2.qs"
                    Message.Apply($"{binaryOperandA} + {j} => {display}");
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GenerateBinaries = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>>(typeof(HW3p2.GenerateBinaries));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.PerformAddition = this.Factory.Get<ICallable<(QArray<Int64>,Int64), QArray<Int64>>>(typeof(HW3p2.PerformAddition));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<EntryPoint, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
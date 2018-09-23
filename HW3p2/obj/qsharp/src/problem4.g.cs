#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p2", "FredkinNot (controlReg : Qubit[], swap1 : Qubit, swap2 : Qubit) : ()", new string[] { "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 216L, 6L, 79L)]
[assembly: OperationDeclaration("HW3p2", "NControlledU (qubits : Qubit[], op : (Qubit => () : Controlled, Adjoint)) : ()", new string[] { "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 593L, 18L, 90L)]
[assembly: OperationDeclaration("HW3p2", "InitQubit (index : Int, binaryRep : Int[], target : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 1728L, 51L, 74L)]
[assembly: OperationDeclaration("HW3p2", "ControlledX (qubits : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 1877L, 57L, 48L)]
[assembly: OperationDeclaration("HW3p2", "Problem4Entry () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 2001L, 63L, 35L)]
[assembly: FunctionDeclaration("HW3p2", "NumIsOne (num : Int) : Bool", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 1596L, 47L, 14L)]
#line hidden
namespace HW3p2
{
    public class FredkinNot : Adjointable<(QArray<Qubit>,Qubit,Qubit)>, ICallable
    {
        public FredkinNot(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "FredkinNot";
        String ICallable.FullName => "HW3p2.FredkinNot";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (controlReg,swap1,swap2) = __in;
#line 8 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((controlReg.Count, 1L, "Fredkin only takes one control qubit"));
#line 10 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveX.Apply(controlReg[0L]);
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((controlReg, (swap1, swap2)));
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveX.Apply(controlReg[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (controlReg,swap1,swap2) = __in;
            MicrosoftQuantumCanonAssertIntEqual.Apply((controlReg.Count, 1L, "Fredkin only takes one control qubit"));
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(controlReg[0L]);
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((controlReg, (swap1, swap2)));
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(controlReg[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> controlReg, Qubit swap1, Qubit swap2)
        {
            return __m__.Run<FredkinNot, (QArray<Qubit>,Qubit,Qubit), QVoid>((controlReg, swap1, swap2));
        }
    }

    public class NControlledU : Adjointable<(QArray<Qubit>,IUnitary)>, ICallable
    {
        public NControlledU(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,IUnitary)>, IApplyData
        {
            public In((QArray<Qubit>,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "NControlledU";
        String ICallable.FullName => "HW3p2.NControlledU";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit,Qubit)> FredkinNot
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonSubarray
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,IUnitary), QVoid> Body => (__in) =>
        {
            var (qubits,op) = __in;
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var controlReg = MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits);
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var targetReg = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
            {(qubits.Count - 1L)}, qubits));
#line 22 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var target = targetReg[0L];
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var numControlQubits = controlReg.Count;
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var halfNum = (numControlQubits / 2L);
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var topControl = controlReg?.Slice(new Range(0L, (halfNum - 1L)));
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var bottomControl = controlReg?.Slice(new Range(halfNum, (numControlQubits - 1L)));
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var workQ = Allocate.Apply(1L);
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            foreach (var i in new Range(0L, (halfNum - 1L)))
            {
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                FredkinNot.Apply((MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
                {i}, topControl)), bottomControl[i], workQ[0L]));
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                if ((halfNum == 1L))
                {
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    op.Controlled.Apply((bottomControl, target));
                }
                else
                {
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    ((IAdjointable)this).Apply(((bottomControl + targetReg), ((IUnitary)op)));
                }

#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                FredkinNot.Apply((MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
                {i}, topControl)), bottomControl[i], workQ[0L]));
            }

            // Reset(workQ[0]);
            ;
#line hidden
            Release.Apply(workQ);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,IUnitary), QVoid> AdjointBody => (__in) =>
        {
            var (qubits,op) = __in;
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var controlReg = MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits);
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var targetReg = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
            {(qubits.Count - 1L)}, qubits));
#line 22 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var target = targetReg[0L];
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var numControlQubits = controlReg.Count;
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var halfNum = (numControlQubits / 2L);
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var topControl = controlReg?.Slice(new Range(0L, (halfNum - 1L)));
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var bottomControl = controlReg?.Slice(new Range(halfNum, (numControlQubits - 1L)));
            var workQ = Allocate.Apply(1L);
            // Reset(workQ[0]);
            foreach (var i in new Range((0L - ((((halfNum - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                FredkinNot.Adjoint.Apply((MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
                {i}, topControl)), bottomControl[i], workQ[0L]));
                if ((halfNum == 1L))
                {
                    op.Controlled.Adjoint.Apply((bottomControl, target));
                }
                else
                {
                    ((IAdjointable)this).Adjoint.Apply(((bottomControl + targetReg), ((IUnitary)op)));
                }

                FredkinNot.Adjoint.Apply((MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
                {i}, topControl)), bottomControl[i], workQ[0L]));
            }

#line hidden
            Release.Apply(workQ);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.FredkinNot = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,Qubit)>>(typeof(HW3p2.FredkinNot));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumCanonSubarray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Subarray<>));
        }

        public override IApplyData __dataIn((QArray<Qubit>,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits, IUnitary op)
        {
            return __m__.Run<NControlledU, (QArray<Qubit>,IUnitary), QVoid>((qubits, op));
        }
    }

    public class NumIsOne : Operation<Int64, Boolean>, ICallable
    {
        public NumIsOne(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "NumIsOne";
        String ICallable.FullName => "HW3p2.NumIsOne";
        public override Func<Int64, Boolean> Body => (__in) =>
        {
            var num = __in;
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            return (num == 1L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 num)
        {
            return __m__.Run<NumIsOne, Int64, Boolean>(num);
        }
    }

    public class InitQubit : Operation<(Int64,QArray<Int64>,Qubit), QVoid>, ICallable
    {
        public InitQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>,Qubit)>, IApplyData
        {
            public In((Int64,QArray<Int64>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "InitQubit";
        String ICallable.FullName => "HW3p2.InitQubit";
        protected ICallable MicrosoftQuantumCanonApplyIf
        {
            get;
            set;
        }

        protected ICallable<Int64, Boolean> NumIsOne
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>,Qubit), QVoid> Body => (__in) =>
        {
            var (index,binaryRep,target) = __in;
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumCanonApplyIf.Apply((((ICallable)MicrosoftQuantumPrimitiveX), NumIsOne.Apply(binaryRep[index]), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyIf = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyIf<>));
            this.NumIsOne = this.Factory.Get<ICallable<Int64, Boolean>>(typeof(HW3p2.NumIsOne));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 index, QArray<Int64> binaryRep, Qubit target)
        {
            return __m__.Run<InitQubit, (Int64,QArray<Int64>,Qubit), QVoid>((index, binaryRep, target));
        }
    }

    public class ControlledX : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public ControlledX(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ControlledX";
        String ICallable.FullName => "HW3p2.ControlledX";
        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qubits = __in;
#line 59 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits), MicrosoftQuantumCanonTail.Apply<Qubit>(qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<ControlledX, QArray<Qubit>, QVoid>(qubits);
        }
    }

    public class Problem4Entry : Operation<QVoid, QVoid>, ICallable
    {
        public Problem4Entry(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Problem4Entry";
        String ICallable.FullName => "HW3p2.Problem4Entry";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonApplyToEachIndex
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonBoolFromResult
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonForAll
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<QArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(Int64,QArray<Int64>,Qubit), QVoid> InitQubit
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,IUnitary)> NControlledU
        {
            get;
            set;
        }

        protected ICallable<Int64, Boolean> NumIsOne
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

        protected ICallable<Boolean, Result> MicrosoftQuantumCanonResultFromBool
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 65 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var numQubits = 5L;
            // AssertOperationsEqualInPlace(ControlledX, NControlledU(_, X), numQubits);
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var allBinaries = GenerateAllBinariesOfLength.Apply(numQubits);
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var qubits = Allocate.Apply(numQubits);
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            foreach (var i in new Range(0L, (allBinaries.Count - 1L)))
            {
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                var thisBinary = allBinaries[i];
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                Message.Apply($"thisBinary: {thisBinary}");
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                MicrosoftQuantumCanonApplyToEachIndex.Apply((((ICallable)InitQubit.Partial(new Func<(Int64,Qubit), (Int64,QArray<Int64>,Qubit)>((_arg1) => (_arg1.Item1, thisBinary, _arg1.Item2)))), qubits));
                // for (j in 0..numQubits-1) {
                //     let shouldBe = ResultFromBool(NumIsOne(thisBinary[j]));
                //     Message($"{j}: {shouldBe}");
                //     AssertQubit(shouldBe, qubits[j]);
                // }
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                NControlledU.Apply((qubits, ((IUnitary)MicrosoftQuantumPrimitiveX)));
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                var expectedResult = MicrosoftQuantumCanonResultFromBool.Apply(NumIsOne.Apply(MicrosoftQuantumCanonTail.Apply<Int64>(thisBinary)));
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                if (MicrosoftQuantumCanonForAll.Apply<Boolean>((((ICallable)NumIsOne), MicrosoftQuantumCanonMost.Apply<QArray<Int64>>(thisBinary))))
                {
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    expectedResult = MicrosoftQuantumCanonResultFromBool.Apply(!(MicrosoftQuantumCanonBoolFromResult.Apply(expectedResult)));
                }

#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((expectedResult, MicrosoftQuantumCanonTail.Apply<Qubit>(qubits)));
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                ResetAll.Apply(qubits);
            }

#line hidden
            Release.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonApplyToEachIndex = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndex<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.MicrosoftQuantumCanonBoolFromResult = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.BoolFromResult));
            this.MicrosoftQuantumCanonForAll = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ForAll<>));
            this.GenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(HW3p2.GenerateAllBinariesOfLength));
            this.InitQubit = this.Factory.Get<ICallable<(Int64,QArray<Int64>,Qubit), QVoid>>(typeof(HW3p2.InitQubit));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.NControlledU = this.Factory.Get<IAdjointable<(QArray<Qubit>,IUnitary)>>(typeof(HW3p2.NControlledU));
            this.NumIsOne = this.Factory.Get<ICallable<Int64, Boolean>>(typeof(HW3p2.NumIsOne));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonResultFromBool = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Canon.ResultFromBool));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Problem4Entry, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
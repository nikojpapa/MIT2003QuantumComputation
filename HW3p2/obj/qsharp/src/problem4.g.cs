#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p2", "FredkinNot (control : Qubit, swap1 : Qubit, swap2 : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 211L, 6L, 74L)]
[assembly: OperationDeclaration("HW3p2", "NControlledU (qubits : Qubit[], op : (Qubit => () : Controlled, Adjoint)) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 506L, 16L, 90L)]
[assembly: OperationDeclaration("HW3p2", "InitQubit (index : Int, binaryRep : Int[], target : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 1606L, 48L, 74L)]
[assembly: OperationDeclaration("HW3p2", "Problem4Entry () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 1742L, 54L, 35L)]
[assembly: FunctionDeclaration("HW3p2", "NumIsOne (num : Int) : Bool", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs", 1474L, 44L, 14L)]
#line hidden
namespace HW3p2
{
    public class FredkinNot : Operation<(Qubit,Qubit,Qubit), QVoid>, ICallable
    {
        public FredkinNot(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "FredkinNot";
        String ICallable.FullName => "HW3p2.FredkinNot";
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

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (control,swap1,swap2) = __in;
#line 8 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveX.Apply(control);
#line 10 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var controlReg = new QArray<Qubit>(1L);
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            controlReg[0L] = control;
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((controlReg, (swap1, swap2)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit control, Qubit swap1, Qubit swap2)
        {
            return __m__.Run<FredkinNot, (Qubit,Qubit,Qubit), QVoid>((control, swap1, swap2));
        }
    }

    public class NControlledU : Operation<(QArray<Qubit>,IUnitary), QVoid>, ICallable
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

        protected ICallable<(Qubit,Qubit,Qubit), QVoid> FredkinNot
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

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,IUnitary), QVoid> Body => (__in) =>
        {
            var (qubits,op) = __in;
#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var controlReg = MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits);
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var targetReg = new QArray<Qubit>(1L);
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var target = MicrosoftQuantumCanonTail.Apply<Qubit>(qubits);
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            targetReg[0L] = target;
#line 23 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var numControlQubits = controlReg.Count;
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var halfNum = (numControlQubits / 2L);
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var topControl = controlReg?.Slice(new Range(0L, (halfNum - 1L)));
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var bottomControl = controlReg?.Slice(new Range(halfNum, (numControlQubits - 1L)));
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var workQ = Allocate.Apply(1L);
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            foreach (var i in new Range(0L, (halfNum - 1L)))
            {
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                FredkinNot.Apply((topControl[i], bottomControl[i], workQ[0L]));
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                if ((halfNum == 1L))
                {
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    op.Controlled.Apply((bottomControl, target));
                }
                else
                {
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    ((ICallable)this).Apply(((bottomControl + targetReg), ((IUnitary)op)));
                }

#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                FredkinNot.Apply((topControl[i], bottomControl[i], workQ[0L]));
            }

#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            ResetAll.Apply(workQ);
#line hidden
            Release.Apply(workQ);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.FredkinNot = this.Factory.Get<ICallable<(Qubit,Qubit,Qubit), QVoid>>(typeof(HW3p2.FredkinNot));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
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
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
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
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
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

        protected ICallable<(QArray<Qubit>,IUnitary), QVoid> NControlledU
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
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var numQubits = 3L;
            // let f = NControlledU(_, X);
            // AssertOperationsEqualInPlace(NControlledU(_, X), (Adjoint (Controlled X)), 3);
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var allBinaries = GenerateAllBinariesOfLength.Apply(numQubits);
#line 62 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var qubits = Allocate.Apply(numQubits);
#line 63 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            foreach (var i in new Range(0L, (allBinaries.Count - 1L)))
            {
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                var thisBinary = allBinaries[i];
#line 65 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                Message.Apply($"thisBinary: {thisBinary}");
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                MicrosoftQuantumCanonApplyToEachIndex.Apply((((ICallable)InitQubit.Partial(new Func<(Int64,Qubit), (Int64,QArray<Int64>,Qubit)>((_arg1) => (_arg1.Item1, thisBinary, _arg1.Item2)))), qubits));
                // for (j in 0..numQubits-1) {
                //     let shouldBe = ResultFromBool(NumIsOne(thisBinary[j]));
                //     Message($"{j}: {shouldBe}");
                //     AssertQubit(shouldBe, qubits[j]);
                // }
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                NControlledU.Apply((qubits, ((IUnitary)MicrosoftQuantumPrimitiveX)));
#line 75 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                var expectedResult = MicrosoftQuantumCanonResultFromBool.Apply(NumIsOne.Apply(MicrosoftQuantumCanonTail.Apply<Int64>(thisBinary)));
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                if (MicrosoftQuantumCanonForAll.Apply<Boolean>((((ICallable)NumIsOne), MicrosoftQuantumCanonMost.Apply<QArray<Int64>>(thisBinary))))
                {
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    expectedResult = MicrosoftQuantumCanonResultFromBool.Apply(!(MicrosoftQuantumCanonBoolFromResult.Apply(expectedResult)));
                }

#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((expectedResult, MicrosoftQuantumCanonTail.Apply<Qubit>(qubits)));
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
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
            this.NControlledU = this.Factory.Get<ICallable<(QArray<Qubit>,IUnitary), QVoid>>(typeof(HW3p2.NControlledU));
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
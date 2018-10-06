#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW5p2", "EncodeShorFlipCode (data : Qubit, auxillaryZQubits : Qubit[], auxillaryXQubits : Qubit[]) : ()", new string[] { "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 854L, 26L, 105L)]
[assembly: OperationDeclaration("HW5p2", "TestP3Solution (errorize : (Qubit[] => ())) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 1318L, 40L, 5L)]
[assembly: OperationDeclaration("HW5p2", "ApplyMultiPauli (paulis : (Qubit[] => ())[], target : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 2226L, 64L, 79L)]
[assembly: OperationDeclaration("HW5p2", "TestAllPauliErrors () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 2395L, 72L, 40L)]
#line hidden
namespace HW5p2
{
    public class EncodeShorFlipCode : Adjointable<(Qubit,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public EncodeShorFlipCode(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "EncodeShorFlipCode";
        String ICallable.FullName => "HW5p2.EncodeShorFlipCode";
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

        public override Func<(Qubit,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (data,auxillaryZQubits,auxillaryXQubits) = __in;
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((((IAdjointable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (data, _arg1)))), auxillaryZQubits));
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((((IAdjointable)MicrosoftQuantumPrimitiveH), (new QArray<Qubit>()
            {data} + auxillaryZQubits)));
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((((IAdjointable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg2) => (data, _arg2)))), auxillaryXQubits?.Slice(new Range(0L, 1L))));
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((((IAdjointable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg3) => (auxillaryZQubits[0L], _arg3)))), auxillaryXQubits?.Slice(new Range(2L, 3L))));
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((((IAdjointable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg4) => (auxillaryZQubits[1L], _arg4)))), auxillaryXQubits?.Slice(new Range(4L, 5L))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (data,auxillaryZQubits,auxillaryXQubits) = __in;
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((((IAdjointable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (auxillaryZQubits[1L], _arg1)))), auxillaryXQubits?.Slice(new Range(4L, 5L))));
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((((IAdjointable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg2) => (auxillaryZQubits[0L], _arg2)))), auxillaryXQubits?.Slice(new Range(2L, 3L))));
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((((IAdjointable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg3) => (data, _arg3)))), auxillaryXQubits?.Slice(new Range(0L, 1L))));
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((((IAdjointable)MicrosoftQuantumPrimitiveH), (new QArray<Qubit>()
            {data} + auxillaryZQubits)));
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((((IAdjointable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg4) => (data, _arg4)))), auxillaryZQubits));
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

        public override IApplyData __dataIn((Qubit,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit data, QArray<Qubit> auxillaryZQubits, QArray<Qubit> auxillaryXQubits)
        {
            return __m__.Run<EncodeShorFlipCode, (Qubit,QArray<Qubit>,QArray<Qubit>), QVoid>((data, auxillaryZQubits, auxillaryXQubits));
        }
    }

    public class TestP3Solution : Operation<ICallable, QVoid>, ICallable
    {
        public TestP3Solution(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestP3Solution";
        String ICallable.FullName => "HW5p2.TestP3Solution";
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

        protected IAdjointable<(Qubit,QArray<Qubit>,QArray<Qubit>)> EncodeShorFlipCode
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonHead
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> P1Solution
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

        protected ICallable MicrosoftQuantumCanonSubarray
        {
            get;
            set;
        }

        public override Func<ICallable, QVoid> Body => (__in) =>
        {
            var errorize = __in;
#line 43 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var register = Allocate.Apply(9L);
#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var data = MicrosoftQuantumCanonHead.Apply<Qubit>(register);
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var auxillaryZQubits = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>(3L, 6L), register));
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var auxillaryXQubits = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>(1L, 2L, 4L, 5L, 7L, 8L), register));
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            EncodeShorFlipCode.Apply((data, auxillaryZQubits, auxillaryXQubits));
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            errorize.Apply(register);
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            P1Solution.Apply((new QArray<Qubit>()
            {data} + auxillaryXQubits?.Slice(new Range(0L, 1L))));
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            P1Solution.Apply((new QArray<Qubit>()
            {auxillaryZQubits[0L]} + auxillaryXQubits?.Slice(new Range(2L, 3L))));
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            P1Solution.Apply((new QArray<Qubit>()
            {auxillaryZQubits[1L]} + auxillaryXQubits?.Slice(new Range(4L, 5L))));
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            P2Solution.Apply((new QArray<Qubit>()
            {data} + auxillaryZQubits));
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            EncodeShorFlipCode.Adjoint.Apply((data, auxillaryZQubits, auxillaryXQubits));
#line 59 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
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
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.EncodeShorFlipCode = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW5p2.EncodeShorFlipCode));
            this.MicrosoftQuantumCanonHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Head<>));
            this.P1Solution = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW5p2.P1Solution));
            this.P2Solution = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW5p2.P2Solution));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumCanonSubarray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Subarray<>));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable errorize)
        {
            return __m__.Run<TestP3Solution, ICallable, QVoid>(errorize);
        }
    }

    public class ApplyMultiPauli : Operation<(QArray<ICallable>,QArray<Qubit>), QVoid>, ICallable
    {
        public ApplyMultiPauli(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<ICallable>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<ICallable>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyMultiPauli";
        String ICallable.FullName => "HW5p2.ApplyMultiPauli";
        public override Func<(QArray<ICallable>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (paulis,target) = __in;
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            foreach (var i in new Range(0L, (paulis.Count - 1L)))
            {
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                paulis[i].Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<ICallable>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<ICallable> paulis, QArray<Qubit> target)
        {
            return __m__.Run<ApplyMultiPauli, (QArray<ICallable>,QArray<Qubit>), QVoid>((paulis, target));
        }
    }

    public class TestAllPauliErrors : Operation<QVoid, QVoid>, ICallable
    {
        public TestAllPauliErrors(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestAllPauliErrors";
        String ICallable.FullName => "HW5p2.TestAllPauliErrors";
        protected ICallable<(QArray<ICallable>,QArray<Qubit>), QVoid> ApplyMultiPauli
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, QArray<Pauli>> MicrosoftQuantumCanonIntsToPaulis
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TestP3Solution
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 74 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            foreach (var b in new Range(0L, 8L))
            {
#line 75 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                foreach (var i in new Range(0L, 3L))
                {
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    foreach (var j in new Range(0L, 3L))
                    {
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        var paulis1 = new QArray<Int64>(8L);
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        var paulis2 = new QArray<Int64>(8L);
#line 79 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        paulis1[b] = i;
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        paulis2[b] = j;
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        Message.Apply($"{paulis1}");
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        Message.Apply($"{paulis2}");
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        Message.Apply("");
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        var op1 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg1) => (MicrosoftQuantumCanonIntsToPaulis.Apply(paulis1), _arg1)));
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        var op2 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg2) => (MicrosoftQuantumCanonIntsToPaulis.Apply(paulis2), _arg2)));
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        TestP3Solution.Apply(((ICallable)ApplyMultiPauli.Partial(new Func<QArray<Qubit>, (QArray<ICallable>,QArray<Qubit>)>((_arg3) => (new QArray<ICallable>(op1, op2), _arg3)))));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyMultiPauli = this.Factory.Get<ICallable<(QArray<ICallable>,QArray<Qubit>), QVoid>>(typeof(HW5p2.ApplyMultiPauli));
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.MicrosoftQuantumCanonIntsToPaulis = this.Factory.Get<ICallable<QArray<Int64>, QArray<Pauli>>>(typeof(Microsoft.Quantum.Canon.IntsToPaulis));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.TestP3Solution = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(HW5p2.TestP3Solution));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestAllPauliErrors, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW5p2", "EncodeIntoBitFlipCode (data : Qubit, auxillaryQubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 290L, 10L, 5L)]
[assembly: OperationDeclaration("HW5p2", "P2BlockSolution (code : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 1058L, 29L, 51L)]
[assembly: OperationDeclaration("HW5p2", "EncodeShorFlipCode (data : Qubit, auxillaryZQubits : Qubit[], auxillaryXQubits : Qubit[]) : ()", new string[] { "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 2416L, 71L, 105L)]
[assembly: OperationDeclaration("HW5p2", "TestP3Solution (errorize : (Qubit[] => ())) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 3177L, 89L, 5L)]
[assembly: OperationDeclaration("HW5p2", "ApplyMultiPauli (paulis : (Qubit[] => ())[], target : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 4427L, 121L, 79L)]
[assembly: OperationDeclaration("HW5p2", "TestAllPauliErrors () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs", 4596L, 129L, 40L)]
#line hidden
namespace HW5p2
{
    public class EncodeIntoBitFlipCode : Unitary<(Qubit,QArray<Qubit>)>, ICallable
    {
        public EncodeIntoBitFlipCode(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "EncodeIntoBitFlipCode";
        String ICallable.FullName => "HW5p2.EncodeIntoBitFlipCode";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (data,auxillaryQubits) = __in;
            // We use the ApplyToEach operation from the canon,
            // partially applied with the data qubit, to represent
            // a "CNOT-ladder." In this case, the line below
            // applies CNOT₀₁ · CNOT₀₂.
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (data, _arg1)))), auxillaryQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (data,auxillaryQubits) = __in;
            // We use the ApplyToEach operation from the canon,
            // partially applied with the data qubit, to represent
            // a "CNOT-ladder." In this case, the line below
            // applies CNOT₀₁ · CNOT₀₂.
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (data, _arg1)))), auxillaryQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(data,auxillaryQubits)) = __in;
            // We use the ApplyToEach operation from the canon,
            // partially applied with the data qubit, to represent
            // a "CNOT-ladder." In this case, the line below
            // applies CNOT₀₁ · CNOT₀₂.
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (data, _arg1)))), auxillaryQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(data,auxillaryQubits)) = __in;
            // We use the ApplyToEach operation from the canon,
            // partially applied with the data qubit, to represent
            // a "CNOT-ladder." In this case, the line below
            // applies CNOT₀₁ · CNOT₀₂.
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (data, _arg1)))), auxillaryQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit data, QArray<Qubit> auxillaryQubits)
        {
            return __m__.Run<EncodeIntoBitFlipCode, (Qubit,QArray<Qubit>), QVoid>((data, auxillaryQubits));
        }
    }

    public class P2BlockSolution : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public P2BlockSolution(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "P2BlockSolution";
        String ICallable.FullName => "HW5p2.P2BlockSolution";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var code = __in;
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), code));
            // for (i in 0..8) {
            //     Message($"{i}");
            //     Assert([PauliZ], [code[i]], Zero, "Not Zero");
            // }
#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var workQubits = Allocate.Apply(2L);
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            foreach (var i in new Range(0L, 1L))
            {
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                foreach (var j in new Range(0L, 5L))
                {
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((code[(j + (i * 3L))], workQubits[i]));
                }
            }

#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var result1 = M.Apply(workQubits[0L]);
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var result2 = M.Apply(workQubits[1L]);
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            if ((result1 == Result.Zero))
            {
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                if ((result2 == Result.Zero))
                {
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    Message.Apply("{|000>, |111>}");
                }
                else
                {
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    Message.Apply("{|001>, |110>}");
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveX), code?.Slice(new Range(6L, 8L))));
                }
            }
            else
            {
#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                if ((result2 == Result.Zero))
                {
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    Message.Apply("{|100>, |011>}");
#line 57 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveX), code?.Slice(new Range(0L, 2L))));
                }
                else
                {
#line 59 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    Message.Apply("{|010>, |101>}");
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveX), code?.Slice(new Range(3L, 5L))));
                }
            }

#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            ResetAll.Apply(workQubits);
#line hidden
            Release.Apply(workQubits);
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), code));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> code)
        {
            return __m__.Run<P2BlockSolution, QArray<Qubit>, QVoid>(code);
        }
    }

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
        protected IUnitary<(Qubit,QArray<Qubit>)> EncodeIntoBitFlipCode
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> EncodePhaseFlipCode
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (data,auxillaryZQubits,auxillaryXQubits) = __in;
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            EncodePhaseFlipCode.Apply((data, auxillaryZQubits));
            // ApplyToEachA(CNOT(data, _), auxillaryZQubits);
            // ApplyToEachA(H, [data] + auxillaryZQubits);
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            EncodeIntoBitFlipCode.Apply((data, auxillaryXQubits?.Slice(new Range(0L, 1L))));
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            EncodeIntoBitFlipCode.Apply((auxillaryZQubits[0L], auxillaryXQubits?.Slice(new Range(2L, 3L))));
#line 79 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            EncodeIntoBitFlipCode.Apply((auxillaryZQubits[1L], auxillaryXQubits?.Slice(new Range(4L, 5L))));
            // ApplyToEachA(CNOT(data, _), auxillaryXQubits[0..1]);
            // ApplyToEachA(CNOT(auxillaryZQubits[0], _), auxillaryXQubits[2..3]);
            // ApplyToEachA(CNOT(auxillaryZQubits[1], _), auxillaryXQubits[4..5]);
            ;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (data,auxillaryZQubits,auxillaryXQubits) = __in;
            // ApplyToEachA(CNOT(data, _), auxillaryZQubits);
            // ApplyToEachA(H, [data] + auxillaryZQubits);
            // ApplyToEachA(CNOT(data, _), auxillaryXQubits[0..1]);
            // ApplyToEachA(CNOT(auxillaryZQubits[0], _), auxillaryXQubits[2..3]);
            // ApplyToEachA(CNOT(auxillaryZQubits[1], _), auxillaryXQubits[4..5]);
            EncodeIntoBitFlipCode.Adjoint.Apply((auxillaryZQubits[1L], auxillaryXQubits?.Slice(new Range(4L, 5L))));
            EncodeIntoBitFlipCode.Adjoint.Apply((auxillaryZQubits[0L], auxillaryXQubits?.Slice(new Range(2L, 3L))));
            EncodeIntoBitFlipCode.Adjoint.Apply((data, auxillaryXQubits?.Slice(new Range(0L, 1L))));
            EncodePhaseFlipCode.Adjoint.Apply((data, auxillaryZQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.EncodeIntoBitFlipCode = this.Factory.Get<IUnitary<(Qubit,QArray<Qubit>)>>(typeof(HW5p2.EncodeIntoBitFlipCode));
            this.EncodePhaseFlipCode = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(HW5p2.EncodePhaseFlipCode));
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

        protected ICallable<QArray<Qubit>, QVoid> P1Solution
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> P2BlockSolution
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
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var register = Allocate.Apply(9L);
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var data = register[0L];
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var auxillaryZQubits = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>(3L, 6L), register));
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            var auxillaryXQubits = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>(1L, 2L, 4L, 5L, 7L, 8L), register));
#line 97 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            EncodeShorFlipCode.Apply((data, auxillaryZQubits, auxillaryXQubits));
            // for (i in 0..8) {
            //     Message($"{i}");
            //     Assert([PauliZ], [register[i]], Zero, "Not Zero");
            // }
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            errorize.Apply(register);
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            P1Solution.Apply((new QArray<Qubit>()
            {data} + auxillaryXQubits?.Slice(new Range(0L, 1L))));
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            P1Solution.Apply((new QArray<Qubit>()
            {auxillaryZQubits[0L]} + auxillaryXQubits?.Slice(new Range(2L, 3L))));
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            P1Solution.Apply((new QArray<Qubit>()
            {auxillaryZQubits[1L]} + auxillaryXQubits?.Slice(new Range(4L, 5L))));
#line 109 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            P2BlockSolution.Apply(register);
#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            EncodeShorFlipCode.Adjoint.Apply((data, auxillaryZQubits, auxillaryXQubits));
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            Assert.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {data}, Result.Zero, "Didn't return to Zero"));
            // for (i in 0..8) {
            //     Message($"{i}");
            //     Assert([PauliZ], [register[i]], Zero, "Didn't return to Zero");
            // }
            ;
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
            this.P1Solution = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW5p2.P1Solution));
            this.P2BlockSolution = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW5p2.P2BlockSolution));
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
#line 123 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            foreach (var i in new Range(0L, (paulis.Count - 1L)))
            {
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
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
#line 131 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
            foreach (var b in new Range(0L, 8L))
            {
#line 132 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                foreach (var i in new Range(0L, 3L))
                {
#line 133 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                    foreach (var j in new Range(0L, 3L))
                    {
                        // if (i != 2 && j != 2) {
#line 135 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        var paulis1 = new QArray<Int64>(9L);
#line 136 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        var paulis2 = new QArray<Int64>(9L);
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        paulis1[b] = i;
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        paulis2[b] = j;
#line 139 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        Message.Apply($"{paulis1}");
#line 140 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        Message.Apply($"{paulis2}");
#line 141 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        Message.Apply("");
#line 143 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        var op1 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg1) => (MicrosoftQuantumCanonIntsToPaulis.Apply(paulis1), _arg1)));
#line 144 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        var op2 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg2) => (MicrosoftQuantumCanonIntsToPaulis.Apply(paulis2), _arg2)));
#line 146 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem3.qs"
                        TestP3Solution.Apply(((ICallable)ApplyMultiPauli.Partial(new Func<QArray<Qubit>, (QArray<ICallable>,QArray<Qubit>)>((_arg3) => (new QArray<ICallable>(op1, op2), _arg3)))));
                        // }
                        ;
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
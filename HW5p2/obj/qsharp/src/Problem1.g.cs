#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW5p2", "P1Solution (code : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs", 186L, 7L, 46L)]
[assembly: OperationDeclaration("HW5p2", "TestP1Solution (errorize : (Qubit[] => ())) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs", 1283L, 42L, 5L)]
[assembly: OperationDeclaration("HW5p2", "TestAllThreeBitFlips () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs", 1971L, 65L, 42L)]
#line hidden
namespace HW5p2
{
    public class P1Solution : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public P1Solution(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "P1Solution";
        String ICallable.FullName => "HW5p2.P1Solution";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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
#line 9 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var workQubits = Allocate.Apply(2L);
#line 10 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((code[0L], workQubits[0L]));
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((code[1L], workQubits[0L]));
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((code[1L], workQubits[1L]));
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((code[2L], workQubits[1L]));
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var result1 = M.Apply(workQubits[0L]);
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var result2 = M.Apply(workQubits[1L]);
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            if ((result1 == Result.Zero))
            {
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                if ((result2 == Result.Zero))
                {
#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                    Message.Apply("{|000>, |111>}");
                }
                else
                {
#line 23 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                    Message.Apply("{|001>, |110>}");
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                    MicrosoftQuantumPrimitiveX.Apply(code[2L]);
                }
            }
            else
            {
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                if ((result2 == Result.Zero))
                {
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                    Message.Apply("{|100>, |011>}");
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                    MicrosoftQuantumPrimitiveX.Apply(code[0L]);
                }
                else
                {
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                    Message.Apply("{|010>, |101>}");
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
                    MicrosoftQuantumPrimitiveX.Apply(code[1L]);
                }
            }

#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            ResetAll.Apply(workQubits);
#line hidden
            Release.Apply(workQubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
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
            return __m__.Run<P1Solution, QArray<Qubit>, QVoid>(code);
        }
    }

    public class TestP1Solution : Operation<ICallable, QVoid>, ICallable
    {
        public TestP1Solution(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestP1Solution";
        String ICallable.FullName => "HW5p2.TestP1Solution";
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

        protected ICallable<QVoid, Microsoft.Quantum.Canon.QECC> MicrosoftQuantumCanonBitFlipCode
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> P1Solution
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get;
            set;
        }

        public override Func<ICallable, QVoid> Body => (__in) =>
        {
            var errorize = __in;
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var (encoder,decoder,synd) = MicrosoftQuantumCanonBitFlipCode.Apply(QVoid.Instance);
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var register = Allocate.Apply(3L);
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var data = register[0L];
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var auxillaryQubits = register?.Slice(new Range(1L, 2L));
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            MicrosoftQuantumPrimitiveRx.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), data));
            // test state
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var code = encoder.Apply<Microsoft.Quantum.Canon.LogicalRegister>((new QArray<Qubit>()
            {data}, auxillaryQubits));
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            errorize.Apply(code);
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            P1Solution.Apply(code);
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var (decodedData,decodedAuxillary) = decoder.Apply<(QArray<Qubit>,QArray<Qubit>)>(code);
#line 59 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            MicrosoftQuantumPrimitiveRx.Adjoint.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), data));
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            Assert.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {data}, Result.Zero, "Didn't return to |0〉"));
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
            this.MicrosoftQuantumCanonBitFlipCode = this.Factory.Get<ICallable<QVoid, Microsoft.Quantum.Canon.QECC>>(typeof(Microsoft.Quantum.Canon.BitFlipCode));
            this.P1Solution = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW5p2.P1Solution));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveRx = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rx));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable errorize)
        {
            return __m__.Run<TestP1Solution, ICallable, QVoid>(errorize);
        }
    }

    public class TestAllThreeBitFlips : Operation<QVoid, QVoid>, ICallable
    {
        public TestAllThreeBitFlips(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestAllThreeBitFlips";
        String ICallable.FullName => "HW5p2.TestAllThreeBitFlips";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauli
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TestP1Solution
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var X0 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg1) => (new QArray<Pauli>(Pauli.PauliX, Pauli.PauliI, Pauli.PauliI), _arg1)));
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var X1 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg2) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliI), _arg2)));
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            var X2 = MicrosoftQuantumCanonApplyPauli.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,QArray<Qubit>)>((_arg3) => (new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliX), _arg3)));
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            TestP1Solution.Apply(((ICallable)X0));
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            TestP1Solution.Apply(((ICallable)X1));
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW5p2/Problem1.qs"
            TestP1Solution.Apply(((ICallable)X2));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.TestP1Solution = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(HW5p2.TestP1Solution));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestAllThreeBitFlips, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
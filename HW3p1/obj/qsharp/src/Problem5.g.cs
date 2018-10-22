#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p1", "Toffoli (a : Qubit, b : Qubit, c : Qubit) : ()", new string[] { "Controlled" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 169L, 7L, 57L)]
[assembly: OperationDeclaration("HW3p1", "SubtractBit (t1 : Qubit, t2 : Qubit, borrowIn : Qubit, borrowOut : Qubit) : ()", new string[] { "Controlled" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 730L, 27L, 88L)]
[assembly: OperationDeclaration("HW3p1", "Subtractor (start : Qubit[], amount : Qubit[], borrows : Qubit[]) : ()", new string[] { "Controlled" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 1279L, 45L, 81L)]
[assembly: OperationDeclaration("HW3p1", "TestSubtracter (length : Int, rPow : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 2259L, 67L, 58L)]
#line hidden
namespace HW3p1
{
    public class Toffoli : Controllable<(Qubit,Qubit,Qubit)>, ICallable
    {
        public Toffoli(IOperationFactory m) : base(m)
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

        String ICallable.Name => "Toffoli";
        String ICallable.FullName => "HW3p1.Toffoli";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (a,b,c) = __in;
#line 9 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(a, b), c));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(a,b,c)) = __in;
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>(a, b), c)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit a, Qubit b, Qubit c)
        {
            return __m__.Run<Toffoli, (Qubit,Qubit,Qubit), QVoid>((a, b, c));
        }
    }

    public class SubtractBit : Controllable<(Qubit,Qubit,Qubit,Qubit)>, ICallable
    {
        public SubtractBit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                    yield return Data.Item4;
                }
            }
        }

        String ICallable.Name => "SubtractBit";
        String ICallable.FullName => "HW3p1.SubtractBit";
        protected IControllable MicrosoftQuantumCanonApplyToEachC
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IControllable<(Qubit,Qubit,Qubit)> Toffoli
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (t1,t2,borrowIn,borrowOut) = __in;
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            Assert.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Carry out is not in |0> state"));
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveX.Apply(t1);
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            Toffoli.Apply((t1, t2, borrowOut));
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            Toffoli.Apply((t1, borrowIn, borrowOut));
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            Toffoli.Apply((t2, borrowIn, borrowOut));
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveX.Apply(t1);
            // let m4 = M(borrowOut);
            // Message($"borrowOut: {m4}");
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonApplyToEachC.Apply((((IControllable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1)))), new QArray<Qubit>(t2, borrowIn)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(t1,t2,borrowIn,borrowOut)) = __in;
            Assert.Controlled.Apply((controlQubits, (new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Carry out is not in |0> state")));
            MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, t1));
            Toffoli.Controlled.Apply((controlQubits, (t1, t2, borrowOut)));
            Toffoli.Controlled.Apply((controlQubits, (t1, borrowIn, borrowOut)));
            Toffoli.Controlled.Apply((controlQubits, (t2, borrowIn, borrowOut)));
            MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, t1));
            // let m4 = M(borrowOut);
            // Message($"borrowOut: {m4}");
            MicrosoftQuantumCanonApplyToEachC.Controlled.Apply((controlQubits, (((IControllable)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1)))), new QArray<Qubit>(t2, borrowIn))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachC = this.Factory.Get<IControllable>(typeof(Microsoft.Quantum.Canon.ApplyToEachC<>));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Toffoli = this.Factory.Get<IControllable<(Qubit,Qubit,Qubit)>>(typeof(HW3p1.Toffoli));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit t1, Qubit t2, Qubit borrowIn, Qubit borrowOut)
        {
            return __m__.Run<SubtractBit, (Qubit,Qubit,Qubit,Qubit), QVoid>((t1, t2, borrowIn, borrowOut));
        }
    }

    public class Subtractor : Controllable<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public Subtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Subtractor";
        String ICallable.FullName => "HW3p1.Subtractor";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IControllable<(Qubit,Qubit,Qubit,Qubit)> SubtractBit
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (start,amount,borrows) = __in;
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Count >= amount.Count), true, $"unequal operand lengths"));
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Count + 1L), borrows.Count, $"not right amount of borrows"));
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var padding = Allocate.Apply(1L);
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var j in new Range((start.Count - 1L), -(1L), 0L))
            {
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var amountBit = padding[0L];
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                if ((j >= (start.Count - amount.Count)))
                {
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    amountBit = amount[((j - start.Count) + amount.Count)];
                }

                // let m1 = M(start[j]);
                // let m2 = M(amountBit);
                // let m3 = M(borrows[j+1]);
                // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                SubtractBit.Apply((start[j], amountBit, borrows[(j + 1L)], borrows[j]));
            }

#line hidden
            Release.Apply(padding);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(start,amount,borrows)) = __in;
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Count >= amount.Count), true, $"unequal operand lengths"));
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Count + 1L), borrows.Count, $"not right amount of borrows"));
            var padding = Allocate.Apply(1L);
            foreach (var j in new Range((start.Count - 1L), -(1L), 0L))
            {
                var amountBit = padding[0L];
                if ((j >= (start.Count - amount.Count)))
                {
                    amountBit = amount[((j - start.Count) + amount.Count)];
                }

                // let m1 = M(start[j]);
                // let m2 = M(amountBit);
                // let m3 = M(borrows[j+1]);
                // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
                SubtractBit.Controlled.Apply((controlQubits, (start[j], amountBit, borrows[(j + 1L)], borrows[j])));
            }

#line hidden
            Release.Apply(padding);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.SubtractBit = this.Factory.Get<IControllable<(Qubit,Qubit,Qubit,Qubit)>>(typeof(HW3p1.SubtractBit));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, QArray<Qubit> amount, QArray<Qubit> borrows)
        {
            return __m__.Run<Subtractor, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid>((start, amount, borrows));
        }
    }

    public class TestSubtracter : Operation<(Int64,Int64), QVoid>, ICallable
    {
        public TestSubtracter(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestSubtracter";
        String ICallable.FullName => "HW3p1.TestSubtracter";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<QArray<Int64>>> UtilsGenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonHead
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> UtilsQubitsToInt
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

        protected ICallable<(QArray<Qubit>,QArray<Int64>), QVoid> UtilsSetQubits
        {
            get;
            set;
        }

        protected IControllable<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> Subtractor
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QVoid> Body => (__in) =>
        {
            var (length,rPow) = __in;
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rInt = 2L.Pow(rPow);
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rLength = MicrosoftQuantumCanonBitSize.Apply(rInt);
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rLastIndex = (rLength - 1L);
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var regLastIndex = (rLastIndex + length);
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var borrowsLastIndex = ((regLastIndex + length) + 1L);
#line 75 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var qubits = Allocate.Apply((borrowsLastIndex + 1L));
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var binaries = UtilsGenerateAllBinariesOfLength.Apply(7L);
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var i in new Range(0L, (binaries.Count - 1L)))
            {
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                Message.Apply($"start: {i}:");
#line 79 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var binary = binaries[i];
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var r = qubits?.Slice(new Range(0L, rLastIndex));
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var register = qubits?.Slice(new Range((rLastIndex + 1L), regLastIndex));
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var borrows = qubits?.Slice(new Range((regLastIndex + 1L), borrowsLastIndex));
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                UtilsSetQubits.Apply((register, binary));
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                MicrosoftQuantumPrimitiveX.Apply(MicrosoftQuantumCanonHead.Apply<Qubit>(r));
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                if ((UtilsQubitsToInt.Apply(register) >= rInt))
                {
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    Subtractor.Apply((register, r, borrows));
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var trueAnswer = (i - rInt);
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var answer = UtilsQubitsToInt.Apply(register);
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    MicrosoftQuantumCanonAssertIntEqual.Apply((trueAnswer, answer, $"Not equal. true: {trueAnswer}, calculated: {answer}"));
                }

#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                Message.Apply("");
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
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
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.UtilsGenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(Utils.GenerateAllBinariesOfLength));
            this.MicrosoftQuantumCanonHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Head<>));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.UtilsQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.QubitsToInt));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.UtilsSetQubits = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Int64>), QVoid>>(typeof(Utils.SetQubits));
            this.Subtractor = this.Factory.Get<IControllable<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.Subtractor));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length, Int64 rPow)
        {
            return __m__.Run<TestSubtracter, (Int64,Int64), QVoid>((length, rPow));
        }
    }
}
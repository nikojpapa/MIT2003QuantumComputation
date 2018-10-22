#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p1", "_SubtractBit (t1 : Qubit, t2 : Qubit, borrowIn : Qubit, borrowOut : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 249L, 8L, 89L)]
[assembly: OperationDeclaration("HW3p1", "Subtractor (start : Qubit[], amount : Qubit[], borrows : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 856L, 28L, 81L)]
[assembly: OperationDeclaration("HW3p1", "TestSubtractor (length : Int, rPow : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 1959L, 53L, 58L)]
[assembly: OperationDeclaration("HW3p1", "XIfLessThan (a : Qubit[], b : Qubit[], target : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 3346L, 87L, 70L)]
[assembly: OperationDeclaration("HW3p1", "TestXIfLessThan (length : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 3692L, 100L, 48L)]
#line hidden
namespace HW3p1
{
    public class _SubtractBit : Unitary<(Qubit,Qubit,Qubit,Qubit)>, ICallable
    {
        public _SubtractBit(IOperationFactory m) : base(m)
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

        String ICallable.Name => "_SubtractBit";
        String ICallable.FullName => "HW3p1._SubtractBit";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
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

        protected IUnitary<(Qubit,Qubit,Qubit)> UtilsToffoli
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
#line 10 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            Assert.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Carry out is not in |0> state"));
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveX.Apply(t1);
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            UtilsToffoli.Apply((t1, t2, borrowOut));
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            UtilsToffoli.Apply((t1, borrowIn, borrowOut));
#line 15 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            UtilsToffoli.Apply((t2, borrowIn, borrowOut));
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveX.Apply(t1);
            // let m4 = M(borrowOut);
            // Message($"borrowOut: {m4}");
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1)))), new QArray<Qubit>(t2, borrowIn)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (t1,t2,borrowIn,borrowOut) = __in;
            // let m4 = M(borrowOut);
            // Message($"borrowOut: {m4}");
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1)))), new QArray<Qubit>(t2, borrowIn)));
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(t1);
            UtilsToffoli.Adjoint.Apply((t2, borrowIn, borrowOut));
            UtilsToffoli.Adjoint.Apply((t1, borrowIn, borrowOut));
            UtilsToffoli.Adjoint.Apply((t1, t2, borrowOut));
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(t1);
            Assert.Adjoint.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Carry out is not in |0> state"));
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
            UtilsToffoli.Controlled.Apply((controlQubits, (t1, t2, borrowOut)));
            UtilsToffoli.Controlled.Apply((controlQubits, (t1, borrowIn, borrowOut)));
            UtilsToffoli.Controlled.Apply((controlQubits, (t2, borrowIn, borrowOut)));
            MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, t1));
            // let m4 = M(borrowOut);
            // Message($"borrowOut: {m4}");
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1)))), new QArray<Qubit>(t2, borrowIn))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(t1,t2,borrowIn,borrowOut)) = __in;
            // let m4 = M(borrowOut);
            // Message($"borrowOut: {m4}");
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveCNOT.Partial(new Func<Qubit, (Qubit,Qubit)>((_arg1) => (_arg1, t1)))), new QArray<Qubit>(t2, borrowIn))));
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, t1));
            UtilsToffoli.Adjoint.Controlled.Apply((controlQubits, (t2, borrowIn, borrowOut)));
            UtilsToffoli.Adjoint.Controlled.Apply((controlQubits, (t1, borrowIn, borrowOut)));
            UtilsToffoli.Adjoint.Controlled.Apply((controlQubits, (t1, t2, borrowOut)));
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, t1));
            Assert.Adjoint.Controlled.Apply((controlQubits, (new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Carry out is not in |0> state")));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.UtilsToffoli = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Utils.Toffoli));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit t1, Qubit t2, Qubit borrowIn, Qubit borrowOut)
        {
            return __m__.Run<_SubtractBit, (Qubit,Qubit,Qubit,Qubit), QVoid>((t1, t2, borrowIn, borrowOut));
        }
    }

    public class Subtractor : Unitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, ICallable
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

        protected IUnitary<(Qubit,Qubit,Qubit,Qubit)> _SubtractBit
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (start,amount,borrows) = __in;
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Count >= amount.Count), true, $"unequal operand lengths"));
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Count + 1L), borrows.Count, $"not right amount of borrows"));
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var padding = Allocate.Apply(1L);
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var j in new Range((start.Count - 1L), -(1L), 0L))
            {
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                if ((j >= (start.Count - amount.Count)))
                {
                    // cannot use set to determine amount bit
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    _SubtractBit.Apply((start[j], amount[((j - start.Count) + amount.Count)], borrows[(j + 1L)], borrows[j]));
                }
                else
                {
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    _SubtractBit.Apply((start[j], padding[0L], borrows[(j + 1L)], borrows[j]));
                }

                // let m1 = M(start[j]);
                // let m2 = M(amountBit);
                // let m3 = M(borrows[j+1]);
                // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
                ;
            }

#line hidden
            Release.Apply(padding);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount,borrows) = __in;
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Count >= amount.Count), true, $"unequal operand lengths"));
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Count + 1L), borrows.Count, $"not right amount of borrows"));
            var padding = Allocate.Apply(1L);
            foreach (var j in new Range(((start.Count - 1L) - (((0L - (start.Count - 1L)) / -(1L)) * -(-(1L)))), -(-(1L)), (start.Count - 1L)))
            {
                // let m1 = M(start[j]);
                // let m2 = M(amountBit);
                // let m3 = M(borrows[j+1]);
                // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
                if ((j >= (start.Count - amount.Count)))
                {
                    // cannot use set to determine amount bit
                    _SubtractBit.Adjoint.Apply((start[j], amount[((j - start.Count) + amount.Count)], borrows[(j + 1L)], borrows[j]));
                }
                else
                {
                    _SubtractBit.Adjoint.Apply((start[j], padding[0L], borrows[(j + 1L)], borrows[j]));
                }
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
                if ((j >= (start.Count - amount.Count)))
                {
                    // cannot use set to determine amount bit
                    _SubtractBit.Controlled.Apply((controlQubits, (start[j], amount[((j - start.Count) + amount.Count)], borrows[(j + 1L)], borrows[j])));
                }
                else
                {
                    _SubtractBit.Controlled.Apply((controlQubits, (start[j], padding[0L], borrows[(j + 1L)], borrows[j])));
                }

                // let m1 = M(start[j]);
                // let m2 = M(amountBit);
                // let m3 = M(borrows[j+1]);
                // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
                ;
            }

#line hidden
            Release.Apply(padding);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(start,amount,borrows)) = __in;
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Count >= amount.Count), true, $"unequal operand lengths"));
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Count + 1L), borrows.Count, $"not right amount of borrows"));
            var padding = Allocate.Apply(1L);
            foreach (var j in new Range(((start.Count - 1L) - (((0L - (start.Count - 1L)) / -(1L)) * -(-(1L)))), -(-(1L)), (start.Count - 1L)))
            {
                // let m1 = M(start[j]);
                // let m2 = M(amountBit);
                // let m3 = M(borrows[j+1]);
                // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
                if ((j >= (start.Count - amount.Count)))
                {
                    // cannot use set to determine amount bit
                    _SubtractBit.Adjoint.Controlled.Apply((controlQubits, (start[j], amount[((j - start.Count) + amount.Count)], borrows[(j + 1L)], borrows[j])));
                }
                else
                {
                    _SubtractBit.Adjoint.Controlled.Apply((controlQubits, (start[j], padding[0L], borrows[(j + 1L)], borrows[j])));
                }
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
            this._SubtractBit = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit,Qubit)>>(typeof(HW3p1._SubtractBit));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, QArray<Qubit> amount, QArray<Qubit> borrows)
        {
            return __m__.Run<Subtractor, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid>((start, amount, borrows));
        }
    }

    public class TestSubtractor : Operation<(Int64,Int64), QVoid>, ICallable
    {
        public TestSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestSubtractor";
        String ICallable.FullName => "HW3p1.TestSubtractor";
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

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> Subtractor
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
#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var binaries = UtilsGenerateAllBinariesOfLength.Apply(length);
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rInt = 2L.Pow(rPow);
#line 57 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rLength = MicrosoftQuantumCanonBitSize.Apply(rInt);
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rLastIndex = (rLength - 1L);
#line 59 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var regLastIndex = (rLastIndex + length);
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var borrowsLastIndex = ((regLastIndex + length) + 1L);
#line 62 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var qubits = Allocate.Apply((borrowsLastIndex + 1L));
#line 63 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var i in new Range(0L, (binaries.Count - 1L)))
            {
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                Message.Apply($"start: {i}:");
#line 65 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var binary = binaries[i];
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var r = qubits?.Slice(new Range(0L, rLastIndex));
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var register = qubits?.Slice(new Range((rLastIndex + 1L), regLastIndex));
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var borrows = qubits?.Slice(new Range((regLastIndex + 1L), borrowsLastIndex));
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                UtilsSetQubits.Apply((register, binary));
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                MicrosoftQuantumPrimitiveX.Apply(MicrosoftQuantumCanonHead.Apply<Qubit>(r));
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                if ((UtilsQubitsToInt.Apply(register) >= rInt))
                {
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    Subtractor.Apply((register, r, borrows));
#line 75 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var trueAnswer = (i - rInt);
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var answer = UtilsQubitsToInt.Apply(register);
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    MicrosoftQuantumCanonAssertIntEqual.Apply((trueAnswer, answer, $"Not equal. true: {trueAnswer}, calculated: {answer}"));
                }

#line 79 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                Message.Apply("");
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
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
            this.Subtractor = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.Subtractor));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length, Int64 rPow)
        {
            return __m__.Run<TestSubtractor, (Int64,Int64), QVoid>((length, rPow));
        }
    }

    public class XIfLessThan : Operation<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public XIfLessThan(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "XIfLessThan";
        String ICallable.FullName => "HW3p1.XIfLessThan";
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

        protected ICallable MicrosoftQuantumCanonHead
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> Subtractor
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (a,b,target) = __in;
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var borrows = Allocate.Apply((a.Count + 1L));
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            Subtractor.Apply((a, b, borrows));
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((indicator, target));
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            Subtractor.Adjoint.Apply((a, b, borrows));
#line hidden
            Release.Apply(borrows);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumCanonHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Head<>));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Subtractor = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.Subtractor));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a, QArray<Qubit> b, Qubit target)
        {
            return __m__.Run<XIfLessThan, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((a, b, target));
        }
    }

    public class TestXIfLessThan : Operation<Int64, QVoid>, ICallable
    {
        public TestXIfLessThan(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestXIfLessThan";
        String ICallable.FullName => "HW3p1.TestXIfLessThan";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Result,Result,String), QVoid> MicrosoftQuantumCanonAssertResultEqual
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<QArray<Int64>>> UtilsGenerateAllBinariesOfLength
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

        protected ICallable<Boolean, Result> MicrosoftQuantumCanonResultFromBool
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Int64>), QVoid> UtilsSetQubits
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> XIfLessThan
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var length = __in;
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var binaries = UtilsGenerateAllBinariesOfLength.Apply(length);
#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var qubits = Allocate.Apply(((length * 2L) + 1L));
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var i in new Range(0L, (binaries.Count - 1L)))
            {
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                foreach (var j in new Range(0L, (binaries.Count - 1L)))
                {
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var binaryA = binaries[i];
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var binaryB = binaries[j];
#line 109 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var a = qubits?.Slice(new Range(0L, (length - 1L)));
#line 110 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var b = qubits?.Slice(new Range(length, ((length * 2L) - 1L)));
#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var target = MicrosoftQuantumCanonTail.Apply<Qubit>(qubits);
#line 113 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    UtilsSetQubits.Apply((a, binaryA));
#line 114 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    UtilsSetQubits.Apply((b, binaryB));
#line 116 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    XIfLessThan.Apply((a, b, target));
#line 118 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var mt = M.Apply(target);
#line 119 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    var lessThan = (i < j);
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    Message.Apply($"{i} < {j}: {lessThan}; result: {mt}");
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    MicrosoftQuantumCanonAssertResultEqual.Apply((M.Apply(target), MicrosoftQuantumCanonResultFromBool.Apply((i < j)), "Incorrect"));
#line 123 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    ResetAll.Apply(qubits);
                }
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
            this.MicrosoftQuantumCanonAssertResultEqual = this.Factory.Get<ICallable<(Result,Result,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertResultEqual));
            this.UtilsGenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(Utils.GenerateAllBinariesOfLength));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonResultFromBool = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Canon.ResultFromBool));
            this.UtilsSetQubits = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Int64>), QVoid>>(typeof(Utils.SetQubits));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.XIfLessThan = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>>(typeof(HW3p1.XIfLessThan));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<TestXIfLessThan, Int64, QVoid>(length);
        }
    }
}
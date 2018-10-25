#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p1", "_SubtractBit (t1 : Qubit, t2 : Qubit, borrowIn : Qubit, borrowOut : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 249L, 8L, 89L)]
[assembly: OperationDeclaration("HW3p1", "BitSubtractor (start : Qubit[], amount : Qubit[], borrows : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 858L, 27L, 84L)]
[assembly: OperationDeclaration("HW3p1", "TestSubtractor (length : Int, rPow : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 1912L, 53L, 58L)]
[assembly: OperationDeclaration("HW3p1", "QFTSubtractor (start : Qubit[], amount : Int) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 3294L, 87L, 62L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTSubtractorImpl (start : Qubit[], maxR : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 3668L, 100L, 69L)]
[assembly: OperationDeclaration("HW3p1", "TestQFTSubtractor (length : Int, maxR : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 4241L, 115L, 61L)]
[assembly: OperationDeclaration("HW3p1", "XIfLessThan (a : Qubit[], b : Qubit[], target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 4429L, 121L, 70L)]
[assembly: OperationDeclaration("HW3p1", "SubtractIfPossible (a : Qubit[], b : Qubit[], bVal : Int, ancilla : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 7036L, 195L, 89L)]
[assembly: OperationDeclaration("HW3p1", "PeriodicFunction (x : Qubit[], period : Int, target : Qubit, maxDivisions : Int) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 7383L, 207L, 95L)]
[assembly: OperationDeclaration("HW3p1", "_TestPeriodicFunctionImpl (a : Qubit[], b : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 9070L, 252L, 69L)]
[assembly: OperationDeclaration("HW3p1", "TestPeriodicFunction (length : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 9921L, 275L, 53L)]
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
            {borrowOut}, Result.Zero, "Borrow out is not in |0> state"));
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
            {borrowOut}, Result.Zero, "Borrow out is not in |0> state"));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(t1,t2,borrowIn,borrowOut)) = __in;
            Assert.Controlled.Apply((controlQubits, (new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {borrowOut}, Result.Zero, "Borrow out is not in |0> state")));
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
            {borrowOut}, Result.Zero, "Borrow out is not in |0> state")));
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

    public class BitSubtractor : Unitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public BitSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "BitSubtractor";
        String ICallable.FullName => "HW3p1.BitSubtractor";
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
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonAssertBoolEqual.Apply(((start.Count >= amount.Count), true, $"unequal operand lengths"));
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply(((start.Count + 1L), borrows.Count, $"not right amount of borrows"));
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var padding = Allocate.Apply(1L);
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var j in new Range((start.Count - 1L), -(1L), 0L))
            {
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((_arg1) => (start[j], _arg1, borrows[(j + 1L)], borrows[j])));
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                if ((j >= (start.Count - amount.Count)))
                {
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    sop.Apply(amount[((j - start.Count) + amount.Count)]);
                }
                else
                {
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                    sop.Apply(padding[0L]);
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
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((_arg1) => (start[j], _arg1, borrows[(j + 1L)], borrows[j])));
                // let m1 = M(start[j]);
                // let m2 = M(amountBit);
                // let m3 = M(borrows[j+1]);
                // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
                if ((j >= (start.Count - amount.Count)))
                {
                    sop.Adjoint.Apply(amount[((j - start.Count) + amount.Count)]);
                }
                else
                {
                    sop.Adjoint.Apply(padding[0L]);
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
                var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((_arg1) => (start[j], _arg1, borrows[(j + 1L)], borrows[j])));
                if ((j >= (start.Count - amount.Count)))
                {
                    sop.Controlled.Apply((controlQubits, amount[((j - start.Count) + amount.Count)]));
                }
                else
                {
                    sop.Controlled.Apply((controlQubits, padding[0L]));
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
                var sop = _SubtractBit.Partial(new Func<Qubit, (Qubit,Qubit,Qubit,Qubit)>((_arg1) => (start[j], _arg1, borrows[(j + 1L)], borrows[j])));
                // let m1 = M(start[j]);
                // let m2 = M(amountBit);
                // let m3 = M(borrows[j+1]);
                // Message($"start: {m1}, amount: {m2}, borrowIn: {m3}");
                if ((j >= (start.Count - amount.Count)))
                {
                    sop.Adjoint.Controlled.Apply((controlQubits, amount[((j - start.Count) + amount.Count)]));
                }
                else
                {
                    sop.Adjoint.Controlled.Apply((controlQubits, padding[0L]));
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
            return __m__.Run<BitSubtractor, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid>((start, amount, borrows));
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

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> BitSubtractor
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

        protected IUnitary<(QArray<Qubit>,QArray<Int64>)> UtilsSetQubits
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
                    BitSubtractor.Apply((register, r, borrows));
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
            this.BitSubtractor = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.BitSubtractor));
            this.UtilsGenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(Utils.GenerateAllBinariesOfLength));
            this.MicrosoftQuantumCanonHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Head<>));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.UtilsQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.QubitsToInt));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.UtilsSetQubits = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>)>>(typeof(Utils.SetQubits));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length, Int64 rPow)
        {
            return __m__.Run<TestSubtractor, (Int64,Int64), QVoid>((length, rPow));
        }
    }

    public class QFTSubtractor : Unitary<(QArray<Qubit>,Int64)>, ICallable
    {
        public QFTSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "QFTSubtractor";
        String ICallable.FullName => "HW3p1.QFTSubtractor";
        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonQFT
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (start,amount) = __in;
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2)))), start));
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount) = __in;
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(bigEndian);
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2)))), start));
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(start,amount)) = __in;
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
            MicrosoftQuantumCanonQFT.Controlled.Apply((controlQubits, bigEndian));
            MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2)))), start)));
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((controlQubits, bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(start,amount)) = __in;
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((controlQubits, bigEndian));
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2)))), start)));
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((controlQubits, bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, Int64 amount)
        {
            return __m__.Run<QFTSubtractor, (QArray<Qubit>,Int64), QVoid>((start, amount));
        }
    }

    public class _TestQFTSubtractorImpl : Operation<(QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public _TestQFTSubtractorImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "_TestQFTSubtractorImpl";
        String ICallable.FullName => "HW3p1._TestQFTSubtractorImpl";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumCanonModulus
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Int64)> QFTSubtractor
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> UtilsQubitsToInt
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (start,maxR) = __in;
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var startInt = UtilsQubitsToInt.Apply(start);
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var r in new Range(0L, maxR))
            {
#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                QFTSubtractor.Apply((start, r));
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var ans = UtilsQubitsToInt.Apply(start);
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var realAns = MicrosoftQuantumCanonModulus.Apply(((startInt - r), 2L.Pow(start.Count)));
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                MicrosoftQuantumCanonAssertIntEqual.Apply((ans, realAns, $"{startInt} - {r} == {ans} != {realAns}"));
#line 109 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                Message.Apply($"{startInt} - {r} == {realAns}");
#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                QFTSubtractor.Adjoint.Apply((start, r));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.MicrosoftQuantumCanonModulus = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.Modulus));
            this.QFTSubtractor = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64)>>(typeof(HW3p1.QFTSubtractor));
            this.UtilsQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.QubitsToInt));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, Int64 maxR)
        {
            return __m__.Run<_TestQFTSubtractorImpl, (QArray<Qubit>,Int64), QVoid>((start, maxR));
        }
    }

    public class TestQFTSubtractor : Operation<(Int64,Int64), QVoid>, ICallable
    {
        public TestQFTSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestQFTSubtractor";
        String ICallable.FullName => "HW3p1.TestQFTSubtractor";
        protected ICallable<(Int64,ICallable), QVoid> UtilsRunOnAllBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QVoid> _TestQFTSubtractorImpl
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QVoid> Body => (__in) =>
        {
            var (length,maxR) = __in;
#line 117 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            UtilsRunOnAllBinariesOfLength.Apply((length, ((ICallable)_TestQFTSubtractorImpl.Partial(new Func<QArray<Qubit>, (QArray<Qubit>,Int64)>((_arg1) => (_arg1, maxR))))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.UtilsRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.RunOnAllBinariesOfLength));
            this._TestQFTSubtractorImpl = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(HW3p1._TestQFTSubtractorImpl));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length, Int64 maxR)
        {
            return __m__.Run<TestQFTSubtractor, (Int64,Int64), QVoid>((length, maxR));
        }
    }

    public class XIfLessThan : Unitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
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

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> BitSubtractor
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

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (a,b,target) = __in;
#line 123 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var borrows = Allocate.Apply((a.Count + 1L));
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            BitSubtractor.Apply((a, b, borrows));
#line 126 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
#line 127 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((indicator, target));
#line 129 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            BitSubtractor.Adjoint.Apply((a, b, borrows));
#line hidden
            Release.Apply(borrows);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (a,b,target) = __in;
            var borrows = Allocate.Apply((a.Count + 1L));
#line 126 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
            BitSubtractor.Adjoint.Adjoint.Apply((a, b, borrows));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((indicator, target));
            BitSubtractor.Adjoint.Apply((a, b, borrows));
#line hidden
            Release.Apply(borrows);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(a,b,target)) = __in;
            var borrows = Allocate.Apply((a.Count + 1L));
            BitSubtractor.Controlled.Apply((controlQubits, (a, b, borrows)));
            var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
            MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((controlQubits, (indicator, target)));
            BitSubtractor.Adjoint.Controlled.Apply((controlQubits, (a, b, borrows)));
#line hidden
            Release.Apply(borrows);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(a,b,target)) = __in;
            var borrows = Allocate.Apply((a.Count + 1L));
            var indicator = MicrosoftQuantumCanonHead.Apply<Qubit>(borrows);
            BitSubtractor.Adjoint.Adjoint.Controlled.Apply((controlQubits, (a, b, borrows)));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((controlQubits, (indicator, target)));
            BitSubtractor.Adjoint.Controlled.Apply((controlQubits, (a, b, borrows)));
#line hidden
            Release.Apply(borrows);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.BitSubtractor = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.BitSubtractor));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumCanonHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Head<>));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a, QArray<Qubit> b, Qubit target)
        {
            return __m__.Run<XIfLessThan, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((a, b, target));
        }
    }

    public class SubtractIfPossible : Unitary<(QArray<Qubit>,QArray<Qubit>,Int64,Qubit)>, ICallable
    {
        public SubtractIfPossible(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Int64,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Int64,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "SubtractIfPossible";
        String ICallable.FullName => "HW3p1.SubtractIfPossible";
        protected IUnitary<(QArray<Qubit>,Int64)> QFTSubtractor
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)> XIfLessThan
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Int64,Qubit), QVoid> Body => (__in) =>
        {
            var (a,b,bVal,ancilla) = __in;
#line 197 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            XIfLessThan.Apply((a, b, ancilla));
#line 198 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveX.Apply(ancilla);
#line 199 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            QFTSubtractor.Controlled.Apply((new QArray<Qubit>()
            {ancilla}, (a, bVal)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Int64,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (a,b,bVal,ancilla) = __in;
            QFTSubtractor.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {ancilla}, (a, bVal)));
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(ancilla);
            XIfLessThan.Adjoint.Apply((a, b, ancilla));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Int64,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(a,b,bVal,ancilla)) = __in;
            XIfLessThan.Controlled.Apply((controlQubits, (a, b, ancilla)));
            MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, ancilla));
            QFTSubtractor.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {ancilla}, (a, bVal))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Int64,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(a,b,bVal,ancilla)) = __in;
            QFTSubtractor.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {ancilla}, (a, bVal))));
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, ancilla));
            XIfLessThan.Adjoint.Controlled.Apply((controlQubits, (a, b, ancilla)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTSubtractor = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64)>>(typeof(HW3p1.QFTSubtractor));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.XIfLessThan = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(HW3p1.XIfLessThan));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a, QArray<Qubit> b, Int64 bVal, Qubit ancilla)
        {
            return __m__.Run<SubtractIfPossible, (QArray<Qubit>,QArray<Qubit>,Int64,Qubit), QVoid>((a, b, bVal, ancilla));
        }
    }

    public class PeriodicFunction : Unitary<(QArray<Qubit>,Int64,Qubit,Int64)>, ICallable
    {
        public PeriodicFunction(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64,Qubit,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "PeriodicFunction";
        String ICallable.FullName => "HW3p1.PeriodicFunction";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<Int64>> UtilsIntToBinary
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Int64>)> UtilsSetQubits
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Int64,Qubit)> SubtractIfPossible
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64,Qubit,Int64), QVoid> Body => (__in) =>
        {
            var (x,period,target,maxDivisions) = __in;
#line 209 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rBinary = UtilsIntToBinary.Apply(period);
#line 210 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var qubits = Allocate.Apply((rBinary.Count + maxDivisions));
#line 211 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rQubits = qubits?.Slice(new Range(0L, (rBinary.Count - 1L)));
#line 212 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var ancillas = qubits?.Slice(new Range(rBinary.Count, ((rBinary.Count + maxDivisions) - 1L)));
#line 213 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            UtilsSetQubits.Apply((rQubits, rBinary));
#line 215 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var i in new Range(0L, (maxDivisions - 1L)))
            {
#line 216 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                SubtractIfPossible.Apply((x, rQubits, period, ancillas[i]));
            }

#line 219 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveX), x));
#line 220 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((x, target));
#line 221 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveX), x));
#line 223 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var i in new Range(0L, (maxDivisions - 1L)))
            {
#line 224 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                SubtractIfPossible.Adjoint.Apply((x, rQubits, period, ancillas[i]));
            }

#line 227 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            UtilsSetQubits.Adjoint.Apply((rQubits, rBinary));
#line hidden
            Release.Apply(qubits);
            // if (depth > maxDivisions) {
            //     ApplyToEachCA(X, x);
            //     (Controlled X)(x, target);
            //     ApplyToEachCA(X, x);
            // } else {
            //     using(qubits = Qubit[Length(x) + 2]) {
            //         let borrows = Most(qubits);
            //         let ancilla = Tail(qubits);
            //         SubtractIfPossible(x, period, borrows, ancilla);
            //         PeriodicFunction(x, period, target, maxDivisions, depth + 1);
            //         (Adjoint SubtractIfPossible)(x, period, borrows, ancilla);
            //     }
            // }
            ;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64,Qubit,Int64), QVoid> AdjointBody => (__in) =>
        {
            var (x,period,target,maxDivisions) = __in;
#line 209 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rBinary = UtilsIntToBinary.Apply(period);
            // if (depth > maxDivisions) {
            //     ApplyToEachCA(X, x);
            //     (Controlled X)(x, target);
            //     ApplyToEachCA(X, x);
            // } else {
            //     using(qubits = Qubit[Length(x) + 2]) {
            //         let borrows = Most(qubits);
            //         let ancilla = Tail(qubits);
            //         SubtractIfPossible(x, period, borrows, ancilla);
            //         PeriodicFunction(x, period, target, maxDivisions, depth + 1);
            //         (Adjoint SubtractIfPossible)(x, period, borrows, ancilla);
            //     }
            // }
            var qubits = Allocate.Apply((rBinary.Count + maxDivisions));
#line 211 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var rQubits = qubits?.Slice(new Range(0L, (rBinary.Count - 1L)));
#line 212 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var ancillas = qubits?.Slice(new Range(rBinary.Count, ((rBinary.Count + maxDivisions) - 1L)));
            UtilsSetQubits.Adjoint.Adjoint.Apply((rQubits, rBinary));
            foreach (var i in new Range((0L - ((((maxDivisions - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                SubtractIfPossible.Adjoint.Adjoint.Apply((x, rQubits, period, ancillas[i]));
            }

            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveX), x));
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((x, target));
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveX), x));
            foreach (var i in new Range((0L - ((((maxDivisions - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                SubtractIfPossible.Adjoint.Apply((x, rQubits, period, ancillas[i]));
            }

            UtilsSetQubits.Adjoint.Apply((rQubits, rBinary));
#line hidden
            Release.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64,Qubit,Int64)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(x,period,target,maxDivisions)) = __in;
            var rBinary = UtilsIntToBinary.Apply(period);
            var qubits = Allocate.Apply((rBinary.Count + maxDivisions));
            var rQubits = qubits?.Slice(new Range(0L, (rBinary.Count - 1L)));
            var ancillas = qubits?.Slice(new Range(rBinary.Count, ((rBinary.Count + maxDivisions) - 1L)));
            UtilsSetQubits.Controlled.Apply((controlQubits, (rQubits, rBinary)));
            foreach (var i in new Range(0L, (maxDivisions - 1L)))
            {
                SubtractIfPossible.Controlled.Apply((controlQubits, (x, rQubits, period, ancillas[i])));
            }

            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveX), x)));
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((controlQubits, (x, target)));
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveX), x)));
            foreach (var i in new Range(0L, (maxDivisions - 1L)))
            {
                SubtractIfPossible.Adjoint.Controlled.Apply((controlQubits, (x, rQubits, period, ancillas[i])));
            }

            UtilsSetQubits.Adjoint.Controlled.Apply((controlQubits, (rQubits, rBinary)));
#line hidden
            Release.Apply(qubits);
            // if (depth > maxDivisions) {
            //     ApplyToEachCA(X, x);
            //     (Controlled X)(x, target);
            //     ApplyToEachCA(X, x);
            // } else {
            //     using(qubits = Qubit[Length(x) + 2]) {
            //         let borrows = Most(qubits);
            //         let ancilla = Tail(qubits);
            //         SubtractIfPossible(x, period, borrows, ancilla);
            //         PeriodicFunction(x, period, target, maxDivisions, depth + 1);
            //         (Adjoint SubtractIfPossible)(x, period, borrows, ancilla);
            //     }
            // }
            ;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64,Qubit,Int64)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(x,period,target,maxDivisions)) = __in;
            var rBinary = UtilsIntToBinary.Apply(period);
            // if (depth > maxDivisions) {
            //     ApplyToEachCA(X, x);
            //     (Controlled X)(x, target);
            //     ApplyToEachCA(X, x);
            // } else {
            //     using(qubits = Qubit[Length(x) + 2]) {
            //         let borrows = Most(qubits);
            //         let ancilla = Tail(qubits);
            //         SubtractIfPossible(x, period, borrows, ancilla);
            //         PeriodicFunction(x, period, target, maxDivisions, depth + 1);
            //         (Adjoint SubtractIfPossible)(x, period, borrows, ancilla);
            //     }
            // }
            var qubits = Allocate.Apply((rBinary.Count + maxDivisions));
            var rQubits = qubits?.Slice(new Range(0L, (rBinary.Count - 1L)));
            var ancillas = qubits?.Slice(new Range(rBinary.Count, ((rBinary.Count + maxDivisions) - 1L)));
            UtilsSetQubits.Adjoint.Adjoint.Controlled.Apply((controlQubits, (rQubits, rBinary)));
            foreach (var i in new Range((0L - ((((maxDivisions - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                SubtractIfPossible.Adjoint.Adjoint.Controlled.Apply((controlQubits, (x, rQubits, period, ancillas[i])));
            }

            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveX), x)));
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((controlQubits, (x, target)));
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveX), x)));
            foreach (var i in new Range((0L - ((((maxDivisions - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                SubtractIfPossible.Adjoint.Controlled.Apply((controlQubits, (x, rQubits, period, ancillas[i])));
            }

            UtilsSetQubits.Adjoint.Controlled.Apply((controlQubits, (rQubits, rBinary)));
#line hidden
            Release.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.UtilsIntToBinary = this.Factory.Get<ICallable<Int64, QArray<Int64>>>(typeof(Utils.IntToBinary));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.UtilsSetQubits = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Int64>)>>(typeof(Utils.SetQubits));
            this.SubtractIfPossible = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Int64,Qubit)>>(typeof(HW3p1.SubtractIfPossible));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 period, Qubit target, Int64 maxDivisions)
        {
            return __m__.Run<PeriodicFunction, (QArray<Qubit>,Int64,Qubit,Int64), QVoid>((x, period, target, maxDivisions));
        }
    }

    public class _TestPeriodicFunctionImpl : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public _TestPeriodicFunctionImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "_TestPeriodicFunctionImpl";
        String ICallable.FullName => "HW3p1._TestPeriodicFunctionImpl";
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

        protected IUnitary<(QArray<Qubit>,Int64,Qubit,Int64)> PeriodicFunction
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

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<Boolean, Result> MicrosoftQuantumCanonResultFromBool
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (a,b) = __in;
#line 254 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var aVal = UtilsQubitsToInt.Apply(a);
#line 255 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var bVal = UtilsQubitsToInt.Apply(b);
#line 256 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            if (((aVal > 0L) && (bVal > 0L)))
            {
#line 257 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var maxDivisions = (aVal / bVal);
#line 259 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var qubits = Allocate.Apply(1L);
#line 260 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var target = qubits[0L];
#line 261 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                PeriodicFunction.Apply((a, bVal, target, maxDivisions));
#line 263 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var result = M.Apply(target);
#line 264 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var divides = ((aVal >= bVal) && ((aVal % bVal) == 0L));
#line 265 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var resultFromBool = MicrosoftQuantumCanonResultFromBool.Apply(divides);
#line 266 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                Message.Apply($"{bVal} | {aVal}: {divides}({resultFromBool}); result: {result}");
#line 267 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                MicrosoftQuantumCanonAssertResultEqual.Apply((result, resultFromBool, "Incorrect"));
#line 269 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                Reset.Apply(target);
#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonAssertResultEqual = this.Factory.Get<ICallable<(Result,Result,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertResultEqual));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.PeriodicFunction = this.Factory.Get<IUnitary<(QArray<Qubit>,Int64,Qubit,Int64)>>(typeof(HW3p1.PeriodicFunction));
            this.UtilsQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.QubitsToInt));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumCanonResultFromBool = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Canon.ResultFromBool));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> a, QArray<Qubit> b)
        {
            return __m__.Run<_TestPeriodicFunctionImpl, (QArray<Qubit>,QArray<Qubit>), QVoid>((a, b));
        }
    }

    public class TestPeriodicFunction : Operation<Int64, QVoid>, ICallable
    {
        public TestPeriodicFunction(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestPeriodicFunction";
        String ICallable.FullName => "HW3p1.TestPeriodicFunction";
        protected ICallable<(Int64,ICallable), QVoid> UtilsRunOnAllTwoBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>), QVoid> _TestPeriodicFunctionImpl
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var length = __in;
#line 277 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            UtilsRunOnAllTwoBinariesOfLength.Apply((length, ((ICallable)_TestPeriodicFunctionImpl)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.UtilsRunOnAllTwoBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.RunOnAllTwoBinariesOfLength));
            this._TestPeriodicFunctionImpl = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>), QVoid>>(typeof(HW3p1._TestPeriodicFunctionImpl));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<TestPeriodicFunction, Int64, QVoid>(length);
        }
    }
}
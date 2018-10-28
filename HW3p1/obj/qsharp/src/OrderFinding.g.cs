#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p1", "QFTAdder (start : Qubit[], amount : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 305L, 9L, 61L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTAdderImpl (q1 : Qubit[], q2 : Qubit[], modulus : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 1503L, 45L, 77L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTAdder (binaryLength : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 1934L, 58L, 52L)]
[assembly: OperationDeclaration("HW3p1", "Multiplier (multiplicand : Qubit[], multiplier : Qubit[], ancilla : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 2157L, 64L, 92L)]
[assembly: OperationDeclaration("HW3p1", "_TestMultiplierImpl (q1 : Qubit[], q2 : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 2773L, 81L, 65L)]
[assembly: OperationDeclaration("HW3p1", "_TestMultiplier (binaryLength : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 3450L, 100L, 54L)]
#line hidden
namespace HW3p1
{
    public class QFTAdder : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public QFTAdder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QFTAdder";
        String ICallable.FullName => "HW3p1.QFTAdder";
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

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (start,amount) = __in;
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 15 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            foreach (var i in new Range((amount.Count - 1L), -(1L), 0L))
            {
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var add = 2L.Pow(((amount.Count - 1L) - i));
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                MicrosoftQuantumCanonApplyToEachIndexCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2))))), start));
            }

#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount) = __in;
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(bigEndian);
            foreach (var i in new Range(((amount.Count - 1L) - (((0L - (amount.Count - 1L)) / -(1L)) * -(-(1L)))), -(-(1L)), (amount.Count - 1L)))
            {
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var add = 2L.Pow(((amount.Count - 1L) - i));
                MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2))))), start));
            }

            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(start,amount)) = __in;
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
            MicrosoftQuantumCanonQFT.Controlled.Apply((controlQubits, bigEndian));
            foreach (var i in new Range((amount.Count - 1L), -(1L), 0L))
            {
                var add = 2L.Pow(((amount.Count - 1L) - i));
                MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2))))), start)));
            }

            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((controlQubits, bigEndian));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(start,amount)) = __in;
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((controlQubits, bigEndian));
            foreach (var i in new Range(((amount.Count - 1L) - (((0L - (amount.Count - 1L)) / -(1L)) * -(-(1L)))), -(-(1L)), (amount.Count - 1L)))
            {
                var add = 2L.Pow(((amount.Count - 1L) - i));
                MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2))))), start)));
            }

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

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> start, QArray<Qubit> amount)
        {
            return __m__.Run<QFTAdder, (QArray<Qubit>,QArray<Qubit>), QVoid>((start, amount));
        }
    }

    public class _TestQFTAdderImpl : Operation<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public _TestQFTAdderImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "_TestQFTAdderImpl";
        String ICallable.FullName => "HW3p1._TestQFTAdderImpl";
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

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> QFTAdder
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> UtilsQubitsToInt
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (q1,q2,modulus) = __in;
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q1Val = UtilsQubitsToInt.Apply(q1);
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q2Val = UtilsQubitsToInt.Apply(q2);
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            QFTAdder.Apply((q1, q2));
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var calcAns = UtilsQubitsToInt.Apply(q1);
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var trueAns = ((q1Val + q2Val) % modulus);
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, $"{q1Val} + {q2Val} != {calcAns}"));
#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Message.Apply($"{q1Val} + {q2Val} == {calcAns}");
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.QFTAdder = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.QFTAdder));
            this.UtilsQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.QubitsToInt));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> q1, QArray<Qubit> q2, Int64 modulus)
        {
            return __m__.Run<_TestQFTAdderImpl, (QArray<Qubit>,QArray<Qubit>,Int64), QVoid>((q1, q2, modulus));
        }
    }

    public class _TestQFTAdder : Operation<Int64, QVoid>, ICallable
    {
        public _TestQFTAdder(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestQFTAdder";
        String ICallable.FullName => "HW3p1._TestQFTAdder";
        protected ICallable<(Int64,ICallable), QVoid> UtilsRunOnAllTwoBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid> _TestQFTAdderImpl
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var binaryLength = __in;
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            UtilsRunOnAllTwoBinariesOfLength.Apply((binaryLength, ((ICallable)_TestQFTAdderImpl.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (QArray<Qubit>,QArray<Qubit>,Int64)>((_arg1) => (_arg1.Item1, _arg1.Item2, 2L.Pow(binaryLength)))))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.UtilsRunOnAllTwoBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.RunOnAllTwoBinariesOfLength));
            this._TestQFTAdderImpl = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid>>(typeof(HW3p1._TestQFTAdderImpl));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 binaryLength)
        {
            return __m__.Run<_TestQFTAdder, Int64, QVoid>(binaryLength);
        }
    }

    public class Multiplier : Unitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public Multiplier(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Multiplier";
        String ICallable.FullName => "HW3p1.Multiplier";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> MicrosoftQuantumExtensionsTestingAssertAllZero
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> QFTAdder
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (multiplicand,multiplier,ancilla) = __in;
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(ancilla);
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            QFTAdder.Controlled.Apply((new QArray<Qubit>()
            {multiplier[(multiplier.Count - 1L)]}, (ancilla, multiplicand)));
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            foreach (var i in new Range((multiplier.Count - 2L), -(1L), 0L))
            {
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var leftShifts = Allocate.Apply(((multiplier.Count - 1L) - i));
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                QFTAdder.Controlled.Apply((new QArray<Qubit>()
                {multiplier[i]}, (ancilla, (multiplicand + leftShifts))));
#line hidden
                Release.Apply(leftShifts);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (multiplicand,multiplier,ancilla) = __in;
            foreach (var i in new Range(((multiplier.Count - 2L) - (((0L - (multiplier.Count - 2L)) / -(1L)) * -(-(1L)))), -(-(1L)), (multiplier.Count - 2L)))
            {
                var leftShifts = Allocate.Apply(((multiplier.Count - 1L) - i));
                QFTAdder.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {multiplier[i]}, (ancilla, (multiplicand + leftShifts))));
#line hidden
                Release.Apply(leftShifts);
            }

            QFTAdder.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {multiplier[(multiplier.Count - 1L)]}, (ancilla, multiplicand)));
            MicrosoftQuantumExtensionsTestingAssertAllZero.Adjoint.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(multiplicand,multiplier,ancilla)) = __in;
            MicrosoftQuantumExtensionsTestingAssertAllZero.Controlled.Apply((controlQubits, ancilla));
            QFTAdder.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {multiplier[(multiplier.Count - 1L)]}, (ancilla, multiplicand))));
            foreach (var i in new Range((multiplier.Count - 2L), -(1L), 0L))
            {
                var leftShifts = Allocate.Apply(((multiplier.Count - 1L) - i));
                QFTAdder.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {multiplier[i]}, (ancilla, (multiplicand + leftShifts)))));
#line hidden
                Release.Apply(leftShifts);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(multiplicand,multiplier,ancilla)) = __in;
            foreach (var i in new Range(((multiplier.Count - 2L) - (((0L - (multiplier.Count - 2L)) / -(1L)) * -(-(1L)))), -(-(1L)), (multiplier.Count - 2L)))
            {
                var leftShifts = Allocate.Apply(((multiplier.Count - 1L) - i));
                QFTAdder.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {multiplier[i]}, (ancilla, (multiplicand + leftShifts)))));
#line hidden
                Release.Apply(leftShifts);
            }

            QFTAdder.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {multiplier[(multiplier.Count - 1L)]}, (ancilla, multiplicand))));
            MicrosoftQuantumExtensionsTestingAssertAllZero.Adjoint.Controlled.Apply((controlQubits, ancilla));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumExtensionsTestingAssertAllZero = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZero));
            this.QFTAdder = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.QFTAdder));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> multiplicand, QArray<Qubit> multiplier, QArray<Qubit> ancilla)
        {
            return __m__.Run<Multiplier, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid>((multiplicand, multiplier, ancilla));
        }
    }

    public class _TestMultiplierImpl : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public _TestMultiplierImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "_TestMultiplierImpl";
        String ICallable.FullName => "HW3p1._TestMultiplierImpl";
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

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> Multiplier
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

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (q1,q2) = __in;
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q1Val = UtilsQubitsToInt.Apply(q1);
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q2Val = UtilsQubitsToInt.Apply(q2);
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var maxProduct = (2L.Pow(q1.Count) * 2L.Pow(q2.Count));
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var maxProductLength = MicrosoftQuantumCanonBitSize.Apply(maxProduct);
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var target = Allocate.Apply(maxProductLength);
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Multiplier.Apply((q1, q2, target));
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var calcAns = UtilsQubitsToInt.Apply(target);
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var trueAns = (q1Val * q2Val);
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, $"{q1Val} * {q2Val} != {calcAns}"));
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Message.Apply($"{q1Val} * {q2Val} == {calcAns}");
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            ResetAll.Apply(target);
#line hidden
            Release.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Multiplier = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.Multiplier));
            this.UtilsQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.QubitsToInt));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> q1, QArray<Qubit> q2)
        {
            return __m__.Run<_TestMultiplierImpl, (QArray<Qubit>,QArray<Qubit>), QVoid>((q1, q2));
        }
    }

    public class _TestMultiplier : Operation<Int64, QVoid>, ICallable
    {
        public _TestMultiplier(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_TestMultiplier";
        String ICallable.FullName => "HW3p1._TestMultiplier";
        protected ICallable<(Int64,ICallable), QVoid> UtilsRunOnAllTwoBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>), QVoid> _TestMultiplierImpl
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var binaryLength = __in;
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            UtilsRunOnAllTwoBinariesOfLength.Apply((binaryLength, ((ICallable)_TestMultiplierImpl)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.UtilsRunOnAllTwoBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.RunOnAllTwoBinariesOfLength));
            this._TestMultiplierImpl = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>), QVoid>>(typeof(HW3p1._TestMultiplierImpl));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 binaryLength)
        {
            return __m__.Run<_TestMultiplier, Int64, QVoid>(binaryLength);
        }
    }
}
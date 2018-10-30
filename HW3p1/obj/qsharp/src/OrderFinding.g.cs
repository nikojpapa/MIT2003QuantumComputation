#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p1", "QFTAdder (start : Qubit[], amount : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 305L, 9L, 61L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTAdderImpl (q1 : Qubit[], q2 : Qubit[], modulus : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 1503L, 45L, 77L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTAdder (binaryLength : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 1934L, 58L, 52L)]
[assembly: OperationDeclaration("HW3p1", "Multiplier (multiplicand : Qubit[], multiplier : Qubit[], target : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 2156L, 64L, 91L)]
[assembly: OperationDeclaration("HW3p1", "_TestMultiplierImpl (q1 : Qubit[], q2 : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 2733L, 79L, 65L)]
[assembly: OperationDeclaration("HW3p1", "_TestMultiplier (binaryLength : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 3410L, 98L, 54L)]
[assembly: OperationDeclaration("HW3p1", "SquareNumber (num : Qubit[], target : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 3582L, 104L, 63L)]
[assembly: OperationDeclaration("HW3p1", "_TestSquareNumberImpl (q1 : Qubit[], N : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 3970L, 117L, 62L)]
[assembly: OperationDeclaration("HW3p1", "_TestSquareNumber (binaryLength : Int, N : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 4643L, 136L, 64L)]
[assembly: OperationDeclaration("HW3p1", "QuantumPow (powQ : Qubit[], baseQ : Qubit[], target : Qubit[], depth : Int, currentProduct : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 4872L, 142L, 115L)]
[assembly: OperationDeclaration("HW3p1", "_TestOrderFindingQuantumPowImpl (q1 : Qubit[], q2 : Qubit[], N : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 6668L, 185L, 85L)]
[assembly: OperationDeclaration("HW3p1", "_TestOrderFindingQuantumPow (binaryLength : Int, N : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 7423L, 205L, 74L)]
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
            var (multiplicand,multiplier,target) = __in;
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            QFTAdder.Controlled.Apply((new QArray<Qubit>()
            {multiplier[(multiplier.Count - 1L)]}, (target, multiplicand)));
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            foreach (var i in new Range((multiplier.Count - 2L), -(1L), 0L))
            {
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var leftShifts = Allocate.Apply(((multiplier.Count - 1L) - i));
#line 69 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                QFTAdder.Controlled.Apply((new QArray<Qubit>()
                {multiplier[i]}, (target, (multiplicand + leftShifts))));
#line hidden
                Release.Apply(leftShifts);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (multiplicand,multiplier,target) = __in;
            foreach (var i in new Range(((multiplier.Count - 2L) - (((0L - (multiplier.Count - 2L)) / -(1L)) * -(-(1L)))), -(-(1L)), (multiplier.Count - 2L)))
            {
                var leftShifts = Allocate.Apply(((multiplier.Count - 1L) - i));
                QFTAdder.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {multiplier[i]}, (target, (multiplicand + leftShifts))));
#line hidden
                Release.Apply(leftShifts);
            }

            QFTAdder.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {multiplier[(multiplier.Count - 1L)]}, (target, multiplicand)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(multiplicand,multiplier,target)) = __in;
            QFTAdder.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {multiplier[(multiplier.Count - 1L)]}, (target, multiplicand))));
            foreach (var i in new Range((multiplier.Count - 2L), -(1L), 0L))
            {
                var leftShifts = Allocate.Apply(((multiplier.Count - 1L) - i));
                QFTAdder.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {multiplier[i]}, (target, (multiplicand + leftShifts)))));
#line hidden
                Release.Apply(leftShifts);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(multiplicand,multiplier,target)) = __in;
            foreach (var i in new Range(((multiplier.Count - 2L) - (((0L - (multiplier.Count - 2L)) / -(1L)) * -(-(1L)))), -(-(1L)), (multiplier.Count - 2L)))
            {
                var leftShifts = Allocate.Apply(((multiplier.Count - 1L) - i));
                QFTAdder.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {multiplier[i]}, (target, (multiplicand + leftShifts)))));
#line hidden
                Release.Apply(leftShifts);
            }

            QFTAdder.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {multiplier[(multiplier.Count - 1L)]}, (target, multiplicand))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.QFTAdder = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.QFTAdder));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> multiplicand, QArray<Qubit> multiplier, QArray<Qubit> target)
        {
            return __m__.Run<Multiplier, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>), QVoid>((multiplicand, multiplier, target));
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
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q1Val = UtilsQubitsToInt.Apply(q1);
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q2Val = UtilsQubitsToInt.Apply(q2);
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var maxProduct = (2L.Pow(q1.Count) * 2L.Pow(q2.Count));
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var maxProductLength = MicrosoftQuantumCanonBitSize.Apply(maxProduct);
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var target = Allocate.Apply(maxProductLength);
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Multiplier.Apply((q1, q2, target));
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var calcAns = UtilsQubitsToInt.Apply(target);
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var trueAns = (q1Val * q2Val);
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, $"{q1Val} * {q2Val} != {calcAns}"));
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Message.Apply($"{q1Val} * {q2Val} == {calcAns}");
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
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
#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
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

    public class SquareNumber : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public SquareNumber(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SquareNumber";
        String ICallable.FullName => "HW3p1.SquareNumber";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> UtilsCopyQubits
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> Multiplier
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (num,target) = __in;
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var ancillas = Allocate.Apply(num.Count);
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            UtilsCopyQubits.Apply((num, ancillas));
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Multiplier.Apply((ancillas, num, target));
#line 109 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            UtilsCopyQubits.Adjoint.Apply((num, ancillas));
#line hidden
            Release.Apply(ancillas);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (num,target) = __in;
            var ancillas = Allocate.Apply(num.Count);
            UtilsCopyQubits.Adjoint.Adjoint.Apply((num, ancillas));
            Multiplier.Adjoint.Apply((ancillas, num, target));
            UtilsCopyQubits.Adjoint.Apply((num, ancillas));
#line hidden
            Release.Apply(ancillas);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(num,target)) = __in;
            var ancillas = Allocate.Apply(num.Count);
            UtilsCopyQubits.Controlled.Apply((controlQubits, (num, ancillas)));
            Multiplier.Controlled.Apply((controlQubits, (ancillas, num, target)));
            UtilsCopyQubits.Adjoint.Controlled.Apply((controlQubits, (num, ancillas)));
#line hidden
            Release.Apply(ancillas);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(num,target)) = __in;
            var ancillas = Allocate.Apply(num.Count);
            UtilsCopyQubits.Adjoint.Adjoint.Controlled.Apply((controlQubits, (num, ancillas)));
            Multiplier.Adjoint.Controlled.Apply((controlQubits, (ancillas, num, target)));
            UtilsCopyQubits.Adjoint.Controlled.Apply((controlQubits, (num, ancillas)));
#line hidden
            Release.Apply(ancillas);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.UtilsCopyQubits = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Utils.CopyQubits));
            this.Multiplier = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.Multiplier));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> num, QArray<Qubit> target)
        {
            return __m__.Run<SquareNumber, (QArray<Qubit>,QArray<Qubit>), QVoid>((num, target));
        }
    }

    public class _TestSquareNumberImpl : Operation<(QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public _TestSquareNumberImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "_TestSquareNumberImpl";
        String ICallable.FullName => "HW3p1._TestSquareNumberImpl";
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

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumCanonIntMax
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

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> SquareNumber
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (q1,N) = __in;
#line 119 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q1Val = UtilsQubitsToInt.Apply(q1);
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var answerLength = MicrosoftQuantumCanonIntMax.Apply((MicrosoftQuantumCanonBitSize.Apply(q1Val.Pow(2L)), q1.Count));
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Message.Apply($"");
#line 122 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Message.Apply($"{q1Val} ^ 2:");
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var target = Allocate.Apply(MicrosoftQuantumCanonBitSize.Apply(N));
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            SquareNumber.Apply((q1, target));
#line 127 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var calcAns = UtilsQubitsToInt.Apply(target);
#line 128 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var trueAns = (q1Val.Pow(2L) % 2L.Pow(target.Count));
#line 129 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, $"{q1Val} ^ 2 == {trueAns} != {calcAns}"));
#line 130 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Message.Apply($"{q1Val} ^ 2 == {calcAns}");
#line 132 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
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
            this.MicrosoftQuantumCanonIntMax = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.IntMax));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.UtilsQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.QubitsToInt));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.SquareNumber = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.SquareNumber));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> q1, Int64 N)
        {
            return __m__.Run<_TestSquareNumberImpl, (QArray<Qubit>,Int64), QVoid>((q1, N));
        }
    }

    public class _TestSquareNumber : Operation<(Int64,Int64), QVoid>, ICallable
    {
        public _TestSquareNumber(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "_TestSquareNumber";
        String ICallable.FullName => "HW3p1._TestSquareNumber";
        protected ICallable<(Int64,ICallable), QVoid> UtilsRunOnAllBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QVoid> _TestSquareNumberImpl
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QVoid> Body => (__in) =>
        {
            var (binaryLength,N) = __in;
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            UtilsRunOnAllBinariesOfLength.Apply((binaryLength, ((ICallable)_TestSquareNumberImpl.Partial(new Func<QArray<Qubit>, (QArray<Qubit>,Int64)>((_arg1) => (_arg1, N))))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.UtilsRunOnAllBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.RunOnAllBinariesOfLength));
            this._TestSquareNumberImpl = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(HW3p1._TestSquareNumberImpl));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 binaryLength, Int64 N)
        {
            return __m__.Run<_TestSquareNumber, (Int64,Int64), QVoid>((binaryLength, N));
        }
    }

    public class QuantumPow : Unitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>)>, ICallable
    {
        public QuantumPow(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "QuantumPow";
        String ICallable.FullName => "HW3p1.QuantumPow";
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

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> UtilsCopyQubits
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> Multiplier
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> SquareNumber
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (powQ,baseQ,target,depth,currentProduct) = __in;
#line 144 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(target);
#line 145 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            if ((depth == powQ.Count))
            {
#line 146 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                UtilsCopyQubits.Apply((currentProduct, target));
            }
            else
            {
#line 148 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var targetLength = target.Count;
#line 149 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas = Allocate.Apply((targetLength * 2L));
#line 150 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas1 = ancillas?.Slice(new Range(0L, (targetLength - 1L)));
#line 151 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas2 = ancillas?.Slice(new Range(targetLength, (ancillas.Count - 1L)));
#line 153 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var lengthAncillas1 = ancillas1.Count;
#line 154 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                if ((depth == 0L))
                {
#line 155 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                    UtilsCopyQubits.Apply((baseQ, ancillas1));
                }
                else
                {
#line 157 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                    SquareNumber.Apply((baseQ, ancillas1));
                }

#line 159 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var control = powQ[((powQ.Count - 1L) - depth)];
#line 160 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                Multiplier.Controlled.Apply((new QArray<Qubit>()
                {control}, (ancillas1, currentProduct, ancillas2)));
#line 161 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                MicrosoftQuantumPrimitiveX.Apply(control);
#line 162 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                UtilsCopyQubits.Controlled.Apply((new QArray<Qubit>()
                {control}, (currentProduct, ancillas2)));
#line 163 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                MicrosoftQuantumPrimitiveX.Apply(control);
#line 165 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                ((IUnitary)this).Apply((powQ, ancillas1, target, (depth + 1L), ancillas2));
#line 167 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                MicrosoftQuantumPrimitiveX.Apply(control);
#line 168 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                UtilsCopyQubits.Adjoint.Controlled.Apply((new QArray<Qubit>()
                {control}, (currentProduct, ancillas2)));
#line 169 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                MicrosoftQuantumPrimitiveX.Apply(control);
#line 170 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                Multiplier.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {control}, (ancillas1, currentProduct, ancillas2)));
#line 171 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                if ((depth == 0L))
                {
#line 172 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                    UtilsCopyQubits.Adjoint.Apply((baseQ, ancillas1));
                }
                else
                {
#line 174 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                    SquareNumber.Adjoint.Apply((baseQ, ancillas1));
                }

#line hidden
                Release.Apply(ancillas);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (powQ,baseQ,target,depth,currentProduct) = __in;
            if ((depth == powQ.Count))
            {
                UtilsCopyQubits.Adjoint.Apply((currentProduct, target));
            }
            else
            {
#line 148 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var targetLength = target.Count;
                var ancillas = Allocate.Apply((targetLength * 2L));
#line 150 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas1 = ancillas?.Slice(new Range(0L, (targetLength - 1L)));
#line 151 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas2 = ancillas?.Slice(new Range(targetLength, (ancillas.Count - 1L)));
#line 153 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var lengthAncillas1 = ancillas1.Count;
#line 159 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var control = powQ[((powQ.Count - 1L) - depth)];
                if ((depth == 0L))
                {
                    UtilsCopyQubits.Adjoint.Adjoint.Apply((baseQ, ancillas1));
                }
                else
                {
                    SquareNumber.Adjoint.Adjoint.Apply((baseQ, ancillas1));
                }

                Multiplier.Controlled.Adjoint.Adjoint.Apply((new QArray<Qubit>()
                {control}, (ancillas1, currentProduct, ancillas2)));
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(control);
                UtilsCopyQubits.Adjoint.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {control}, (currentProduct, ancillas2)));
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(control);
                ((IUnitary)this).Adjoint.Apply((powQ, ancillas1, target, (depth + 1L), ancillas2));
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(control);
                UtilsCopyQubits.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {control}, (currentProduct, ancillas2)));
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(control);
                Multiplier.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {control}, (ancillas1, currentProduct, ancillas2)));
                if ((depth == 0L))
                {
                    UtilsCopyQubits.Adjoint.Apply((baseQ, ancillas1));
                }
                else
                {
                    SquareNumber.Adjoint.Apply((baseQ, ancillas1));
                }

#line hidden
                Release.Apply(ancillas);
            }

            MicrosoftQuantumExtensionsTestingAssertAllZero.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(powQ,baseQ,target,depth,currentProduct)) = __in;
            MicrosoftQuantumExtensionsTestingAssertAllZero.Controlled.Apply((controlQubits, target));
            if ((depth == powQ.Count))
            {
                UtilsCopyQubits.Controlled.Apply((controlQubits, (currentProduct, target)));
            }
            else
            {
                var targetLength = target.Count;
                var ancillas = Allocate.Apply((targetLength * 2L));
                var ancillas1 = ancillas?.Slice(new Range(0L, (targetLength - 1L)));
                var ancillas2 = ancillas?.Slice(new Range(targetLength, (ancillas.Count - 1L)));
                var lengthAncillas1 = ancillas1.Count;
                if ((depth == 0L))
                {
                    UtilsCopyQubits.Controlled.Apply((controlQubits, (baseQ, ancillas1)));
                }
                else
                {
                    SquareNumber.Controlled.Apply((controlQubits, (baseQ, ancillas1)));
                }

                var control = powQ[((powQ.Count - 1L) - depth)];
                Multiplier.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (ancillas1, currentProduct, ancillas2))));
                MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, control));
                UtilsCopyQubits.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (currentProduct, ancillas2))));
                MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, control));
                ((IUnitary)this).Controlled.Apply((controlQubits, (powQ, ancillas1, target, (depth + 1L), ancillas2)));
                MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, control));
                UtilsCopyQubits.Adjoint.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (currentProduct, ancillas2))));
                MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, control));
                Multiplier.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (ancillas1, currentProduct, ancillas2))));
                if ((depth == 0L))
                {
                    UtilsCopyQubits.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1)));
                }
                else
                {
                    SquareNumber.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1)));
                }

#line hidden
                Release.Apply(ancillas);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(powQ,baseQ,target,depth,currentProduct)) = __in;
            if ((depth == powQ.Count))
            {
                UtilsCopyQubits.Adjoint.Controlled.Apply((controlQubits, (currentProduct, target)));
            }
            else
            {
                var targetLength = target.Count;
                var ancillas = Allocate.Apply((targetLength * 2L));
                var ancillas1 = ancillas?.Slice(new Range(0L, (targetLength - 1L)));
                var ancillas2 = ancillas?.Slice(new Range(targetLength, (ancillas.Count - 1L)));
                var lengthAncillas1 = ancillas1.Count;
                var control = powQ[((powQ.Count - 1L) - depth)];
                if ((depth == 0L))
                {
                    UtilsCopyQubits.Adjoint.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1)));
                }
                else
                {
                    SquareNumber.Adjoint.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1)));
                }

                Multiplier.Controlled.Adjoint.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (ancillas1, currentProduct, ancillas2))));
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, control));
                UtilsCopyQubits.Adjoint.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (currentProduct, ancillas2))));
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, control));
                ((IUnitary)this).Adjoint.Controlled.Apply((controlQubits, (powQ, ancillas1, target, (depth + 1L), ancillas2)));
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, control));
                UtilsCopyQubits.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (currentProduct, ancillas2))));
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, control));
                Multiplier.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (ancillas1, currentProduct, ancillas2))));
                if ((depth == 0L))
                {
                    UtilsCopyQubits.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1)));
                }
                else
                {
                    SquareNumber.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1)));
                }

#line hidden
                Release.Apply(ancillas);
            }

            MicrosoftQuantumExtensionsTestingAssertAllZero.Adjoint.Controlled.Apply((controlQubits, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumExtensionsTestingAssertAllZero = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZero));
            this.UtilsCopyQubits = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Utils.CopyQubits));
            this.Multiplier = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.Multiplier));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.SquareNumber = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.SquareNumber));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> powQ, QArray<Qubit> baseQ, QArray<Qubit> target, Int64 depth, QArray<Qubit> currentProduct)
        {
            return __m__.Run<QuantumPow, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>), QVoid>((powQ, baseQ, target, depth, currentProduct));
        }
    }

    public class _TestOrderFindingQuantumPowImpl : Operation<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public _TestOrderFindingQuantumPowImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "_TestOrderFindingQuantumPowImpl";
        String ICallable.FullName => "HW3p1._TestOrderFindingQuantumPowImpl";
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

        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>)> QuantumPow
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

        public override Func<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (q1,q2,N) = __in;
#line 187 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q1Val = UtilsQubitsToInt.Apply(q1);
#line 188 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q2Val = UtilsQubitsToInt.Apply(q2);
#line 190 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var qubits = Allocate.Apply((MicrosoftQuantumCanonBitSize.Apply(N) + 1L));
#line 191 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var target = MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits);
#line 192 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var startProduct = MicrosoftQuantumCanonTail.Apply<Qubit>(qubits);
#line 193 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumPrimitiveX.Apply(startProduct);
#line 194 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            QuantumPow.Apply((q1, q2, target, 0L, new QArray<Qubit>()
            {startProduct}));
#line 196 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var calcAns = UtilsQubitsToInt.Apply(target);
#line 197 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var trueAns = (q2Val.Pow(q1Val) % 2L.Pow(target.Count));
#line 198 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, $"{q2Val} ^ {q1Val} == {trueAns} != {calcAns}"));
#line 199 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Message.Apply($"{q2Val} ^ {q1Val} == {calcAns}");
#line 201 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            ResetAll.Apply(qubits);
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
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.QuantumPow = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>)>>(typeof(HW3p1.QuantumPow));
            this.UtilsQubitsToInt = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Utils.QubitsToInt));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> q1, QArray<Qubit> q2, Int64 N)
        {
            return __m__.Run<_TestOrderFindingQuantumPowImpl, (QArray<Qubit>,QArray<Qubit>,Int64), QVoid>((q1, q2, N));
        }
    }

    public class _TestOrderFindingQuantumPow : Operation<(Int64,Int64), QVoid>, ICallable
    {
        public _TestOrderFindingQuantumPow(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "_TestOrderFindingQuantumPow";
        String ICallable.FullName => "HW3p1._TestOrderFindingQuantumPow";
        protected ICallable<(Int64,ICallable), QVoid> UtilsRunOnAllTwoBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid> _TestOrderFindingQuantumPowImpl
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QVoid> Body => (__in) =>
        {
            var (binaryLength,N) = __in;
#line 207 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            UtilsRunOnAllTwoBinariesOfLength.Apply((binaryLength, ((ICallable)_TestOrderFindingQuantumPowImpl.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (QArray<Qubit>,QArray<Qubit>,Int64)>((_arg1) => (_arg1.Item1, _arg1.Item2, N))))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.UtilsRunOnAllTwoBinariesOfLength = this.Factory.Get<ICallable<(Int64,ICallable), QVoid>>(typeof(Utils.RunOnAllTwoBinariesOfLength));
            this._TestOrderFindingQuantumPowImpl = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid>>(typeof(HW3p1._TestOrderFindingQuantumPowImpl));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 binaryLength, Int64 N)
        {
            return __m__.Run<_TestOrderFindingQuantumPow, (Int64,Int64), QVoid>((binaryLength, N));
        }
    }
}
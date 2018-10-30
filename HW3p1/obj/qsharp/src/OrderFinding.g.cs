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
[assembly: OperationDeclaration("HW3p1", "_QuantumPowImpl (baseQ : Qubit[], ancillas1 : Qubit[], ancillas2 : Qubit[], control : Qubit, currentProduct : Qubit[], depth : Int) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 3663L, 104L, 144L)]
[assembly: OperationDeclaration("HW3p1", "QuantumPow (powQ : Qubit[], baseQ : Qubit[], target : Qubit[], depth : Int, currentProduct : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 5503L, 154L, 115L)]
[assembly: OperationDeclaration("HW3p1", "_TestOrderFindingQuantumPowImpl (q1 : Qubit[], q2 : Qubit[], N : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 7084L, 191L, 85L)]
[assembly: OperationDeclaration("HW3p1", "_TestOrderFindingQuantumPow (binaryLength : Int, N : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 7839L, 211L, 74L)]
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

    public class _QuantumPowImpl : Unitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64)>, ICallable
    {
        public _QuantumPowImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "_QuantumPowImpl";
        String ICallable.FullName => "HW3p1._QuantumPowImpl";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)> Multiplier
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> QFTAdder
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (baseQ,ancillas1,ancillas2,control,currentProduct,depth) = __in;
            // using (ancillas = Qubit[Length(num)]) {
            // QFTAdder(ancillas, num);
            // Multiplier(ancillas, num, target);
            // (Adjoint QFTAdder)(ancillas, num);
            // }
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            if ((depth == 0L))
            {
#line 113 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                QFTAdder.Apply((ancillas1, baseQ));
            }
            else
            {
#line 115 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                QFTAdder.Apply((ancillas2, baseQ));
#line 116 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                Multiplier.Apply((ancillas2, baseQ, ancillas1));
#line 117 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                QFTAdder.Adjoint.Apply((ancillas2, baseQ));
            }

#line 119 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Multiplier.Controlled.Apply((new QArray<Qubit>()
            {control}, (ancillas1, currentProduct, ancillas2)));
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumPrimitiveX.Apply(control);
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            QFTAdder.Controlled.Apply((new QArray<Qubit>()
            {control}, (ancillas2, currentProduct)));
#line 122 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumPrimitiveX.Apply(control);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64), QVoid> AdjointBody => (__in) =>
        {
            var (baseQ,ancillas1,ancillas2,control,currentProduct,depth) = __in;
            // using (ancillas = Qubit[Length(num)]) {
            // QFTAdder(ancillas, num);
            // Multiplier(ancillas, num, target);
            // (Adjoint QFTAdder)(ancillas, num);
            // }
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(control);
            QFTAdder.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {control}, (ancillas2, currentProduct)));
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(control);
            Multiplier.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {control}, (ancillas1, currentProduct, ancillas2)));
            if ((depth == 0L))
            {
                QFTAdder.Adjoint.Apply((ancillas1, baseQ));
            }
            else
            {
                QFTAdder.Adjoint.Adjoint.Apply((ancillas2, baseQ));
                Multiplier.Adjoint.Apply((ancillas2, baseQ, ancillas1));
                QFTAdder.Adjoint.Apply((ancillas2, baseQ));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(baseQ,ancillas1,ancillas2,control,currentProduct,depth)) = __in;
            // using (ancillas = Qubit[Length(num)]) {
            // QFTAdder(ancillas, num);
            // Multiplier(ancillas, num, target);
            // (Adjoint QFTAdder)(ancillas, num);
            // }
            if ((depth == 0L))
            {
                QFTAdder.Controlled.Apply((controlQubits, (ancillas1, baseQ)));
            }
            else
            {
                QFTAdder.Controlled.Apply((controlQubits, (ancillas2, baseQ)));
                Multiplier.Controlled.Apply((controlQubits, (ancillas2, baseQ, ancillas1)));
                QFTAdder.Adjoint.Controlled.Apply((controlQubits, (ancillas2, baseQ)));
            }

            Multiplier.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {control}, (ancillas1, currentProduct, ancillas2))));
            MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, control));
            QFTAdder.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {control}, (ancillas2, currentProduct))));
            MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, control));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(baseQ,ancillas1,ancillas2,control,currentProduct,depth)) = __in;
            // using (ancillas = Qubit[Length(num)]) {
            // QFTAdder(ancillas, num);
            // Multiplier(ancillas, num, target);
            // (Adjoint QFTAdder)(ancillas, num);
            // }
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, control));
            QFTAdder.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {control}, (ancillas2, currentProduct))));
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, control));
            Multiplier.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {control}, (ancillas1, currentProduct, ancillas2))));
            if ((depth == 0L))
            {
                QFTAdder.Adjoint.Controlled.Apply((controlQubits, (ancillas1, baseQ)));
            }
            else
            {
                QFTAdder.Adjoint.Adjoint.Controlled.Apply((controlQubits, (ancillas2, baseQ)));
                Multiplier.Adjoint.Controlled.Apply((controlQubits, (ancillas2, baseQ, ancillas1)));
                QFTAdder.Adjoint.Controlled.Apply((controlQubits, (ancillas2, baseQ)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Multiplier = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.Multiplier));
            this.QFTAdder = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(HW3p1.QFTAdder));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> baseQ, QArray<Qubit> ancillas1, QArray<Qubit> ancillas2, Qubit control, QArray<Qubit> currentProduct, Int64 depth)
        {
            return __m__.Run<_QuantumPowImpl, (QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64), QVoid>((baseQ, ancillas1, ancillas2, control, currentProduct, depth));
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

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64)> _QuantumPowImpl
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (powQ,baseQ,target,depth,currentProduct) = __in;
#line 156 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(target);
#line 157 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            if ((depth == powQ.Count))
            {
#line 158 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                UtilsCopyQubits.Apply((currentProduct, target));
            }
            else
            {
#line 160 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var targetLength = target.Count;
#line 161 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas = Allocate.Apply((targetLength * 2L));
#line 162 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas1 = ancillas?.Slice(new Range(0L, (targetLength - 1L)));
#line 163 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas2 = ancillas?.Slice(new Range(targetLength, (ancillas.Count - 1L)));
#line 164 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var control = powQ[((powQ.Count - 1L) - depth)];
#line 166 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                _QuantumPowImpl.Apply((baseQ, ancillas1, ancillas2, control, currentProduct, depth));
                // if (depth == 0) {
                //     QFTAdder(ancillas1, baseQ);
                // } else {
                //     SquareNumber(baseQ, ancillas1, ancillas2);
                // }
                // let control = powQ[Length(powQ) - 1 - depth];
                // (Controlled Multiplier)([control], (ancillas1, currentProduct, ancillas2));
                // X(control);
                // (Controlled QFTAdder)([control], (ancillas2, currentProduct));
                // X(control);
#line 178 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                ((IUnitary)this).Apply((powQ, ancillas1, target, (depth + 1L), ancillas2));
#line 180 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                _QuantumPowImpl.Adjoint.Apply((baseQ, ancillas1, ancillas2, control, currentProduct, depth));
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
#line 160 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var targetLength = target.Count;
                var ancillas = Allocate.Apply((targetLength * 2L));
#line 162 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas1 = ancillas?.Slice(new Range(0L, (targetLength - 1L)));
#line 163 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var ancillas2 = ancillas?.Slice(new Range(targetLength, (ancillas.Count - 1L)));
#line 164 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var control = powQ[((powQ.Count - 1L) - depth)];
                // if (depth == 0) {
                //     QFTAdder(ancillas1, baseQ);
                // } else {
                //     SquareNumber(baseQ, ancillas1, ancillas2);
                // }
                // let control = powQ[Length(powQ) - 1 - depth];
                // (Controlled Multiplier)([control], (ancillas1, currentProduct, ancillas2));
                // X(control);
                // (Controlled QFTAdder)([control], (ancillas2, currentProduct));
                // X(control);
                _QuantumPowImpl.Adjoint.Adjoint.Apply((baseQ, ancillas1, ancillas2, control, currentProduct, depth));
                ((IUnitary)this).Adjoint.Apply((powQ, ancillas1, target, (depth + 1L), ancillas2));
                _QuantumPowImpl.Adjoint.Apply((baseQ, ancillas1, ancillas2, control, currentProduct, depth));
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
                var control = powQ[((powQ.Count - 1L) - depth)];
                _QuantumPowImpl.Controlled.Apply((controlQubits, (baseQ, ancillas1, ancillas2, control, currentProduct, depth)));
                // if (depth == 0) {
                //     QFTAdder(ancillas1, baseQ);
                // } else {
                //     SquareNumber(baseQ, ancillas1, ancillas2);
                // }
                // let control = powQ[Length(powQ) - 1 - depth];
                // (Controlled Multiplier)([control], (ancillas1, currentProduct, ancillas2));
                // X(control);
                // (Controlled QFTAdder)([control], (ancillas2, currentProduct));
                // X(control);
                ((IUnitary)this).Controlled.Apply((controlQubits, (powQ, ancillas1, target, (depth + 1L), ancillas2)));
                _QuantumPowImpl.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1, ancillas2, control, currentProduct, depth)));
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
                var control = powQ[((powQ.Count - 1L) - depth)];
                // if (depth == 0) {
                //     QFTAdder(ancillas1, baseQ);
                // } else {
                //     SquareNumber(baseQ, ancillas1, ancillas2);
                // }
                // let control = powQ[Length(powQ) - 1 - depth];
                // (Controlled Multiplier)([control], (ancillas1, currentProduct, ancillas2));
                // X(control);
                // (Controlled QFTAdder)([control], (ancillas2, currentProduct));
                // X(control);
                _QuantumPowImpl.Adjoint.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1, ancillas2, control, currentProduct, depth)));
                ((IUnitary)this).Adjoint.Controlled.Apply((controlQubits, (powQ, ancillas1, target, (depth + 1L), ancillas2)));
                _QuantumPowImpl.Adjoint.Controlled.Apply((controlQubits, (baseQ, ancillas1, ancillas2, control, currentProduct, depth)));
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
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this._QuantumPowImpl = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,QArray<Qubit>,Qubit,QArray<Qubit>,Int64)>>(typeof(HW3p1._QuantumPowImpl));
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
#line 193 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q1Val = UtilsQubitsToInt.Apply(q1);
#line 194 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q2Val = UtilsQubitsToInt.Apply(q2);
#line 196 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var qubits = Allocate.Apply((MicrosoftQuantumCanonBitSize.Apply(N) + 1L));
#line 197 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var target = MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits);
#line 198 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var startProduct = MicrosoftQuantumCanonTail.Apply<Qubit>(qubits);
#line 199 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumPrimitiveX.Apply(startProduct);
#line 200 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            QuantumPow.Apply((q1, q2, target, 0L, new QArray<Qubit>()
            {startProduct}));
#line 202 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var calcAns = UtilsQubitsToInt.Apply(target);
#line 203 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var trueAns = (q2Val.Pow(q1Val) % 2L.Pow(target.Count));
#line 204 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, $"{q2Val} ^ {q1Val} == {trueAns} != {calcAns}"));
#line 205 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            Message.Apply($"{q2Val} ^ {q1Val} == {calcAns}");
#line 207 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
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
#line 213 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
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
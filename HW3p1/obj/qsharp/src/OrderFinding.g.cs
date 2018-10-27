#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p1", "QFTAdder (start : Qubit[], amount : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 305L, 9L, 61L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTAdderImpl (q1 : Qubit[], q2 : Qubit[], modulus : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 1586L, 46L, 77L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTAdder (binaryLength : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs", 2017L, 59L, 52L)]
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

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
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
            MicrosoftQuantumCanonAssertIntEqual.Apply((start.Count, amount.Count, "Must be equal length"));
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 16 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            foreach (var i in new Range((amount.Count - 1L), -(1L), 0L))
            {
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                var add = 2L.Pow(((amount.Count - 1L) - i));
#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
                MicrosoftQuantumCanonApplyToEachIndexCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Controlled.Partial(new Func<(Int64,Qubit), (QArray<Qubit>,(Int64,Int64,Qubit))>((_arg1) => (new QArray<Qubit>()
                {amount[i]}, (add, _arg1.Item1, _arg1.Item2))))), start));
            }

#line 21 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount) = __in;
            MicrosoftQuantumCanonAssertIntEqual.Apply((start.Count, amount.Count, "Must be equal length"));
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(bigEndian);
            foreach (var i in new Range(((amount.Count - 1L) - (((0L - (amount.Count - 1L)) / -(1L)) * -(-(1L)))), -(-(1L)), (amount.Count - 1L)))
            {
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
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
            MicrosoftQuantumCanonAssertIntEqual.Apply((start.Count, amount.Count, "Must be equal length"));
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
            MicrosoftQuantumCanonAssertIntEqual.Apply((start.Count, amount.Count, "Must be equal length"));
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
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
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
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q1Val = UtilsQubitsToInt.Apply(q1);
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var q2Val = UtilsQubitsToInt.Apply(q2);
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            QFTAdder.Apply((q1, q2));
#line 53 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var calcAns = UtilsQubitsToInt.Apply(q1);
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            var trueAns = ((q1Val + q2Val) % modulus);
#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((calcAns, trueAns, $"{q1Val} + {q2Val} != {calcAns}"));
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
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
#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/OrderFinding.qs"
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
}
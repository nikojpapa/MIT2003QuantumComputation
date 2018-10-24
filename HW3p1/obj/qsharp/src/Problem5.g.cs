#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p1", "PowRn (y : Int, n : Int, qubits : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 2037L, 55L, 5L)]
[assembly: OperationDeclaration("HW3p1", "QFTSubtractor (start : Qubit[], amount : Int) : ()", new string[] { "Controlled", "Adjoint" }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 2289L, 66L, 62L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTSubtractorImpl (start : Qubit[], maxR : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 2663L, 79L, 69L)]
[assembly: OperationDeclaration("HW3p1", "_TestQFTSubtractor (length : Int, maxR : Int) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs", 3307L, 96L, 62L)]
#line hidden
namespace HW3p1
{
    public class PowRn : Unitary<(Int64,Int64,Microsoft.Quantum.Canon.BigEndian)>, ICallable
    {
        public PowRn(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Microsoft.Quantum.Canon.BigEndian)>, IApplyData
        {
            public In((Int64,Int64,Microsoft.Quantum.Canon.BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "PowRn";
        String ICallable.FullName => "HW3p1.PowRn";
        protected IUnitary MicrosoftQuantumCanonApplyToEachIndexCA
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Microsoft.Quantum.Canon.BigEndian), QVoid> Body => (__in) =>
        {
            var (y,n,qubits) = __in;
#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (y, _arg1.Item1, _arg1.Item2)))), qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,Microsoft.Quantum.Canon.BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (y,n,qubits) = __in;
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (y, _arg1.Item1, _arg1.Item2)))), qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,Microsoft.Quantum.Canon.BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(y,n,qubits)) = __in;
            MicrosoftQuantumCanonApplyToEachIndexCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (y, _arg1.Item1, _arg1.Item2)))), qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,Microsoft.Quantum.Canon.BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(y,n,qubits)) = __in;
            MicrosoftQuantumCanonApplyToEachIndexCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (y, _arg1.Item1, _arg1.Item2)))), qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachIndexCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndexCA<>));
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn((Int64,Int64,Microsoft.Quantum.Canon.BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 y, Int64 n, Microsoft.Quantum.Canon.BigEndian qubits)
        {
            return __m__.Run<PowRn, (Int64,Int64,Microsoft.Quantum.Canon.BigEndian), QVoid>((y, n, qubits));
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
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var bigEndian = new Microsoft.Quantum.Canon.BigEndian(start);
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonQFT.Apply(bigEndian);
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonApplyToEachIndexCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveR1Frac.Partial(new Func<(Int64,Qubit), (Int64,Int64,Qubit)>((_arg1) => (-(amount), _arg1.Item1, _arg1.Item2)))), start));
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(bigEndian);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64), QVoid> AdjointBody => (__in) =>
        {
            var (start,amount) = __in;
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
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
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            var startInt = UtilsQubitsToInt.Apply(start);
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
            foreach (var r in new Range(0L, maxR))
            {
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                QFTSubtractor.Apply((start, r));
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var ans = UtilsQubitsToInt.Apply(start);
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                var realAns = MicrosoftQuantumCanonModulus.Apply(((startInt - r), 2L.Pow(start.Count)));
                // if (startInt > r) {
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                MicrosoftQuantumCanonAssertIntEqual.Apply((ans, realAns, $"{startInt} - {r} == {ans} != {realAns}"));
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
                Message.Apply($"{startInt} - {r} == {realAns}");
                // }
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
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

    public class _TestQFTSubtractor : Operation<(Int64,Int64), QVoid>, ICallable
    {
        public _TestQFTSubtractor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "_TestQFTSubtractor";
        String ICallable.FullName => "HW3p1._TestQFTSubtractor";
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
#line 98 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p1/Problem5.qs"
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
            return __m__.Run<_TestQFTSubtractor, (Int64,Int64), QVoid>((length, maxR));
        }
    }
}
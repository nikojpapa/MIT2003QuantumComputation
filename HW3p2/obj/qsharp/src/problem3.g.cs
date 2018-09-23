#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p2", "PrepareSuccess (binaryRep : Int[], qubits : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 520L, 15L, 69L)]
[assembly: OperationDeclaration("HW3p2", "TestPrepareSuccess () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 877L, 25L, 40L)]
[assembly: OperationDeclaration("HW3p2", "Oracle (successBinary : Int[], workQubits : Qubit[], ancillaQubit : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 2679L, 65L, 90L)]
[assembly: OperationDeclaration("HW3p2", "TestOracle () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 3141L, 79L, 32L)]
[assembly: OperationDeclaration("HW3p2", "InversionAboutMean (workQubits : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 4633L, 120L, 59L)]
[assembly: OperationDeclaration("HW3p2", "TestInversionAboutMean () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 5082L, 128L, 44L)]
[assembly: OperationDeclaration("HW3p2", "GroverIteration (successBinary : Int[], workQubits : Qubit[], ancillaQubit : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 6325L, 159L, 99L)]
[assembly: OperationDeclaration("HW3p2", "EntryProblem3 () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 6753L, 172L, 35L)]
[assembly: OperationDeclaration("HW3p2", "Test () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 8207L, 211L, 26L)]
[assembly: FunctionDeclaration("HW3p2", "GenerateAllBinariesOfLength (length : Int) : Int[][]", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 242L, 9L, 14L)]
#line hidden
namespace HW3p2
{
    public class GenerateAllBinariesOfLength : Operation<Int64, QArray<QArray<Int64>>>, ICallable
    {
        public GenerateAllBinariesOfLength(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateAllBinariesOfLength";
        String ICallable.FullName => "HW3p2.GenerateAllBinariesOfLength";
        protected ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>> GenerateBinaries
        {
            get;
            set;
        }

        public override Func<Int64, QArray<QArray<Int64>>> Body => (__in) =>
        {
            var length = __in;
#line 10 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var initialBinaries = new QArray<QArray<Int64>>(1L);
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            initialBinaries[0L] = new QArray<Int64>(length);
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            return GenerateBinaries.Apply((initialBinaries, 0L));
        }

        ;
        public override void Init()
        {
            this.GenerateBinaries = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>>(typeof(HW3p2.GenerateBinaries));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<QArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Int64>>> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<GenerateAllBinariesOfLength, Int64, QArray<QArray<Int64>>>(length);
        }
    }

    public class PrepareSuccess : Operation<(QArray<Int64>,QArray<Qubit>), QVoid>, ICallable
    {
        public PrepareSuccess(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "PrepareSuccess";
        String ICallable.FullName => "HW3p2.PrepareSuccess";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (binaryRep,qubits) = __in;
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((binaryRep.Count, qubits.Count, "Binary representation and qubit register must have equal length"));
#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (binaryRep.Count - 1L)))
            {
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                if ((binaryRep[i] == 0L))
                {
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> binaryRep, QArray<Qubit> qubits)
        {
            return __m__.Run<PrepareSuccess, (QArray<Int64>,QArray<Qubit>), QVoid>((binaryRep, qubits));
        }
    }

    public class TestPrepareSuccess : Operation<QVoid, QVoid>, ICallable
    {
        public TestPrepareSuccess(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestPrepareSuccess";
        String ICallable.FullName => "HW3p2.TestPrepareSuccess";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>> GenerateBinaries
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Qubit>), QVoid> PrepareSuccess
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

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var initialBinaries = new QArray<QArray<Int64>>(1L);
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            initialBinaries[0L] = new QArray<Int64>(2L);
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var allBinaries = GenerateBinaries.Apply((initialBinaries, 0L));
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var workQubits = Allocate.Apply(2L);
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (allBinaries.Count - 1L)))
            {
                // every possible solution state
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var successBinary = allBinaries[i];
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var j in new Range(0L, (allBinaries.Count - 1L)))
                {
                    // every possible work qubit state
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var workQubitBinary = allBinaries[j];
#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var keyCardBinary = new QArray<Int64>(workQubitBinary.Count);
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var k in new Range(0L, (workQubitBinary.Count - 1L)))
                    {
                        // set work qubits
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((workQubitBinary[k] == 1L))
                        {
#line 41 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            MicrosoftQuantumPrimitiveX.Apply(workQubits[k]);
                        }

#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        keyCardBinary[k] = ((workQubitBinary[k] + (1L - successBinary[k])) % 2L);
                    }

#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    PrepareSuccess.Apply((successBinary, workQubits));
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var k in new Range(0L, (workQubits.Count - 1L)))
                    {
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        var keyCardResult = Result.Zero;
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((keyCardBinary[k] == 1L))
                        {
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            keyCardResult = Result.One;
                        }

                        // Message($"prepare success failure; Success: {successBinary}, workQubitBinary: {workQubitBinary}, keyCardBinary: {keyCardBinary}, qubit: {k}");
#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        MicrosoftQuantumExtensionsTestingAssertQubit.Apply((keyCardResult, workQubits[k]));
                    }

#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    ResetAll.Apply(workQubits);
                }
            }

#line hidden
            Release.Apply(workQubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.GenerateBinaries = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>>(typeof(HW3p2.GenerateBinaries));
            this.PrepareSuccess = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(HW3p2.PrepareSuccess));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestPrepareSuccess, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Oracle : Operation<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Oracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Oracle";
        String ICallable.FullName => "HW3p2.Oracle";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Qubit>), QVoid> PrepareSuccess
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (successBinary,workQubits,ancillaQubit) = __in;
#line 67 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((successBinary.Count, workQubits.Count, "Success binary and work qubits must have equal length"));
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, ancillaQubit));
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            PrepareSuccess.Apply((successBinary, workQubits));
#line 72 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveX.Apply(ancillaQubit);
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveH.Apply(ancillaQubit);
#line 74 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((workQubits, ancillaQubit));
#line 76 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            PrepareSuccess.Apply((successBinary, workQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.PrepareSuccess = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(HW3p2.PrepareSuccess));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> successBinary, QArray<Qubit> workQubits, Qubit ancillaQubit)
        {
            return __m__.Run<Oracle, (QArray<Int64>,QArray<Qubit>,Qubit), QVoid>((successBinary, workQubits, ancillaQubit));
        }
    }

    public class TestOracle : Operation<QVoid, QVoid>, ICallable
    {
        public TestOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestOracle";
        String ICallable.FullName => "HW3p2.TestOracle";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<QArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> Oracle
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

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var allBinaries = GenerateAllBinariesOfLength.Apply(2L);
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var qubits = Allocate.Apply(3L);
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var workQubits = qubits?.Slice(new Range(0L, 1L));
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var ancillaQubit = qubits[2L];
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (allBinaries.Count - 1L)))
            {
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var successBinary = allBinaries[i];
#line 90 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var j in new Range(0L, (allBinaries.Count - 1L)))
                {
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var workQubitBinary = allBinaries[j];
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var isSolution = true;
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var k in new Range(0L, (workQubitBinary.Count - 1L)))
                    {
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((workQubitBinary[k] == 1L))
                        {
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            MicrosoftQuantumPrimitiveX.Apply(workQubits[k]);
                        }

#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((isSolution && (((successBinary[k] + workQubitBinary[k]) % 2L) != 0L)))
                        {
#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            isSolution = false;
                        }
                    }

#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    Oracle.Apply((successBinary, workQubits, qubits[2L]));
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumPrimitiveH.Apply(ancillaQubit);
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var expectedResult = Result.One;
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    if (isSolution)
                    {
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        expectedResult = Result.Zero;
                    }

#line 110 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumExtensionsTestingAssertQubit.Apply((expectedResult, ancillaQubit));
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    ResetAll.Apply(workQubits);
#line 113 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    Reset.Apply(ancillaQubit);
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
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.GenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(HW3p2.GenerateAllBinariesOfLength));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Oracle = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>>(typeof(HW3p2.Oracle));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestOracle, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class InversionAboutMean : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public InversionAboutMean(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "InversionAboutMean";
        String ICallable.FullName => "HW3p2.InversionAboutMean";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMost
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var workQubits = __in;
#line 123 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveX), workQubits));
#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(workQubits), MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits)));
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveX), workQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> workQubits)
        {
            return __m__.Run<InversionAboutMean, QArray<Qubit>, QVoid>(workQubits);
        }
    }

    public class TestInversionAboutMean : Operation<QVoid, QVoid>, ICallable
    {
        public TestInversionAboutMean(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestInversionAboutMean";
        String ICallable.FullName => "HW3p2.TestInversionAboutMean";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Double,Qubit,Double), QVoid> MicrosoftQuantumCanonAssertPhase
        {
            get;
            set;
        }

        protected ICallable<Int64, QArray<QArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonHead
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> InversionAboutMean
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

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 130 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var allBinaries = GenerateAllBinariesOfLength.Apply(2L);
#line 131 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (allBinaries.Count - 1L)))
            {
#line 132 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var workQubitBinary = allBinaries[i];
#line 133 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var allZeros = true;
#line 135 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var workQubits = Allocate.Apply(workQubitBinary.Count);
#line 136 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var j in new Range(0L, (workQubitBinary.Count - 1L)))
                {
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    if ((workQubitBinary[j] == 1L))
                    {
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        MicrosoftQuantumPrimitiveX.Apply(workQubits[j]);
#line 139 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        allZeros = false;
                    }
                }

#line 143 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                InversionAboutMean.Apply(workQubits);
#line 144 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumPrimitiveH.Apply(MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits));
#line 145 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                if (allZeros)
                {
#line 146 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumCanonAssertPhase.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits), 1E-10D));
                }
                else if ((MicrosoftQuantumCanonTail.Apply<Int64>(workQubitBinary) == 1L))
                {
#line 148 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumCanonAssertPhase.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 2D), MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits), 1E-10D));
                }
                else if ((MicrosoftQuantumCanonHead.Apply<Int64>(workQubitBinary) == 1L))
                {
#line 150 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumCanonAssertPhase.Apply((0D, MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits), 1E-10D));
                }

#line 153 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                ResetAll.Apply(workQubits);
#line hidden
                Release.Apply(workQubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonAssertPhase = this.Factory.Get<ICallable<(Double,Qubit,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertPhase));
            this.GenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(HW3p2.GenerateAllBinariesOfLength));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumCanonHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Head<>));
            this.InversionAboutMean = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW3p2.InversionAboutMean));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestInversionAboutMean, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class GroverIteration : Operation<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public GroverIteration(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "GroverIteration";
        String ICallable.FullName => "HW3p2.GroverIteration";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> InversionAboutMean
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> Oracle
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (successBinary,workQubits,ancillaQubit) = __in;
#line 161 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((successBinary.Count, workQubits.Count, "Success binary and work qubits must have equal length"));
#line 162 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, ancillaQubit));
#line 164 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            Oracle.Apply((successBinary, workQubits, ancillaQubit));
#line 166 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), workQubits));
#line 167 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            InversionAboutMean.Apply(workQubits);
#line 168 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), workQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.InversionAboutMean = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(HW3p2.InversionAboutMean));
            this.Oracle = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>>(typeof(HW3p2.Oracle));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> successBinary, QArray<Qubit> workQubits, Qubit ancillaQubit)
        {
            return __m__.Run<GroverIteration, (QArray<Int64>,QArray<Qubit>,Qubit), QVoid>((successBinary, workQubits, ancillaQubit));
        }
    }

    public class EntryProblem3 : Operation<QVoid, QVoid>, ICallable
    {
        public EntryProblem3(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "EntryProblem3";
        String ICallable.FullName => "HW3p2.EntryProblem3";
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

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> GroverIteration
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 174 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var numWorkQubits = 2L;
#line 175 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var numIterations = 10L;
#line 176 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var successBinary = new QArray<Int64>(2L);
#line 177 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            successBinary[0L] = 0L;
#line 178 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            successBinary[1L] = 0L;
#line 180 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var qubits = Allocate.Apply((numWorkQubits + numIterations));
#line 181 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var workQubits = qubits?.Slice(new Range(0L, (numWorkQubits - 1L)));
#line 182 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var ancillaQubits = qubits?.Slice(new Range(numWorkQubits, (qubits.Count - 1L)));
#line 184 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var testNumWorkQubits = workQubits.Count;
#line 185 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var testNumAncillaQubits = ancillaQubits.Count;
#line 186 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            Message.Apply($"num workQubits: {testNumWorkQubits}");
#line 187 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            Message.Apply($"num ancilla: {testNumAncillaQubits}");
#line 189 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), workQubits));
#line 191 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (numIterations - 1L)))
            {
#line 192 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                Message.Apply($"iteration {i}");
#line 193 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                GroverIteration.Apply((successBinary, workQubits, ancillaQubits[i]));
            }

#line 196 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (workQubits.Count - 1L)))
            {
#line 197 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var successResult = Result.Zero;
#line 198 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                if ((successBinary[i] == 1L))
                {
#line 199 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    successResult = Result.One;
                }

                //;
#line 202 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                Message.Apply($"qubit #{i}");
#line 203 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((successResult, workQubits[i]));
            }

#line 206 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
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
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.GroverIteration = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>>(typeof(HW3p2.GroverIteration));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<EntryProblem3, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Test : Operation<QVoid, QVoid>, ICallable
    {
        public Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Test";
        String ICallable.FullName => "HW3p2.Test";
        protected ICallable<QVoid, QVoid> TestInversionAboutMean
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> TestOracle
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> TestPrepareSuccess
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 213 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            TestPrepareSuccess.Apply(QVoid.Instance);
#line 214 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            TestOracle.Apply(QVoid.Instance);
#line 215 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            TestInversionAboutMean.Apply(QVoid.Instance);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.TestInversionAboutMean = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(HW3p2.TestInversionAboutMean));
            this.TestOracle = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(HW3p2.TestOracle));
            this.TestPrepareSuccess = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(HW3p2.TestPrepareSuccess));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
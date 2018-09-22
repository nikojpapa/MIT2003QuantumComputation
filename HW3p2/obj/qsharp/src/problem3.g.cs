#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("HW3p2", "PrepareSuccess (binaryRep : Int[], qubits : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 520L, 15L, 69L)]
[assembly: OperationDeclaration("HW3p2", "TestPrepareSuccess () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 747L, 24L, 40L)]
[assembly: OperationDeclaration("HW3p2", "Oracle (successBinary : Int[], workQubits : Qubit[], ancillaQubit : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 2549L, 64L, 90L)]
[assembly: OperationDeclaration("HW3p2", "TestOracle () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 2853L, 76L, 32L)]
[assembly: OperationDeclaration("HW3p2", "InversionAboutMean (workQubits : Qubit[]) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 4386L, 118L, 59L)]
[assembly: OperationDeclaration("HW3p2", "GroverIteration (successBinary : Int[], workQubits : Qubit[], ancillaQubit : Qubit) : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 5088L, 138L, 99L)]
[assembly: OperationDeclaration("HW3p2", "EntryProblem3 () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 5462L, 154L, 35L)]
[assembly: OperationDeclaration("HW3p2", "Test () : ()", new string[] { }, "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs", 6785L, 192L, 26L)]
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
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (binaryRep,qubits) = __in;
#line 17 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (binaryRep.Count - 1L)))
            {
#line 18 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                if ((binaryRep[i] == 0L))
                {
#line 19 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
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
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var initialBinaries = new QArray<QArray<Int64>>(1L);
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            initialBinaries[0L] = new QArray<Int64>(2L);
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var allBinaries = GenerateBinaries.Apply((initialBinaries, 0L));
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var workQubits = Allocate.Apply(2L);
#line 31 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (allBinaries.Count - 1L)))
            {
                // every possible solution state
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var successBinary = allBinaries[i];
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var j in new Range(0L, (allBinaries.Count - 1L)))
                {
                    // every possible work qubit state
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var workQubitBinary = allBinaries[j];
#line 36 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var keyCardBinary = new QArray<Int64>(workQubitBinary.Count);
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var k in new Range(0L, (workQubitBinary.Count - 1L)))
                    {
                        // set work qubits
#line 39 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((workQubitBinary[k] == 1L))
                        {
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            MicrosoftQuantumPrimitiveX.Apply(workQubits[k]);
                        }

#line 43 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        keyCardBinary[k] = ((workQubitBinary[k] + (1L - successBinary[k])) % 2L);
                    }

#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    PrepareSuccess.Apply((successBinary, workQubits));
#line 47 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var k in new Range(0L, (workQubits.Count - 1L)))
                    {
#line 48 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        var keyCardResult = Result.Zero;
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((keyCardBinary[k] == 1L))
                        {
#line 50 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            keyCardResult = Result.One;
                        }

                        // Message($"prepare success failure; Success: {successBinary}, workQubitBinary: {workQubitBinary}, keyCardBinary: {keyCardBinary}, qubit: {k}");
#line 54 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        MicrosoftQuantumExtensionsTestingAssertQubit.Apply((keyCardResult, workQubits[k]));
                    }

#line 57 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (successBinary,workQubits,ancillaQubit) = __in;
#line 66 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, ancillaQubit));
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            PrepareSuccess.Apply((successBinary, workQubits));
#line 70 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveH.Apply(ancillaQubit);
#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((workQubits, ancillaQubit));
#line 73 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            PrepareSuccess.Apply((successBinary, workQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.PrepareSuccess = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(HW3p2.PrepareSuccess));
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
#line 78 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var allBinaries = GenerateAllBinariesOfLength.Apply(2L);
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var qubits = Allocate.Apply(3L);
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var workQubits = qubits?.Slice(new Range(0L, 1L));
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var ancillaQubit = qubits[2L];
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (allBinaries.Count - 1L)))
            {
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var successBinary = allBinaries[i];
#line 87 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var j in new Range(0L, (allBinaries.Count - 1L)))
                {
#line 88 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var workQubitBinary = allBinaries[j];
#line 89 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var isSolution = true;
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var k in new Range(0L, (workQubitBinary.Count - 1L)))
                    {
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((workQubitBinary[k] == 1L))
                        {
#line 93 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            MicrosoftQuantumPrimitiveX.Apply(workQubits[k]);
                        }

#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((isSolution && (((successBinary[k] + workQubitBinary[k]) % 2L) != 0L)))
                        {
#line 97 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            isSolution = false;
                        }
                    }

#line 100 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumPrimitiveX.Apply(ancillaQubit);
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    Oracle.Apply((successBinary, workQubits, qubits[2L]));
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumPrimitiveH.Apply(ancillaQubit);
#line 104 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var expectedResult = Result.One;
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    if (isSolution)
                    {
#line 106 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        expectedResult = Result.Zero;
                    }

#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumExtensionsTestingAssertQubit.Apply((expectedResult, ancillaQubit));
#line 110 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    ResetAll.Apply(workQubits);
#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
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
        protected Allocate Allocate
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var workQubits = __in;
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (workQubits.Count - 1L)))
            {
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumPrimitiveX.Apply(workQubits[i]);
            }

#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var toggle = Allocate.Apply(1L);
            // flips phase only if initial state was all |0>
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((workQubits, toggle[0L]));
#line 126 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((toggle, workQubits[0L]));
#line 128 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            ResetAll.Apply(toggle);
#line hidden
            Release.Apply(toggle);
#line 130 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveZ.Apply(workQubits[0L]);
            // flip phase of all states
#line 132 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (workQubits.Count - 1L)))
            {
#line 133 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumPrimitiveX.Apply(workQubits[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
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
#line 140 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            Oracle.Apply((successBinary, workQubits, ancillaQubit));
#line 142 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (workQubits.Count - 1L)))
            {
#line 143 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumPrimitiveH.Apply(workQubits[i]);
            }

#line 146 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            InversionAboutMean.Apply(workQubits);
#line 148 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (workQubits.Count - 1L)))
            {
#line 149 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumPrimitiveH.Apply(workQubits[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 156 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var numWorkQubits = 3L;
#line 157 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var numIterations = 1L;
#line 158 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var successBinary = new QArray<Int64>(2L);
#line 159 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            successBinary[0L] = 0L;
#line 160 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            successBinary[1L] = 0L;
#line 162 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var qubits = Allocate.Apply((2L * numWorkQubits));
#line 163 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var workQubits = qubits?.Slice(new Range(0L, (numWorkQubits - 1L)));
#line 164 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var ancillaQubits = qubits?.Slice(new Range(numWorkQubits, (qubits.Count - 1L)));
#line 166 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (workQubits.Count - 1L)))
            {
#line 167 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumPrimitiveH.Apply(workQubits[i]);
            }

#line 169 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (ancillaQubits.Count - 1L)))
            {
#line 170 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumPrimitiveX.Apply(ancillaQubits[i]);
            }

#line 173 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (numIterations - 1L)))
            {
#line 174 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                GroverIteration.Apply((successBinary, workQubits, ancillaQubits[i]));
            }

#line 177 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (workQubits.Count - 1L)))
            {
#line 178 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var successResult = Result.Zero;
#line 179 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                if ((successBinary[i] == 1L))
                {
#line 180 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    successResult = Result.One;
                }

                //;
#line 183 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                Message.Apply($"qubit #{i}");
#line 184 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((successResult, workQubits[i]));
            }

#line 187 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
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
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.GroverIteration = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>>(typeof(HW3p2.GroverIteration));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
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
#line 194 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            TestPrepareSuccess.Apply(QVoid.Instance);
#line 195 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            TestOracle.Apply(QVoid.Instance);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
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
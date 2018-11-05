#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"GenerateAllBinariesOfLength\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"length\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"GenerateAllBinariesOfLength\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"PrepareSuccess\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"binaryRep\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"PrepareSuccess\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"TestPrepareSuccess\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"TestPrepareSuccess\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"successBinary\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"workQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancillaQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":76}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"Oracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"TestOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":89,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"TestOracle\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":89,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"InversionAboutMean\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":133,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"workQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"InversionAboutMean\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":133,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"TestInversionAboutMean\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":142,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"TestInversionAboutMean\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":142,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":179,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"successBinary\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"workQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancillaQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":85}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":179,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"EntryProblem3\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":191,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"EntryProblem3\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":191,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"Test\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":229,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"Test\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs\",\"Position\":{\"Item1\":229,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"Documentation\":[]}")]
#line hidden
namespace HW3p2
{
    public class GenerateAllBinariesOfLength : Function<Int64, QArray<QArray<Int64>>>, ICallable
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
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var initialBinaries = new QArray<QArray<Int64>>(1L);
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            initialBinaries[0L] = new QArray<Int64>(length);
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            return GenerateBinaries.Apply((initialBinaries?.Copy(), 0L));
        }

        ;
        public override void Init()
        {
            this.GenerateBinaries = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>>(typeof(GenerateBinaries));
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

        protected ICallable Length
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
#line 20 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((binaryRep.Length, qubits.Length, "Binary representation and qubit register must have equal length"));
#line 22 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (binaryRep.Length - 1L)))
#line hidden
            {
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                if ((binaryRep[i] == 0L))
                {
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
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
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
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

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

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

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 33 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var initialBinaries = new QArray<QArray<Int64>>(1L);
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            initialBinaries[0L] = new QArray<Int64>(2L);
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var allBinaries = GenerateBinaries.Apply((initialBinaries?.Copy(), 0L));
#line hidden
            {
#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var workQubits = Allocate.Apply(2L);
#line 40 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var i in new Range(0L, (allBinaries.Length - 1L)))
#line hidden
                {
#line 41 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var successBinary = allBinaries[i];
#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var j in new Range(0L, (allBinaries.Length - 1L)))
#line hidden
                    {
#line 45 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        var workQubitBinary = allBinaries[j];
#line 46 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        var keyCardBinary = new QArray<Int64>(workQubitBinary.Length);
#line 49 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        foreach (var k in new Range(0L, (workQubitBinary.Length - 1L)))
#line hidden
                        {
#line 51 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            if ((workQubitBinary[k] == 1L))
                            {
#line 52 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                                MicrosoftQuantumPrimitiveX.Apply(workQubits[k]);
                            }

#line 55 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            keyCardBinary[k] = ((workQubitBinary[k] + (1L - successBinary[k])) % 2L);
                        }

#line 58 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        PrepareSuccess.Apply((successBinary?.Copy(), workQubits?.Copy()));
#line 60 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        foreach (var k in new Range(0L, (workQubits.Length - 1L)))
#line hidden
                        {
#line 61 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            var keyCardResult = Result.Zero;
#line 63 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            if ((keyCardBinary[k] == 1L))
                            {
#line 64 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                                keyCardResult = Result.One;
                            }

#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((keyCardResult, workQubits[k]));
                        }

#line 71 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        ResetAll.Apply(workQubits?.Copy());
                    }
                }

#line hidden
                Release.Apply(workQubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GenerateBinaries = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Int64), QArray<QArray<Int64>>>>(typeof(GenerateBinaries));
            this.PrepareSuccess = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(PrepareSuccess));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
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
        protected ICallable<(QArray<Int64>,QArray<Qubit>), QVoid> PrepareSuccess
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable Length
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
#line 80 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((successBinary.Length, workQubits.Length, "Success binary and work qubits must have equal length"));
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, ancillaQubit));
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            PrepareSuccess.Apply((successBinary?.Copy(), workQubits?.Copy()));
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveX.Apply(ancillaQubit);
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveH.Apply(ancillaQubit);
#line 85 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((workQubits?.Copy(), ancillaQubit));
#line 86 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            PrepareSuccess.Apply((successBinary?.Copy(), workQubits?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareSuccess = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(PrepareSuccess));
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
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
        protected ICallable<Int64, QArray<QArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> Oracle
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var allBinaries = GenerateAllBinariesOfLength.Apply(2L);
#line hidden
            {
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var qubits = Allocate.Apply(3L);
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var workQubits = qubits?.Slice(new Range(0L, 1L));
#line 96 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var ancillaQubit = qubits[2L];
#line 98 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var i in new Range(0L, (allBinaries.Length - 1L)))
#line hidden
                {
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var successBinary = allBinaries[i];
#line 101 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var j in new Range(0L, (allBinaries.Length - 1L)))
#line hidden
                    {
#line 102 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        var workQubitBinary = allBinaries[j];
#line 103 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        var isSolution = true;
#line 105 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        foreach (var k in new Range(0L, (workQubitBinary.Length - 1L)))
#line hidden
                        {
#line 107 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            if ((workQubitBinary[k] == 1L))
                            {
#line 108 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                                MicrosoftQuantumPrimitiveX.Apply(workQubits[k]);
                            }

#line 111 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            if ((isSolution && (((successBinary[k] + workQubitBinary[k]) % 2L) != 0L)))
                            {
#line 112 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                                isSolution = false;
                            }
                        }

#line 116 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        Oracle.Apply((successBinary?.Copy(), workQubits?.Copy(), qubits[2L]));
#line 117 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        MicrosoftQuantumPrimitiveH.Apply(ancillaQubit);
#line 118 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        var expectedResult = Result.One;
#line 120 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if (isSolution)
                        {
#line 121 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            expectedResult = Result.Zero;
                        }

#line 124 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        MicrosoftQuantumExtensionsTestingAssertQubit.Apply((expectedResult, ancillaQubit));
#line 125 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        ResetAll.Apply(workQubits?.Copy());
#line 126 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        Reset.Apply(ancillaQubit);
                    }
                }

#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(GenerateAllBinariesOfLength));
            this.Oracle = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>>(typeof(Oracle));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
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
#line 137 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, workQubits?.Copy()));
#line 138 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(workQubits), MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits)));
#line 139 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveX, workQubits?.Copy()));
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
        protected ICallable<Int64, QArray<QArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> InversionAboutMean
        {
            get;
            set;
        }

        protected ICallable<(Double,Qubit,Double), QVoid> MicrosoftQuantumCanonAssertPhase
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonHead
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonTail
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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
#line 145 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var allBinaries = GenerateAllBinariesOfLength.Apply(2L);
#line 147 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            foreach (var i in new Range(0L, (allBinaries.Length - 1L)))
#line hidden
            {
#line 148 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var workQubitBinary = allBinaries[i];
#line 149 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var allZeros = true;
#line hidden
                {
#line 151 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var workQubits = Allocate.Apply(workQubitBinary.Length);
#line 153 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    foreach (var j in new Range(0L, (workQubitBinary.Length - 1L)))
#line hidden
                    {
#line 155 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        if ((workQubitBinary[j] == 1L))
                        {
#line 156 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            MicrosoftQuantumPrimitiveX.Apply(workQubits[j]);
#line 157 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                            allZeros = false;
                        }
                    }

#line 161 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    InversionAboutMean.Apply(workQubits?.Copy());
#line 162 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumPrimitiveH.Apply(MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits));
#line 164 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    if (allZeros)
                    {
#line 165 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        MicrosoftQuantumCanonAssertPhase.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits), 1E-10D));
                    }
                    else if ((MicrosoftQuantumCanonTail.Apply<Int64>(workQubitBinary) == 1L))
                    {
#line 168 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        MicrosoftQuantumCanonAssertPhase.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 2D), MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits), 1E-10D));
                    }
                    else if ((MicrosoftQuantumCanonHead.Apply<Int64>(workQubitBinary) == 1L))
                    {
#line 171 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        MicrosoftQuantumCanonAssertPhase.Apply((0D, MicrosoftQuantumCanonTail.Apply<Qubit>(workQubits), 1E-10D));
                    }

#line 174 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    ResetAll.Apply(workQubits?.Copy());
#line hidden
                    Release.Apply(workQubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GenerateAllBinariesOfLength = this.Factory.Get<ICallable<Int64, QArray<QArray<Int64>>>>(typeof(GenerateAllBinariesOfLength));
            this.InversionAboutMean = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(InversionAboutMean));
            this.MicrosoftQuantumCanonAssertPhase = this.Factory.Get<ICallable<(Double,Qubit,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertPhase));
            this.MicrosoftQuantumCanonHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Head<>));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
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

        protected ICallable Length
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

        public override Func<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (successBinary,workQubits,ancillaQubit) = __in;
#line 182 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((successBinary.Length, workQubits.Length, "Success binary and work qubits must have equal length"));
#line 183 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, ancillaQubit));
#line 184 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            Oracle.Apply((successBinary?.Copy(), workQubits?.Copy(), ancillaQubit));
#line 185 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, workQubits?.Copy()));
#line 186 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            InversionAboutMean.Apply(workQubits?.Copy());
#line 187 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, workQubits?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.InversionAboutMean = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(InversionAboutMean));
            this.Oracle = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>>(typeof(Oracle));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
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
        protected ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid> GroverIteration
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected Allocate Allocate
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
#line 194 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var numWorkQubits = 2L;
#line 195 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var numIterations = 1L;
#line 196 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            var successBinary = new QArray<Int64>(2L);
#line 197 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            successBinary[0L] = 0L;
#line 198 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            successBinary[1L] = 0L;
#line hidden
            {
#line 200 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var qubits = Allocate.Apply((numWorkQubits + numIterations));
#line 201 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var workQubits = qubits?.Slice(new Range(0L, (numWorkQubits - 1L)));
#line 202 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var ancillaQubits = qubits?.Slice(new Range(numWorkQubits, (qubits.Length - 1L)));
#line 203 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var testNumWorkQubits = workQubits.Length;
#line 204 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                var testNumAncillaQubits = ancillaQubits.Length;
#line 205 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                Message.Apply(String.Format("num workQubits: {0}", testNumWorkQubits));
#line 206 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                Message.Apply(String.Format("num ancilla: {0}", testNumAncillaQubits));
#line 207 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, workQubits?.Copy()));
#line 209 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var i in new Range(0L, (numIterations - 1L)))
#line hidden
                {
#line 210 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    Message.Apply(String.Format("iteration {0}", i));
#line 211 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    GroverIteration.Apply((successBinary?.Copy(), workQubits?.Copy(), ancillaQubits[i]));
                }

#line 214 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                foreach (var i in new Range(0L, (workQubits.Length - 1L)))
#line hidden
                {
#line 215 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    var successResult = Result.Zero;
#line 217 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    if ((successBinary[i] == 1L))
                    {
#line 218 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                        successResult = Result.One;
                    }

#line 221 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    Message.Apply(String.Format("qubit #{0}", i));
#line 222 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                    MicrosoftQuantumExtensionsTestingAssertQubit.Apply((successResult, workQubits[i]));
                }

#line 225 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
                ResetAll.Apply(qubits?.Copy());
#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GroverIteration = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Qubit>,Qubit), QVoid>>(typeof(GroverIteration));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
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
#line 232 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            TestPrepareSuccess.Apply(QVoid.Instance);
#line 233 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            TestOracle.Apply(QVoid.Instance);
#line 234 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem3.qs"
            TestInversionAboutMean.Apply(QVoid.Instance);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.TestInversionAboutMean = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(TestInversionAboutMean));
            this.TestOracle = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(TestOracle));
            this.TestPrepareSuccess = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(TestPrepareSuccess));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
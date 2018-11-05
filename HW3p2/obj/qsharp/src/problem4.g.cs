#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"FredkinNot\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"controlReg\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"swap1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"swap2\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"FredkinNot\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":9,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"FredkinNot\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":16,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"NControlledU\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Controlled\"},{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Controlled\"},{\"Case\":\"Adjoint\"}]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"NControlledU\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":22,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"NControlledU\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":49,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"NumIsOne\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"num\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":23}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"NumIsOne\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"InitQubit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"index\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"binaryRep\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"InitQubit\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"ControlledX\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"ControlledX\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"HW3p2\",\"Name\":\"Problem4Entry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"HW3p2\",\"Name\":\"Problem4Entry\"},\"SourceFile\":\"/Users/nicholaspapadopoulos/Box%20Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace HW3p2
{
    public class FredkinNot : Adjointable<(QArray<Qubit>,Qubit,Qubit)>, ICallable
    {
        public FredkinNot(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "FredkinNot";
        String ICallable.FullName => "HW3p2.FredkinNot";
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (controlReg,swap1,swap2) = __in;
#line 11 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((controlReg.Length, 1L, "Fredkin only takes one control qubit"));
#line 12 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveX.Apply(controlReg[0L]);
#line 13 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((controlReg?.Copy(), (swap1, swap2)));
#line 14 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveX.Apply(controlReg[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (controlReg,swap1,swap2) = __in;
#line hidden
            MicrosoftQuantumCanonAssertIntEqual.Apply((controlReg.Length, 1L, "Fredkin only takes one control qubit"));
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(controlReg[0L]);
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((controlReg?.Copy(), (swap1, swap2)));
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(controlReg[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> controlReg, Qubit swap1, Qubit swap2)
        {
            return __m__.Run<FredkinNot, (QArray<Qubit>,Qubit,Qubit), QVoid>((controlReg, swap1, swap2));
        }
    }

    public class NControlledU : Adjointable<(QArray<Qubit>,IUnitary)>, ICallable
    {
        public NControlledU(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,IUnitary)>, IApplyData
        {
            public In((QArray<Qubit>,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "NControlledU";
        String ICallable.FullName => "HW3p2.NControlledU";
        protected IAdjointable<(QArray<Qubit>,Qubit,Qubit)> FredkinNot
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonSubarray
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
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

        public override Func<(QArray<Qubit>,IUnitary), QVoid> Body => (__in) =>
        {
            var (qubits,op) = __in;
#line 24 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var controlReg = MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits);
#line 25 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var targetReg = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
            {(qubits.Length - 1L)}, qubits?.Copy()));
#line 26 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var target = targetReg[0L];
#line 27 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var numControlQubits = controlReg.Length;
#line 28 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var halfNum = (numControlQubits / 2L);
#line 29 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var topControl = controlReg?.Slice(new Range(0L, (halfNum - 1L)));
#line 30 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var bottomControl = controlReg?.Slice(new Range(halfNum, (numControlQubits - 1L)));
#line hidden
            {
#line 32 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                var workQ = Allocate.Apply(1L);
#line 34 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                foreach (var i in new Range(0L, (halfNum - 1L)))
#line hidden
                {
#line 35 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    FredkinNot.Apply((MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
                    {i}, topControl?.Copy())), bottomControl[i], workQ[0L]));
#line 37 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    if ((halfNum == 1L))
                    {
#line 38 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                        op.Controlled.Apply((bottomControl?.Copy(), target));
                    }
                    else
                    {
#line 41 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                        ((IAdjointable)this).Apply(((bottomControl + targetReg), op));
                    }

#line 44 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    FredkinNot.Apply((MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
                    {i}, topControl?.Copy())), bottomControl[i], workQ[0L]));
                }

#line hidden
                Release.Apply(workQ);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,IUnitary), QVoid> AdjointBody => (__in) =>
        {
            var (qubits,op) = __in;
#line hidden
            var controlReg = MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits);
#line hidden
            var targetReg = MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
            {(qubits.Length - 1L)}, qubits?.Copy()));
#line hidden
            var target = targetReg[0L];
#line hidden
            var numControlQubits = controlReg.Length;
#line hidden
            var halfNum = (numControlQubits / 2L);
#line hidden
            var topControl = controlReg?.Slice(new Range(0L, (halfNum - 1L)));
#line hidden
            var bottomControl = controlReg?.Slice(new Range(halfNum, (numControlQubits - 1L)));
#line hidden
            {
#line hidden
                var workQ = Allocate.Apply(1L);
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (halfNum - 1L))))
#line hidden
                {
#line hidden
                    FredkinNot.Adjoint.Apply((MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
                    {i}, topControl?.Copy())), bottomControl[i], workQ[0L]));
#line hidden
                    if ((halfNum == 1L))
                    {
#line hidden
                        op.Controlled.Adjoint.Apply((bottomControl?.Copy(), target));
                    }
                    else
                    {
#line hidden
                        ((IAdjointable)this).Adjoint.Apply(((bottomControl + targetReg), op));
                    }

#line hidden
                    FredkinNot.Adjoint.Apply((MicrosoftQuantumCanonSubarray.Apply<QArray<Qubit>>((new QArray<Int64>()
                    {i}, topControl?.Copy())), bottomControl[i], workQ[0L]));
                }

#line hidden
                Release.Apply(workQ);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.FredkinNot = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,Qubit)>>(typeof(FredkinNot));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.MicrosoftQuantumCanonSubarray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Subarray<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((QArray<Qubit>,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits, IUnitary op)
        {
            return __m__.Run<NControlledU, (QArray<Qubit>,IUnitary), QVoid>((qubits, op));
        }
    }

    public class NumIsOne : Function<Int64, Boolean>, ICallable
    {
        public NumIsOne(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "NumIsOne";
        String ICallable.FullName => "HW3p2.NumIsOne";
        public override Func<Int64, Boolean> Body => (__in) =>
        {
            var num = __in;
#line 56 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            return (num == 1L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 num)
        {
            return __m__.Run<NumIsOne, Int64, Boolean>(num);
        }
    }

    public class InitQubit : Operation<(Int64,QArray<Int64>,Qubit), QVoid>, ICallable
    {
        public InitQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>,Qubit)>, IApplyData
        {
            public In((Int64,QArray<Int64>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "InitQubit";
        String ICallable.FullName => "HW3p2.InitQubit";
        protected ICallable<Int64, Boolean> NumIsOne
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonApplyIf
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>,Qubit), QVoid> Body => (__in) =>
        {
            var (index,binaryRep,target) = __in;
#line 62 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumCanonApplyIf.Apply((MicrosoftQuantumPrimitiveX, NumIsOne.Apply(binaryRep[index]), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.NumIsOne = this.Factory.Get<ICallable<Int64, Boolean>>(typeof(NumIsOne));
            this.MicrosoftQuantumCanonApplyIf = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyIf<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 index, QArray<Int64> binaryRep, Qubit target)
        {
            return __m__.Run<InitQubit, (Int64,QArray<Int64>,Qubit), QVoid>((index, binaryRep, target));
        }
    }

    public class ControlledX : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public ControlledX(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ControlledX";
        String ICallable.FullName => "HW3p2.ControlledX";
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

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qubits = __in;
#line 68 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((MicrosoftQuantumCanonMost.Apply<QArray<Qubit>>(qubits), MicrosoftQuantumCanonTail.Apply<Qubit>(qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<ControlledX, QArray<Qubit>, QVoid>(qubits);
        }
    }

    public class Problem4Entry : Operation<QVoid, QVoid>, ICallable
    {
        public Problem4Entry(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Problem4Entry";
        String ICallable.FullName => "HW3p2.Problem4Entry";
        protected ICallable<Int64, QArray<QArray<Int64>>> GenerateAllBinariesOfLength
        {
            get;
            set;
        }

        protected ICallable<(Int64,QArray<Int64>,Qubit), QVoid> InitQubit
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,IUnitary)> NControlledU
        {
            get;
            set;
        }

        protected ICallable<Int64, Boolean> NumIsOne
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonApplyToEachIndex
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumCanonBoolFromResult
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonForAll
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMost
        {
            get;
            set;
        }

        protected ICallable<Boolean, Result> MicrosoftQuantumCanonResultFromBool
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
#line 74 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var numQubits = 5L;
#line 77 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
            var allBinaries = GenerateAllBinariesOfLength.Apply(numQubits);
#line hidden
            {
#line 79 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                var qubits = Allocate.Apply(numQubits);
#line 81 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                foreach (var i in new Range(0L, (allBinaries.Length - 1L)))
#line hidden
                {
#line 82 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    var thisBinary = allBinaries[i];
#line 83 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    Message.Apply(String.Format("thisBinary: {0}", thisBinary));
#line 84 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    MicrosoftQuantumCanonApplyToEachIndex.Apply((InitQubit.Partial(new Func<(Int64,Qubit), (Int64,QArray<Int64>,Qubit)>((_arg1) => (_arg1.Item1, thisBinary?.Copy(), _arg1.Item2))), qubits?.Copy()));
#line 91 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    NControlledU.Apply((qubits?.Copy(), MicrosoftQuantumPrimitiveX));
#line 92 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    var expectedResult = MicrosoftQuantumCanonResultFromBool.Apply(NumIsOne.Apply(MicrosoftQuantumCanonTail.Apply<Int64>(thisBinary)));
#line 94 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    if (MicrosoftQuantumCanonForAll.Apply<Boolean>((NumIsOne, MicrosoftQuantumCanonMost.Apply<QArray<Int64>>(thisBinary))))
                    {
#line 95 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                        expectedResult = MicrosoftQuantumCanonResultFromBool.Apply(!(MicrosoftQuantumCanonBoolFromResult.Apply(expectedResult)));
                    }

#line 98 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    MicrosoftQuantumExtensionsTestingAssertQubit.Apply((expectedResult, MicrosoftQuantumCanonTail.Apply<Qubit>(qubits)));
#line 99 "/Users/nicholaspapadopoulos/Box Sync/CS/Me/quantum/MIT2003QuantumComputation/HW3p2/problem4.qs"
                    ResetAll.Apply(qubits?.Copy());
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
            this.InitQubit = this.Factory.Get<ICallable<(Int64,QArray<Int64>,Qubit), QVoid>>(typeof(InitQubit));
            this.NControlledU = this.Factory.Get<IAdjointable<(QArray<Qubit>,IUnitary)>>(typeof(NControlledU));
            this.NumIsOne = this.Factory.Get<ICallable<Int64, Boolean>>(typeof(NumIsOne));
            this.MicrosoftQuantumCanonApplyToEachIndex = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEachIndex<>));
            this.MicrosoftQuantumCanonBoolFromResult = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.BoolFromResult));
            this.MicrosoftQuantumCanonForAll = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ForAll<>));
            this.MicrosoftQuantumCanonMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Most<>));
            this.MicrosoftQuantumCanonResultFromBool = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Canon.ResultFromBool));
            this.MicrosoftQuantumCanonTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Problem4Entry, QVoid, QVoid>(QVoid.Instance);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public sealed class AsmProductions : WfService<AsmProductions>
    {
        protected override void OnInit()
        {

        }

        static string format(MemoryAddress @base, CodeBlock code)
            => string.Format("{0}[{1}] => {2}", @base.Format(), code.Length, code.Format());

        AsmSigExpr sig(in ApiInstruction src)
            => AsmSyntax.sig(src.Instruction.OpCode.InstructionString);

        AsmFormExpr form(in ApiInstruction src)
            => asm.form(src.OpCode, sig(src));

        AsmThumbprint thumbprint(in ApiInstruction src)
            => AsmThumbprints.define(form(src), AsmBytes.hexcode(src.EncodedData));

        string describe(in ApiInstruction src)
            => string.Format("{0} {1}", (Address16)src.Offset, thumbprint(src));

        AsmStatementExpr statement(ApiInstruction src)
        {

            return src.FormattedInstruction.Replace(" ptr", EmptyString);
        }

        void Produce(in ApiInstruction src, ITextBuffer dst)
            => dst.Append(string.Format("{0} {1}", string.Format("{0,-46}", statement(src)), asm.comment(describe(src))));

        void FormatHeader(in AsmMemberRoutine src, ITextBuffer dst)
        {
            dst.AppendLine(asm.comment(src.Member.OpUri.Format()));
            dst.AppendLine(asm.comment(format(src.Base, src.CodeBlock.Code)));
            dst.AppendLine(asm.blocklabel(src.Base));
        }

        uint ProduceInstructions(in AsmMemberRoutine src, ITextBuffer dst)
        {
            var instructions = src.Instructions.View;
            var count = instructions.Length;
            var counter = 0u;
            for(var i=0u; i<count; i++)
            {
                Produce(skip(instructions,i), dst);
                dst.AppendLine();
                counter++;
            }
            return counter;
        }

        uint Produce(ReadOnlySpan<AsmMemberRoutine> src, FS.FilePath dst)
        {
            var count = src.Length;
            var flow = Wf.EmittingFile(dst, string.Format("Creating productions for <{0}> routines", count));
            var buffer = text.buffer();
            var counter = 0u;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var routine = ref skip(src,i);

                writer.WriteLine(AsmComment.separate());
                FormatHeader(routine, buffer);
                writer.Write(buffer.Emit());

                counter += ProduceInstructions(routine, buffer);
                writer.Write(buffer.Emit());
            }
            Wf.EmittedFile(flow, count);
            return counter;
        }

        static bool filter(AsmMemberRoutine src)
            => src.Member.Host == Prototypes.Extensions.Uri;

        public void Produce()
        {
            var dst = Db.ToolInFile(Toolsets.nasm, "extensions", FS.Extensions.Asm);
            var flow = Wf.Running();
            var options = CaptureWorkflowOptions.EmitImm;
            var parts = root.array(PartId.AsmLang, PartId.AsmZ);
            var routines = Capture.run(Wf, parts, options);
            var filtered = span<AsmMemberRoutine>(routines.Length);
            var count = AsmRoutines.filter(routines,filter,filtered);
            var statements = Produce(slice(filtered,0, count), dst);
            Wf.Ran(flow, string.Format("Produced <{0}> statements for <{1}> routines", statements, count));
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public sealed class AsmStatementProducer : WfService<AsmStatementProducer>
    {
        public uint Produce(in AsmMemberRoutine src, ITextBuffer dst)
        {
            dst.AppendLine(PageBreak);
            FormatHeader(src, dst);
            return produce(src, dst);
        }

        public uint Produce(ReadOnlySpan<AsmMemberRoutine> src, FS.FilePath dst)
        {
            var count = src.Length;
            var flow = Wf.EmittingFile(dst, Msg.CreatingStatements.Format(count));
            var buffer = text.buffer();
            var counter = 0u;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var routine = ref skip(src,i);
                writer.WriteLine(PageBreak);
                FormatHeader(routine, buffer);
                writer.Write(buffer.Emit());

                counter += produce(routine, buffer);
                writer.Write(buffer.Emit());
            }
            Wf.EmittedFile(flow, counter);
            return counter;
        }

        public uint Produce(ToolId consumer, params ApiHostUri[] hosts)
        {
            var options = CaptureWorkflowOptions.None;
            var routines = Capture.run(Wf, hosts, options).View;
            var count = routines.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var hr = ref skip(routines,i);
                var dst = Db.ToolInput(consumer, FS.file(hr.Host, FS.Asm));
                counter += Produce(skip(routines,i).View, dst);
            }
            return counter;
        }

        public void Produce(string name, ToolId consumer, params PartId[] parts)
        {
            var dst = Db.ToolInput(consumer, name, FS.Asm);
            var flow = Wf.Running();
            var options = CaptureWorkflowOptions.EmitImm;
            var routines = Capture.run(Wf, parts, options);
            var statements = Produce(routines.View, dst);
            Wf.Ran(flow);
        }

        static void FormatHeader(in AsmMemberRoutine src, ITextBuffer dst)
        {
            dst.AppendLine(AsmCore.comment(src.Member.OpUri.Format()));
            dst.AppendLine(AsmCore.comment(format(src.Base, src.CodeBlock.Code)));
            dst.AppendLine(AsmCore.blocklabel(src.Base));
        }

        static uint produce(in AsmMemberRoutine src, ITextBuffer dst)
        {
            var instructions = src.Instructions.View;
            var count = instructions.Length;
            var counter = 0u;
            for(var i=0u; i<count; i++)
            {
                produce(skip(instructions,i), dst);
                dst.AppendLine();
                counter++;
            }
            return counter;
        }

        static AsmSigExpr sig(in ApiInstruction src)
            => AsmSyntax.sig(src.Instruction.OpCode.InstructionString);

        static AsmFormExpr form(in ApiInstruction src)
            => AsmCore.form(src.OpCode, sig(src));

        static AsmThumbprint thumbprint(in ApiInstruction src)
            => AsmThumbprints.define(src.Statment, form(src), AsmBytes.hexcode(src.EncodedData));

        static string format(MemoryAddress @base, CodeBlock code)
            => string.Format("{0}[{1}] => {2}", @base.Format(), code.Length, code.Format());

        static string describe(in ApiInstruction src)
            => string.Format("{0} {1}", (Address16)src.Offset, thumbprint(src));

        static AsmStatementExpr statement(ApiInstruction src)
            => src.Statment.Replace(" ptr", EmptyString);

        static void produce(in ApiInstruction src, ITextBuffer dst)
            => dst.Append(string.Format("{0} {1}", string.Format("{0,-46}", statement(src)), AsmCore.comment(describe(src))));

        const string PageBreak = "----------------------------------------------------------------------------------------------------------------------------------------------------------------";
    }
}
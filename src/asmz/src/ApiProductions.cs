//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    using Z0.Asm;

    public sealed class ApiProductions : WfService<ApiProductions>
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

        uint Produce(in AsmMemberRoutine src, ITextBuffer dst)
        {
            dst.AppendLine(AsmComment.separate());
            FormatHeader(src, dst);
            return ProduceInstructions(src, dst);
        }

        uint Produce(ReadOnlySpan<AsmMemberRoutine> src, FS.FilePath dst)
        {
            var count = src.Length;
            var flow = Wf.EmittingFile(dst, Msg.CreatingProductions.Format(count));
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
            Wf.EmittedFile(flow, counter);
            return counter;
        }

        uint Produce(AsmMemberRoutines src, FS.FilePath dst)
        {
            var counter = 0u;
            var count = src.Count;
            var host = src.Host;
            var flow = Wf.EmittingFile(dst, Msg.CreatingHostProductions.Format(count,host));
            var view = src.View;
            var buffer = text.buffer();
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                counter += Produce(skip(view,i), buffer);
                writer.Write(buffer.Emit());
            }
            Wf.EmittedFile(flow, counter);
            return counter;
        }

        static bool filter(AsmMemberRoutine src)
            => src.Member.Host == Prototypes.Extensions.Uri;

        public uint Produce(ToolId consumer, params ApiHostUri[] hosts)
        {
            var options = CaptureWorkflowOptions.None;
            var routines = Capture.run(Wf, hosts, options).View;
            var count = routines.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var hr = ref skip(routines,i);
                var dst = Db.ToolInput(consumer, FS.file(hr.Host, FS.Extensions.Asm));
                counter += Produce(skip(routines,i), dst);
            }
            return counter;
        }

        public void Produce()
        {
            var dst = Db.ToolInput(Toolsets.nasm, "extensions", FS.Extensions.Asm);
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

    partial struct Msg
    {
        public static MsgPattern<Count> CreatingProductions => "Creating {0} routine productions";

        public static MsgPattern<Count,ApiHostUri> CreatingHostProductions => "Creating {0} {1} routine productions";

    }
}
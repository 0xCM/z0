//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    using T = AsmGenTarget;

    partial class AsmGen
    {
        public void EmitStatementBuilder(ReadOnlySpan<AsmMnemonic> src)
        {
            var buffer = text.buffer();
            var margin = 0u;
            buffer.AppendLine("namespace Z0.Asm");
            buffer.AppendLine(Open);
            margin += Indent;
            buffer.IndentLine(margin, "using System.Runtime.CompilerServices;");
            buffer.IndentLine(margin, "using static Part;");
            buffer.IndentLine(margin, $"using static {TargetIdentifier(T.InstructionTypes)};");
            buffer.AppendLine();

            buffer.IndentLine(margin, $"public class {TargetIdentifier(T.StatementBuilder)}");
            buffer.IndentLine(margin, Open);
            margin += Indent;

            EmitStatementFactories(margin, src, buffer);

            margin -= Indent;
            buffer.IndentLine(margin, Close);

            margin -= Indent;
            buffer.IndentLine(margin, Close);

            var dst = GetTargetPath(T.StatementBuilder);
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());
            Wf.EmittedFile(flow,1);
        }

    }
}
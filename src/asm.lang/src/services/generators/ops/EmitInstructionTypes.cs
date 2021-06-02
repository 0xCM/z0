//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmGen
    {
        [Op]
        void EmitInstructionTypes(ReadOnlySpan<AsmMnemonic> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var buffer = text.buffer();
            var margin = 0u;
            buffer.AppendLine(string.Format(NamespaceDeclPattern, TargetNamespaceName));
            buffer.AppendLine(Open);
            margin += Indent;
            buffer.IndentLine(margin, UsingCompilerServices);
            buffer.IndentLine(margin, UsingRoot);
            buffer.AppendLine();

            buffer.IndentLine(margin, string.Format(ReadOnlyStructDeclPattern, InstructionContainerName));
            buffer.IndentLine(margin, Open);
            margin += Indent;
            var model = InstructionModel.Empty;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var monic = ref skip(src,i);
                model = monic;
                model.RenderType(margin, buffer);
            }

            margin -= Indent;
            buffer.IndentLine(margin, Close);

            margin -= Indent;
            buffer.IndentLine(margin, Close);

            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());

            Wf.EmittedFile(flow, src.Length);
        }
    }
}
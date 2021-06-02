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
        void EmitMonicExpressions(ReadOnlySpan<AsmMnemonic> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var buffer = text.buffer();
            EmitMonicExpressions(src,0,buffer);
            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());
            Wf.EmittedFile(flow, src.Length);
        }

        public static void EmitMonicExpressions(ReadOnlySpan<AsmMnemonic> src, uint margin, ITextBuffer buffer)
        {
            buffer.AppendLine(AsmNamespaceDecl);
            buffer.AppendLine(Open);
            margin += 4;
            buffer.IndentLine(margin, string.Format(ReadOnlyStructDeclPattern, MonicContainerName));
            buffer.IndentLine(margin, Open);
            margin += 4;

            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var monic = ref skip(src,i);
                buffer.IndentLine(margin, string.Format(MonicPropertyPattern, monic.Name));
                buffer.AppendLine();
            }
            margin -= 4;
            buffer.IndentLine(margin, Close);

            margin -= 4;
            buffer.IndentLine(margin, Close);
        }
    }
}
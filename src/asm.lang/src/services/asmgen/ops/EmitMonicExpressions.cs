//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmModelGen
    {
        const string MonicPropertyPattern = "public static AsmMnemonic {0} => nameof({0});";

        const string MonicContainerName = "AsmMnemonics";

        const string ApiCompleteAttribute = "[ApiComplete]";

        void EmitMonicExpressions(ReadOnlySpan<string> monics, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var buffer = text.buffer();
            EmitMonicExpressions(monics,0,buffer);
            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());
            Wf.EmittedFile(flow, monics.Length);
        }

        public static void EmitMonicExpressions(ReadOnlySpan<string> monics, uint margin, ITextBuffer buffer)
        {
            buffer.AppendLine(AsmNamespaceDecl);
            buffer.AppendLine(Open);
            margin += 4;
            buffer.IndentLine(margin, ApiCompleteAttribute);
            buffer.IndentLine(margin, string.Format(ReadOnlyStructDeclPattern, MonicContainerName));
            buffer.IndentLine(margin, Open);
            margin += 4;

            var count = monics.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var monic = ref skip(monics,i);
                buffer.IndentLine(margin, string.Format(MonicPropertyPattern, monic));
                buffer.AppendLine();
            }
            margin -= 4;
            buffer.IndentLine(margin, Close);

            margin -= 4;
            buffer.IndentLine(margin, Close);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    partial class AsmGen
    {
        void EmitMonicExpressions(Index<AsmMnemonic> src)
        {
            var dst = GetTargetPath(AsmGenTarget.MonicExpression);
            var flow = Wf.EmittingFile(dst);
            EmitMonicExpressions(src,dst);
            Wf.EmittedFile(flow,src.Count, dst);
        }

        void EmitMonicExpressions(Index<AsmMnemonic> src, FS.FilePath dst)
        {
            var buffer = text.buffer();
            var margin = 0u;
            MonicExpressionModel model = src.Storage;
            model.Render(margin,buffer);
            // buffer.AppendLine("namespace Z0.Asm");
            // buffer.AppendLine("{");
            // margin += 4;
            // buffer.IndentLine(margin, "public readonly struct AsmMnemonics");
            // buffer.IndentLine(margin, "{");
            // margin += 4;

            // var count = src.Length;
            // for(var i=0; i<count; i++)
            // {
            //     ref readonly var monic = ref skip(src,i);
            //     buffer.IndentLine(margin, string.Format("public static AsmMnemonic {0} => nameof({0});", monic.Name));
            //     buffer.AppendLine();
            // }
            // margin -= 4;
            // buffer.IndentLine(margin, "}");

            // margin -= 4;
            // buffer.IndentLine(margin, "}");

            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());
        }

    }
}
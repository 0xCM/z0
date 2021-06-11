//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using T = AsmGenTarget;

    partial class AsmGen
    {
        void EmitMonicEnum(ReadOnlySpan<string> monics, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var buffer = text.buffer();
            EmitMonicEnumLiterals(monics,0,buffer);
            using var writer = dst.Writer();
            writer.Write(Dev.SourceHeader());
            writer.Write(buffer.Emit());
            Wf.EmittedFile(flow, monics.Length);
        }

        public static void EmitMonicEnumLiterals(ReadOnlySpan<string> monics, uint margin, ITextBuffer buffer)
        {
            buffer.AppendLine(AsmNamespaceDecl);
            buffer.AppendLine(Open);
            margin += 4;
            buffer.IndentLine(margin, string.Format(EnumDeclPattern, TargetIdentifier(T.MonicCodeEnum), MonicEnumType));
            buffer.IndentLine(margin, Open);
            margin += 4;

            // buffer.IndentLine(margin, string.Format(ItemAssignPattern, ZeroEnumMemberName, "0"));
            // buffer.AppendLine();

            var count = monics.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var monic = ref skip(monics,i);
                buffer.IndentLine(margin, string.Format(MonicSymbolPattern, monic.ToLower()));
                buffer.IndentLine(margin, string.Format(ItemAssignPattern, monic, i+1));
                buffer.AppendLine();
            }
            margin -= 4;
            buffer.IndentLine(margin, Close);

            margin -= 4;
            buffer.IndentLine(margin, Close);
        }
    }
}
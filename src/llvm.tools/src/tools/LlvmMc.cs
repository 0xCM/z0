//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using static LlvmMc.SyntaxLineKind;

    public struct McSyntaxBlock
    {
        public TextBlock Statement;

        public BinaryCode Encoding;

    }

    public sealed partial class LlvmMc : ToolService<LlvmMc>
    {
        const string EncodingMarker = "# encoding";

        const string OpenSyntaxMarker = "<MCInst";

        const string CloseSyntaxMarker = ">>";

        const string OperandSyntaxMarker = "<MCOperand";

        public override ToolId Id
            => LlvmToolNames.llvm_mc;

        public void ParseSyntax(FS.FilePath src)
        {
            var lines = src.ReadNumberedLines();
            var count = lines.Length;
            if(count < 2)
                return;

            for(var i=1; i<count; i++)
            {
                ref readonly var prior = ref skip(lines,i-1);
                ref readonly var current = ref skip(lines,i);
                var kind = classify(current);
                if(kind == 0)
                    continue;

                switch(kind)
                {
                    case Encoding:
                    break;

                    case OpenSyntax:
                    break;

                    case OperandSyntax:
                    break;

                    case CloseSyntax:
                    break;
                }
            }
        }

        public static SyntaxLineKind classify(in TextLine src)
        {
            var result = SyntaxLineKind.None;
            var content = src.Content.Trim();
            var i = NotFound;

            i = text.index(content, OperandSyntaxMarker);
            if(i >= 0)
                return OperandSyntax;

            i = text.index(content, EncodingMarker);
            if(i >= 0)
                return Encoding;

            i = text.index(content, OpenSyntaxMarker);
            if(i >= 0)
                return OpenSyntax;

            i = text.index(content, CloseSyntaxMarker);
            if(i >= 0)
                return CloseSyntax;

            return result;
        }

        public enum SyntaxLineKind : byte
        {
            None,

            Encoding,

            OpenSyntax,

            OperandSyntax,

            CloseSyntax
        }
    }
}
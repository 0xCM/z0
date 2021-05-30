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
        public void EmitStatementFactories(uint margin, ReadOnlySpan<AsmMnemonic> src, ITextBuffer dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                EmitStatementFactories(margin, skip(src,i), dst);
        }

        public void EmitStatementFactories(uint margin, AsmMnemonic mnemonic, ITextBuffer dst)
        {
            dst.IndentLine(margin, string.Format("public {0} {1}() => default;", MonicTypeName(mnemonic), MonicFactoryName(mnemonic)));
            dst.AppendLine();
            dst.IndentLine(margin, InlineOpAttributeSpec);
            dst.IndentLine(margin, string.Format("public {0} {1}(AsmHexCode encoded) => new {0}(encoded);", MonicTypeName(mnemonic), MonicFactoryName(mnemonic)));
            dst.AppendLine();
        }
    }
}
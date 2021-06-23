//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmExpr statement(string src)
            => new AsmExpr(src.Trim());

        [Op]
        public static AsmExpr statement(AsmMnemonic monic, ReadOnlySpan<char> operands)
            => new AsmExpr(string.Format("{0} {1}", monic.Format(MnemonicCase.Lowercase), TextTools.format(operands)));
    }
}
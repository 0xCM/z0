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
        public static AsmExpr expr<R,I>(AsmMnemonic monic, R r, I imm)
            where R : IRegOp
            where I : IImmOp
                => string.Format("{0} {1},{2}", monic.Format(MnemonicCase.Lowercase), r.Format(), imm);

        [MethodImpl(Inline), Op]
        public static AsmExpr expr(string src)
            => new AsmExpr(src.Trim());

        [Op]
        public static AsmExpr expr(AsmMnemonic monic, ReadOnlySpan<char> operands)
            => new AsmExpr(string.Format("{0} {1}", monic.Format(MnemonicCase.Lowercase), text.format(operands)));
    }
}
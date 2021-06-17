//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOpTypes;

    partial struct asm
    {
        public static AsmExpr expr<R,I>(AsmMnemonic monic, R r, I imm)
            where R : IRegOp
            where I : IImmOp
                => string.Format("{0} {1},{2}", monic.Format(MnemonicCase.Lowercase), r.Format(), imm);
    }
}
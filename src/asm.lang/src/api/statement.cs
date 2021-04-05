//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {

        [MethodImpl(Inline), Op]
        public static AsmSigExpr sig(AsmMnemonic mnemonic, string formatted)
            => new AsmSigExpr(mnemonic,formatted);

        [MethodImpl(Inline), Op]
        public static AsmStatementExpr statement(string src)
            => new AsmStatementExpr(src.Trim());
    }
}
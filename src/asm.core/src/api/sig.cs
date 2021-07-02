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
        public static AsmSigExpr sig(AsmMnemonic mnemonic, string content)
            => new AsmSigExpr(mnemonic, content);

        [Op]
        public static AsmSigExpr sig(string src)
        {
            if(AsmParser.sig(src, out var dst))
                return dst;
            else
                return AsmSigExpr.Empty;
        }
    }
}
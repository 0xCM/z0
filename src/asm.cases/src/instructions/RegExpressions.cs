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
    using T = AsmOpTypes;
    using static AsmRegOps;

    public readonly struct RegExprCases
    {

        [MethodImpl(Inline), Op]
        public static RegExpr<T.r8> expr1()
            => asm.regxpr(al, cl, ScaleFactor.S2, 0x8);

    }
}

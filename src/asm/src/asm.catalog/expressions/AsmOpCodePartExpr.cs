//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodePartExpr
    {
        public readonly asci8 Data;

        [MethodImpl(Inline)]
        public AsmOpCodePartExpr(asci8 src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Data;
    }
}
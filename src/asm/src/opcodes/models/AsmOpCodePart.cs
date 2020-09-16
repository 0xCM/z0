//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmOpCodePart
    {
        public readonly asci8 Data;

        [MethodImpl(Inline)]
        public AsmOpCodePart(asci8 src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Data;
    }
}
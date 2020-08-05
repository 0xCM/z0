//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct OpCodePart
    {
        public readonly asci8 Data;

        [MethodImpl(Inline)]
        public OpCodePart(asci8 src)
            => Data = src; 

        public string Format()
            => Data.Format();
    }
}
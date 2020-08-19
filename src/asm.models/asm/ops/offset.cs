//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static ScaledOffset offset(ulong @base, ushort offset, byte scale)
            => new ScaledOffset(@base, offset, scale);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;         

    [ApiHost]
    public readonly struct RexEncoder
    {
        [MethodImpl(Inline), Op]
        public static RexPrefixBits bits(byte src)
            => new RexPrefixBits(src);
    }
}